using System;
using System.Data;
using System.Windows.Forms;

namespace _18
{
    public partial class BDQueryResult : Form
    {
        DataBaseHandler db;
        DataTable dt;
        public BDQueryResult(DataTable dt, object db)
        {
            InitializeComponent();
            this.dt = dt;
            this.db = db as DataBaseHandler;
        }

        public void ExecuteSpetific(string city, string table)
        {
            db.Select($"SELECT * FROM {table} WHERE City = '{city}' ORDER BY Id");
            dt = db.GetTable();
            resultGrid.DataSource = dt;
        }

        public void ExecuteLocate(string table, string KeyField, string KeyValue)
        {
            db.Select($"SELECT * FROM {table} WHERE {KeyField} LIKE '%{KeyValue}%'");
            dt = db.GetTable();
            resultGrid.DataSource = dt;
        }

        //public void ExecuteLockup(string table, string KeyField, string KeyValue)
        //{
        //    db.Select($"SELECT * FROM {table} WHERE EXISTS(" +
        //        $"SELECT * FROM {table} WHERE {KeyValue} = )");
        //    dt = db.GetTable();
        //    resultGrid.DataSource = dt;
        //}
    }
}
