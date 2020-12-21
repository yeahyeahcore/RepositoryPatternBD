using System.Data;
using System.Windows.Forms;

namespace _18
{
    public partial class SMBDQueryResult : Form
    {
        DataBaseHandler db;
        DataTable dt;
        string city;
        public SMBDQueryResult(DataTable dt, object db, string city)
        {
            InitializeComponent();
            this.dt = dt;
            this.city = city;
            this.db = db as DataBaseHandler;

            ExecuteQuery();
        }

        void ExecuteQuery()
        {
            db.Select($"SELECT * FROM SportsMan WHERE City = '{city}' ORDER BY Id");
            dt = db.GetTable();
            resultGrid.DataSource = dt;
        }
    }
}
