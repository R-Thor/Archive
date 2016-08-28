using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace ExecuteProcAtSec
{
    internal class DatabaseLoad
    {
        internal DatabaseLoad(int LoadThreads, int second)
        {
            //for (int x = 0; x < LoadThreads; x++)
            //{

                //ThreadPool.QueueUserWorkItem(new WaitCallback(ExecuteProc));
            //}
            ExecuteProc(null);
        }
        
        internal void ExecuteProc(object o)
        {
            Guid ID = Guid.NewGuid();
            Console.WriteLine("Started: " + ID.ToString());
            for (; ; )
            {
                while (DateTime.Now.Second % 15 != 0 && DateTime.Now.Millisecond!= 0) ;
                using (DataTable dt = new DataTable())
                {
                    using (SqlConnection sqlConnection = new SqlConnection())
                    {
                        sqlConnection.ConnectionString = @"Data Source=RTHOR-PC\SQL2008R2;Database=SandBox;Integrated Security=True";

                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.CommandText = "[dbo].[Entities_GetTop300ByData]";
                            sqlCommand.CommandTimeout = 999;
                            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                            sqlCommand.Connection = sqlConnection;
                            dt.TableName = sqlCommand.CommandText;
                            using (SqlDataAdapter sda = new SqlDataAdapter(sqlCommand))
                            {
                                DateTime StartDateTime = DateTime.Now;
                                sda.Fill(dt);
                                DateTime EndDateTime = DateTime.Now;
                                Console.WriteLine(StartDateTime.ToLongTimeString() + "\t" + StartDateTime.Millisecond.ToString() + "\t" + EndDateTime.ToLongTimeString() + "\t" + (EndDateTime - StartDateTime).TotalMilliseconds.ToString() + "\t" + ID.ToString());
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
