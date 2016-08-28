using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BruteCash.Model
{
    public partial class MetaData
    {
        public class Column
        {
            public string Name { get; set; }
            public Type Type { get; set; }
            public bool IsAdHOC { get; set; }
            public Column()
            {

            }
            public Column(string Name, Type Type)
            {
                this.Name = Name;
                this.Type = Type;
            }
        }
        public partial class Models
        {
            public class ModelTransaction
            {
                public static readonly string ModelName = "Transaction";
                public class Columns
                {
                    public static readonly Column transactionGUID = new Column("transactionGUID", typeof(Guid));
                    public static readonly Column entryDate = new Column("entryDate", typeof(DateTime));
                    public static readonly Column transactionDate = new Column("transactionDate", typeof(DateTime));
                    public static readonly Column effectiveDate = new Column("effectiveDate", typeof(DateTime));
                    public static readonly Column clearedDate = new Column("clearedDate", typeof(DateTime));
                    public static readonly Column accountCode = new Column("accountCode", typeof(string));
                    public static readonly Column paidOrReceived = new Column("paidOrReceived", typeof(string));
                    public static readonly Column amount = new Column("amount", typeof(decimal));
                    public static readonly Column memo = new Column("memo", typeof(string));
                    public static readonly Column paymentType = new Column("paymentType", typeof(string));
                    #region OldColumns
                    //public readonly const string transactionGUID = "transactionGUID";
                    //public readonly const string EntryDate       = "EntryDate";
                    //public readonly const string TransactionDate = "TransactionDate";
                    //public readonly const string EffectiveDate   = "EffectiveDate";
                    //public readonly const string AccountCode     = "AccountCode";
                    //public readonly const string Amount          = "Amount";
                    //public readonly const string PaidOrRecieved  = "PaidOrRecieved";
                    //public readonly const string Memo            = "Memo";
                    //public readonly const string PaymentType     = "PaymentType";
                    //public readonly const string ClearedDate     = "ClearedDate";
                    #endregion OldColumns
                }
            }
        }
    }
    public class Budget
    {
        public class BudgetItem
        {

        }
    }
    public class DataAdapterDataSet2XML
    {
        public DataSet testDataSet;

        public DataAdapterDataSet2XML()
        {
            testDataSet = new DataSet("testDataSet");
            DataTable transactionDataTable = new DataTable(MetaData.Models.ModelTransaction.ModelName);
            transactionDataTable.TableNewRow += new DataTableNewRowEventHandler(transactionDataTable_TableNewRow);
            transactionDataTable.RowChanged += new DataRowChangeEventHandler(transactionDataTable_RowChanged);
            //transactionDataTable.Columns.Add(new DataColumn("transactionID", typeof(int)) { AutoIncrement = true });
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.transactionGUID.Name,MetaData.Models.ModelTransaction.Columns.transactionGUID.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.entryDate.Name, MetaData.Models.ModelTransaction.Columns.entryDate.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.transactionDate.Name, MetaData.Models.ModelTransaction.Columns.transactionDate.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.effectiveDate.Name, MetaData.Models.ModelTransaction.Columns.effectiveDate.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.clearedDate.Name, MetaData.Models.ModelTransaction.Columns.clearedDate.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.accountCode.Name, MetaData.Models.ModelTransaction.Columns.accountCode.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.paidOrReceived.Name, MetaData.Models.ModelTransaction.Columns.paidOrReceived.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.amount.Name, MetaData.Models.ModelTransaction.Columns.amount.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.memo.Name, MetaData.Models.ModelTransaction.Columns.memo.Type));
            transactionDataTable.Columns.Add(new DataColumn(MetaData.Models.ModelTransaction.Columns.paymentType.Name, MetaData.Models.ModelTransaction.Columns.paymentType.Type));

            DataRow DR = transactionDataTable.NewRow();
            DR.ItemArray = new object[] { Guid.NewGuid(), DateTime.UtcNow, DateTime.UtcNow, DateTime.UtcNow, DateTime.UtcNow, "0001-0001", "Received", 2616.00, "Normal PayCheck 20140919; minus Transportation Costs", "Direct Deposit" };
            transactionDataTable.Rows.Add(DR);
            testDataSet.Tables.Add(transactionDataTable);
        }

        void transactionDataTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            //StoreTempChange
        }

        void transactionDataTable_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row["transactionGUID"] = Guid.NewGuid();
        }
    }
}
