using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        private Thread ClockThread;
        private Thread DataSyncThread;
        private bool listening;
        //private event EventHandler MyEvent;
        public class TimeStampChangedEventArgs : EventArgs
        {
            public byte[] TimeStamp { get; set; }
            //public DataTable DataTable { get; set; }
            public TimeStampChangedEventArgs(byte[] timestamp)//,DataTable dataTable)
            {
                this.TimeStamp = timestamp;
                //this.DataTable = dataTable;
            }
            
        }
        public event TimeStampChangedEventHandler TimeStampChanged;

        public delegate void TimeStampChangedEventHandler(object sender, TimeStampChangedEventArgs e);

        private delegate void settime();
        private int threadcounter = 0;
        private SqlConnection sqlConnection;
        private SqlConnection sqlConnection2;

        private byte[] timestamp;

        
        public Form1()
        {
            InitializeComponent();
            //this.MyEvent += new EventHandler(Form1_MyEvent);
            this.TimeStampChanged += new TimeStampChangedEventHandler(Form1_TimeStampChanged);
            StartUp();

        }

        void Form1_TimeStampChanged(object sender, Form1.TimeStampChangedEventArgs e)
        {
            byte[] tempTimeStamp = null;
            if (this.dataGridView1.DataSource != null)
            {
                tempTimeStamp = e.TimeStamp;
            }
            using (SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1000 * FROM [SandBox].[dbo].[Entity] where [TimeStamp] > isnull(@TimeStamp,0) order by [TimeStamp] desc", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.Text;
                
                sqlCommand.Parameters.Add(new SqlParameter("@TimeStamp", SqlDbType.Timestamp) { IsNullable = true, Value=DBNull.Value });
                if (tempTimeStamp != null)
                {
                    sqlCommand.Parameters["@TimeStamp"].Value = tempTimeStamp;
                }
                
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new System.Data.DataTable();

                da.Fill(dataTable);
 

                if (this.dataGridView1.DataSource == null)
                {
                    DataColumn[] PrimaryKeys = { dataTable.Columns["EntityID"], dataTable.Columns["EntityGUID"] };
                    dataTable.PrimaryKey = PrimaryKeys;
                    dataTable.Columns["TimeStamp"].ColumnMapping = MappingType.Hidden;
                    this.dataGridView1.DataSource = dataTable;
                    
                }
                else
                {
                    //Thread.Sleep(5000);
                    //((DataTable)this.dataGridView1.DataSource).
                    if (!this.dataGridView1.IsCurrentCellInEditMode)
                    {
                        ((DataTable)this.dataGridView1.DataSource).Merge(dataTable);
                    }
                }

                //((DataTable)this.dataGridView1.DataSource).Merge(dataTable);
                //this.dataGridView1.DataSource = dataTable;
                this.timestamp = e.TimeStamp;
            }                       
        }

        private void StartUp()
        {

            threadcounter++;
            this.ClockThread = new Thread(new ThreadStart(TickTock));
            this.ClockThread.Name = "Clock_" + threadcounter.ToString().PadLeft(5, '0');
            this.ClockThread.Start();
            this.DataSyncThread = new Thread(new ThreadStart(CheckDataVersion));
            this.DataSyncThread.Start();
        }

        private void Save()
        {
            DataTable _DataTable = (DataTable)this.dataGridView1.DataSource;
            
            DataTable ChangesDataTable = ((DataTable)this.dataGridView1.DataSource).GetChanges();

            if (ChangesDataTable != null && ChangesDataTable.Rows.Count > 0)
            {
                this.sqlConnection2 = new SqlConnection(@"Data Source=RTHOR-PC\SQL2008R2;Initial Catalog=SandBox;Integrated Security=True");
                for (int x = 0; x < ChangesDataTable.Rows.Count; x++)
                {
                    string command = null;
                    switch(ChangesDataTable.Rows[x].RowState)
                    {
                        case DataRowState.Added:
                            command = "Insert into [dbo].[Entity] values(Data) Values('" + ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("Data")]+ "')";
                            break;
                        case DataRowState.Modified:
                            command = "update [dbo].[Entity] set Data = '" + ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("Data")] + "' where [EntityGUID] = '" + ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("EntityGUID")] + "'";
                            break;
                    }
                    SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection2);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = command;
                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Connection.Close();
                    object[] PrimaryKeyValues = { ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("EntityID")], ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("EntityGUID")] };
                    //object[] PrimaryKeyValues = { "EntityID=" + ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("EntityID")], "EntityGUID='" + ChangesDataTable.Rows[x].ItemArray[ChangesDataTable.Columns.IndexOf("EntityGUID")] + "'" };
                    ((DataRow)_DataTable.Rows.Find(PrimaryKeyValues)).AcceptChanges();
                }
                //Form1_TimeStampChanged(this., null);
            }
        }
        void settimea()
        {
            this.Text = DateTime.Now.ToString();
        }
        private void TickTock()
        {
            while (this.listening)
            {
                Thread.Sleep(1000);
                Invoke(new settime(settimea));

                //EventHandler Form1_MyEvent = MyEvent;
                //if (Form1_MyEvent != null)
                //{
                //    Form1_MyEvent(null, null);
                //}
                
            }
        }

        private void StartStopTimeButton_Click(object sender, EventArgs e)
        {
            this.listening = !this.listening;
            if (this.listening)
            {
                StartUp();
            }
            else
            {
                if (this.ClockThread.ThreadState == ThreadState.Running)
                {
                    this.ClockThread.Interrupt();
                    this.ClockThread.Abort();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CheckDataVersion()
        {
            for (; ; )
            {
                GetConnection();
                CompareVersion();

                Thread.Sleep(5000);
            }
        }

        private void CompareVersion()
        {
            byte[] temp_timestamp;

            using(SqlCommand sqlCommand = new SqlCommand("Select max([TimeStamp]) TimeStamp_Max from [dbo].[Entity]",sqlConnection))
            {
                sqlCommand.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new System.Data.DataTable();
                da.Fill(dataTable);

                temp_timestamp = (byte[])dataTable.Rows[0].ItemArray[0];

                if (!isEqual(temp_timestamp,this.timestamp))
                {
                    Invoke(TimeStampChanged, new object[] { this, new TimeStampChangedEventArgs(temp_timestamp) });
                }

            }
        }

        private bool isEqual(byte[] left, byte[] right)
        {
            bool isEqual = true;
            if (left != null && right != null)
            {

                if (left.Length == right.Length)
                {
                    for (int x = 0; x < left.Length; x++)
                    {
                        if (left[x] != right[x])
                        {
                            isEqual = false;
                            x = left.Length;
                        }
                    }
                }
                else
                {
                    isEqual = false;
                }
            }
            else
            {
                isEqual = false;
            }
            return (isEqual);
        }

        private void GetConnection()
        {
            if(this.sqlConnection==null)
            {
                this.sqlConnection = new SqlConnection(@"Data Source=RTHOR-PC\SQL2008R2;Initial Catalog=SandBox;Integrated Security=True");
            }
        }
    }
}
