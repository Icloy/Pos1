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
    public partial class 재고관리_수정 : MetroFramework.Forms.MetroForm
    {
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;
        // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다. 
        DataTable StockTable; // DataTable 객체입니다. 


        private void ClearTextBoxes()
        {
            txtcode.Clear();
            txtcount.Clear();
            txtsttext.Clear();
        }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from Stock";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        public 재고관리_수정()
        {
            InitializeComponent();
            DB_Open();//*
        }

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();//***
                DBAdapter.Fill(DS, "Stock");
                DBGrid.DataSource = DS.Tables["Stock"].DefaultView;
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

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();//****
                DBAdapter.Fill(DS, "Stock");//****
                DataTable ProductTable = DS.Tables["Stock"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다. return;
                }
                else if (e.RowIndex > ProductTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = ProductTable.Rows[e.RowIndex];
                txtcode.Text = currRow["Stock_code"].ToString();
                txtcount.Text = currRow["Stock_count"].ToString();
                txtsttext.Text = currRow["Stock_text"].ToString();
                SelectedRowIndex = Convert.ToInt32(currRow["Stock_code"]);

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

        private void AppendBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "Stock");
                StockTable = DS.Tables["Stock"];//****
                DataRow newRow = StockTable.NewRow();
                newRow["Stock_code"] = Convert.ToInt32(txtcode.Text);
                newRow["Stock_count"] = Convert.ToInt32(txtcount.Text);
                newRow["Stock_text"] = txtsttext.Text;
                StockTable.Rows.Add(newRow);
                DBAdapter.Update(DS, "Stock");
                DS.AcceptChanges();//***
                ClearTextBoxes(); //***
                DBGrid.DataSource = DS.Tables["Stock"].DefaultView;
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

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "Stock");
                StockTable = DS.Tables["Stock"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = StockTable.Columns["Stock_code"];
                StockTable.PrimaryKey = PrimaryKey;
                DataRow currRow = StockTable.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "Stock");
                DBGrid.DataSource = DS.Tables["Stock"].DefaultView;
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "Stock");
                StockTable = DS.Tables["Stock"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = StockTable.Columns["Stock_code"];
                StockTable.PrimaryKey = PrimaryKey;
                DataRow currRow = StockTable.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                currRow["Stock_code"] = txtcode.Text;
                currRow["Stock_count"] = txtcount.Text;
                currRow["Stock_text"] = txtsttext.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    DBAdapter.Update(UpdatedSet, "Stock");
                    DS.AcceptChanges();
                }
                DBGrid.DataSource = DS.Tables["Stock"].DefaultView;
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


