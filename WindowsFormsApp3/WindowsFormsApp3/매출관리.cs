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
    public partial class 매출관리 : MetroFramework.Forms.MetroForm
    {
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;
        DataTable salesTable; // DataTable 객체입니다. 
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 

        public 매출관리()
        {
            InitializeComponent();
            DB_Open();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) //날자 클릭시
        {
            DateTime date = monthCalendar1.SelectionStart; // data에 달력 시작 날짜를 넣음
            string day = date.ToShortDateString().Replace("-", ""); // 달력 시작 날짜를 가져오는데 날짜 형식에서 "-"부분을 ""로 바꿔주는거.
            selDate.Text = day;

            DS.Clear();
            DBAdapter.Fill(DS, "sales");
            salesTable = DS.Tables["sales"];
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = salesTable.Columns["day"];
            salesTable.PrimaryKey = PrimaryKey;
            DataRow currRow = salesTable.Rows.Find(SelectedRowIndex);
        }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from sales";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "sales");
                dbgrid.DataSource = DS.Tables["sales"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void dbgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "sales");
                DataTable salesTable = DS.Tables["sales"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다.
                    return;
                }
                else if(e.RowIndex > salesTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = salesTable.Rows[e.RowIndex];
                selDate.Text = currRow["day"].ToString();
                totalpricetxtbox.Text = currRow["totalsale"].ToString();
                SelectedRowIndex = Convert.ToInt32(currRow["day"]);
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void updatesalesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "sales");
                salesTable = DS.Tables["sales"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = salesTable.Columns["day"];
                salesTable.PrimaryKey = PrimaryKey;
                DataRow currRow = salesTable.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                currRow["day"] = selDate.Text;
                currRow["totalsale"] = totalpricetxtbox.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    DBAdapter.Update(UpdatedSet, "sales");
                    DS.AcceptChanges();
                }
                dbgrid.DataSource = DS.Tables["sales"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
