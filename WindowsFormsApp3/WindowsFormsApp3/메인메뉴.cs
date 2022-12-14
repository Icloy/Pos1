using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class 메인메뉴 : MetroFramework.Forms.MetroForm
    {

        
        public 메인메뉴()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //상품 관리 버튼
            상품관리 newform2 = new 상품관리();
            newform2.ShowDialog();

            //상품 정보 넣는 창에서는 이거 쓰지 말고 따른 방식으로 꺼졌따켜졌다 쓰기~
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //재고 관리 버튼
            재고관리 stockform = new 재고관리();
            stockform.ShowDialog();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            //매출 관리 버튼
            매출관리 salesform = new 매출관리();
            salesform.ShowDialog();
        }

       

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView1.Items.Clear();
            메뉴 Menuform1 = new 메뉴(this);
            
            
            Menuform1.ShowDialog();
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView2.Items.Clear();
            메뉴 Menuform1 = new 메뉴(this);


            Menuform1.ShowDialog();
        }

        private void metroGrid7_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView1.Items.Clear();
            메뉴 Menuform1 = new 메뉴(this);


            Menuform1.ShowDialog();
        }
    }
}
