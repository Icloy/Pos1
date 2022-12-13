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
    public partial class 상품관리 : MetroFramework.Forms.MetroForm
    {
        private int SelectedRowIndex; //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. 
        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;
                                      // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다. 
        DataTable ProductTable; // DataTable 객체입니다. 
        private int SelectedKeyValue;

        private void ClearTextBoxes()
        {
            txtcode.Clear();
            txtname.Clear();
            txtpval.Clear();
            txtsale.Clear();
            txtwsprice.Clear();
        }

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

        public 상품관리()
        {
            InitializeComponent();
            DB_Open();//*
        }
        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();//***
                DBAdapter.Fill(DS, "Product");
                DBGrid.DataSource = DS.Tables["Product"].DefaultView;
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
        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "Product");
                ProductTable = DS.Tables["Product"];//****
                DataRow newRow = ProductTable.NewRow();
                newRow["code"] = Convert.ToInt32(txtcode.Text);
                newRow["name"] = txtname.Text;
                newRow["pval"] = txtpval.Text;
                newRow["sale"] = Convert.ToInt32(txtsale.Text);
                newRow["wsprice"] = Convert.ToInt32(txtwsprice.Text);
                ProductTable.Rows.Add(newRow);
                DBAdapter.Update(DS, "Product");
                DS.AcceptChanges();//***
                ClearTextBoxes(); //***
                DBGrid.DataSource = DS.Tables["Product"].DefaultView;
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
                DBAdapter.Fill(DS, "Product");//****
                DataTable ProductTable = DS.Tables["Product"];
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
                txtcode.Text = currRow["code"].ToString();
                txtname.Text = currRow["name"].ToString();
                txtpval.Text = currRow["pval"].ToString();
                txtsale.Text = currRow["sale"].ToString();
                txtwsprice.Text = currRow["wsprice"].ToString();
                SelectedRowIndex = Convert.ToInt32(currRow["code"]);
                
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
                DBAdapter.Fill(DS, "Product");
                ProductTable = DS.Tables["Product"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = ProductTable.Columns["code"];
                ProductTable.PrimaryKey = PrimaryKey;
                DataRow currRow = ProductTable.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                currRow["code"] = txtcode.Text;
                currRow["name"] = txtname.Text;
                currRow["pval"] = txtpval.Text;
                currRow["sale"] = txtsale.Text;
                currRow["wsprice"] = txtwsprice.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    DBAdapter.Update(UpdatedSet, "Product");
                    DS.AcceptChanges();
                }
                DBGrid.DataSource = DS.Tables["Product"].DefaultView;
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
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "Product");
                ProductTable = DS.Tables["Product"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = ProductTable.Columns["code"];
                ProductTable.PrimaryKey = PrimaryKey;
                DataRow currRow = ProductTable.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                DBAdapter.Update(DS.GetChanges(DataRowState.Deleted),
               "Product");
                DBGrid.DataSource = DS.Tables["Product"].DefaultView;
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            상품관리_검색 Searchform = new 상품관리_검색();
            Searchform.Owner = this;

            Searchform.SearchDBGrid.DataSource = DS.Tables["Product"].DefaultView;

            Searchform.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtwsprice_Click(object sender, EventArgs e)
        {

        }

    

        private void textsale_Click(object sender, EventArgs e)
        {

        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
