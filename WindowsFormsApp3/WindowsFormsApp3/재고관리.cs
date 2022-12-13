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

namespace WindowsFormsApp3
{
    public partial class 재고관리 : MetroFramework.Forms.MetroForm
    {
        public 재고관리()
        {
            InitializeComponent();
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id = hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            //변경해야함
            string commandString = "select P.ID, P.PName, R.ID, R.SNO,R.SName from Phone P, Register R where P.ID=R.ID ";
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = myCommand;
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "RelTable"); //
            DataTable RelTable = DS.Tables["RelTable"];
            DataRowCollection rows = RelTable.Rows;
            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < RelTable.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView2.Items.Add(item);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

