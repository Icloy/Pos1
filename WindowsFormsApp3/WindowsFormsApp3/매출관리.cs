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
    public partial class 매출관리 : MetroFramework.Forms.MetroForm
    {
        public 매출관리()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionStart; // data에 달력 시작 날짜를 넣음
            string day = date.ToShortDateString().Replace("-", ""); // 달력 시작 날짜를 가져오는데 날짜 형식에서 "-"부분을 ""로 바꿔주는거.
            selDate.Text = day;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
