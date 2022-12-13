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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            상품관리 newform2 = new 상품관리();
            newform2.ShowDialog();

            //상품 정보 넣는 창에서는 이거 쓰지 말고 따른 방식으로 꺼졌따켜졌다 쓰기~
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //새로고침 코드 여기에다가 넣깅~
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid2_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid3_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid4_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid5_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid6_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }

        private void metroGrid7_Click(object sender, EventArgs e)
        {
            메뉴 Menuform = new 메뉴();
            Menuform.ShowDialog();
        }
    }
}
