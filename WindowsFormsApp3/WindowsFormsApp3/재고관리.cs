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
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;
        // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다. 
        DataTable StockTable; // DataTable 객체입니다. 

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from Product";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public 재고관리()
        {
            InitializeComponent();
            DB_Open();//*
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "User Id = hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            //변경해야함
            string commandString = "select P.code, P.name, S.Stock_count, S.Stock_text from Product P, Stock S where P.code=S.Stock_code";
            listView2.Items.Clear();
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            myConnection.Open(); //
            OracleDataReader MR;
            MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                ListViewItem item = new ListViewItem(MR[0].ToString());
                item.SubItems.Add(MR[1].ToString());
                item.SubItems.Add(MR[2].ToString());
                item.SubItems.Add(MR[3].ToString());
                listView2.Items.Add(item);
            }
            MR.Close();
            myConnection.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            재고관리_검색 Searchform = new 재고관리_검색();
            Searchform.Owner = this;


            Searchform.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            재고관리_수정  Searchform = new 재고관리_수정();
            Searchform.Owner = this;

            Searchform.ShowDialog();
        }
    }
    }

