using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp3
{
    public partial class 상품관리_검색 : MetroFramework.Forms.MetroForm
    {

        public 상품관리_검색()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand("select * from Product where name =:name ", conn);
            DBAdapter.SelectCommand.Parameters.Add("name", OracleDbType.Varchar2, 20);
            DBAdapter.SelectCommand.Parameters["name"].Value = Searchtxt.Text.Trim();
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "Product");
            DataTable phoneTable = DS.Tables["Product"];
            SearchDBGrid.DataSource = phoneTable;
        }
    }
}
