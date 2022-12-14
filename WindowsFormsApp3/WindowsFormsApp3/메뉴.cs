using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace WindowsFormsApp3
{
    public partial class 메뉴 : MetroFramework.Forms.MetroForm
    {


        ORDER ord = new ORDER();
        메인메뉴 abc = new 메인메뉴();


        int cash = 0;
        int stockErrorcount = 0;

        public void startorder()
        {
            string strConn = "User Id=hong1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from Product where name = 주류1";
            cmd.Parameters.Add(new OracleParameter("@name", "주류1"));

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String s = reader["wsprice"] as String;
                metroTextBox1.Text = s;
            }
            reader.Close();
        }



        public 메뉴()
        {
            InitializeComponent();
        }

        메인메뉴 frm1;
        public 메인메뉴 fm;

        public 메뉴(메인메뉴 _form)
        {
            InitializeComponent();
            frm1 = _form;
        }


        private void metroButton4_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("취소할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listView1.Items.Clear();

                textBox_sumcash.Text = "0";

                cash = 0;
                ord.chamcount = ord.freshcount = ord.startcount = ord.jinrocount = ord.casscount = ord.hitecount = ord.terracount = ord.chunghacount = ord.colacount = ord.cidercount = ord.fantacount = ord.meet1count = ord.meet2count = ord.meet3count = ord.meet4count = ord.meet5count = ord.meet6count = ord.meet7count = ord.meet8count = ord.meet9count = 1;
                ord.chamsum = ord.freshsum = ord.startsum = ord.jinrosum = ord.casssum = ord.hitesum = ord.terrasum = ord.chunghasum = ord.colasum = ord.cidersum = ord.fantasum = ord.meet1sum = ord.meet2sum = ord.meet3sum = ord.meet4sum = ord.meet5sum = ord.meet6sum = ord.meet7sum = ord.meet8sum = ord.meet9sum = 0;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet5count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton5.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton5.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet5count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet5Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet5count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton5.Text, Convert.ToString(ord.meet5count), Convert.ToString(ord.Meet5Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet5count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet6count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton6.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton6.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet6count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet6Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet6count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton6.Text, Convert.ToString(ord.meet6count), Convert.ToString(ord.Meet6Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet6count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.Items)
            {
                frm1.listView1.Items.Add((ListViewItem)item.Clone());
            }





            this.Close();

        }




        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {


            int count = listView1.Items.Count; // 리스트뷰 항목 수 반


            if (ord.meet1count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton1.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거


                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거


                        listView1.FocusedItem.SubItems[0].Text = metroButton1.Text; // 포커스된 부분에 내용 덮어쓰는거

                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet1count); // 포커스된 부분에 내용 덮어쓰는거

                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet1Sum()); // 포커스된 부분에 내용 덮어쓰는거

                        ord.meet1count++;
                        listView1.Items[i].Selected = false;


                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton1.Text, Convert.ToString(ord.meet1count), Convert.ToString(ord.Meet1Sum()) };
                var lvt = new ListViewItem(meat);
                var lvt2 = new ListViewItem(meat);

                this.listView1.Items.Add(lvt);


                listView1.Focus();
                ord.meet1count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_cham_Click(object sender, EventArgs e)
        {
            startorder();
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.chamcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cham.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cham.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.chamcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.ChamSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.chamcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cham.Text, Convert.ToString(ord.chamcount), Convert.ToString(ord.ChamSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.chamcount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_fresh_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.freshcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_fresh.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_fresh.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.freshcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.FreshSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.freshcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_fresh.Text, Convert.ToString(ord.freshcount), Convert.ToString(ord.FreshSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.freshcount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.startcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_start.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_start.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.startcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.StartSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.startcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_start.Text, Convert.ToString(ord.startcount), Convert.ToString(ord.StartSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.startcount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_jinro_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.jinrocount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_jinro.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_jinro.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.jinrocount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.JinroSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.jinrocount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_jinro.Text, Convert.ToString(ord.jinrocount), Convert.ToString(ord.JinroSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.jinrocount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_cass_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.casscount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cass.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cass.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.casscount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.CassSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.casscount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cass.Text, Convert.ToString(ord.casscount), Convert.ToString(ord.CassSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.casscount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_hite_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.hitecount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_hite.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_hite.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.hitecount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.HiteSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.hitecount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_hite.Text, Convert.ToString(ord.hitecount), Convert.ToString(ord.HiteSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.hitecount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_terra_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.terracount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_terra.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_terra.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.terracount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.TerraSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.terracount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_terra.Text, Convert.ToString(ord.terracount), Convert.ToString(ord.TerraSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.terracount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_chungha_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.chunghacount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_chungha.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_chungha.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.chunghacount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.ChunghaSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.chunghacount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_chungha.Text, Convert.ToString(ord.chunghacount), Convert.ToString(ord.ChunghaSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.chunghacount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_cola_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.colacount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cola.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cola.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.colacount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.ColaSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.colacount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cola.Text, Convert.ToString(ord.colacount), Convert.ToString(ord.ColaSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.colacount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_cider_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.cidercount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cider.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cider.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.cidercount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.CiderSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.cidercount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cider.Text, Convert.ToString(ord.cidercount), Convert.ToString(ord.CiderSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.cidercount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_fanta_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.fantacount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_fanta.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_fanta.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.fantacount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.FantaSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.fantacount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_fanta.Text, Convert.ToString(ord.fantacount), Convert.ToString(ord.FantaSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.fantacount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반


            if (ord.meet2count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton2.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거


                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거


                        listView1.FocusedItem.SubItems[0].Text = metroButton2.Text; // 포커스된 부분에 내용 덮어쓰는거

                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet2count); // 포커스된 부분에 내용 덮어쓰는거

                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet2Sum()); // 포커스된 부분에 내용 덮어쓰는거

                        ord.meet2count++;
                        listView1.Items[i].Selected = false;


                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton2.Text, Convert.ToString(ord.meet2count), Convert.ToString(ord.Meet2Sum()) };
                var lvt = new ListViewItem(meat);
                var lvt2 = new ListViewItem(meat);

                this.listView1.Items.Add(lvt);


                listView1.Focus();
                ord.meet2count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet3count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton3.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton3.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet3count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet3Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet3count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton3.Text, Convert.ToString(ord.meet3count), Convert.ToString(ord.Meet3Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet3count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet4count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton4.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton4.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet4count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet4Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet4count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton4.Text, Convert.ToString(ord.meet4count), Convert.ToString(ord.Meet4Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet4count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet5count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton5.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton5.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet5count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet5Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet5count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton5.Text, Convert.ToString(ord.meet5count), Convert.ToString(ord.Meet5Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet5count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet6count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton6.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton6.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet6count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet6Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet6count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton6.Text, Convert.ToString(ord.meet6count), Convert.ToString(ord.Meet6Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet6count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void metroButton7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("현금결제 하시겠습니까?", "현금 결제", MessageBoxButtons.YesNo);
                listView1.Items.Clear();

                textBox_sumcash.Text = "0";

                cash = 0;
                ord.chamcount = ord.freshcount = ord.startcount = ord.jinrocount = ord.casscount = ord.hitecount = ord.terracount = ord.chunghacount = ord.colacount = ord.cidercount = ord.fantacount = ord.meet1count = ord.meet2count = ord.meet3count = ord.meet4count = ord.meet5count = ord.meet6count = ord.meet7count = ord.meet8count = ord.meet9count = 1;
                ord.chamsum = ord.freshsum = ord.startsum = ord.jinrosum = ord.casssum = ord.hitesum = ord.terrasum = ord.chunghasum = ord.colasum = ord.cidersum = ord.fantasum = ord.meet1sum = ord.meet2sum = ord.meet3sum = ord.meet4sum = ord.meet5sum = ord.meet6sum = ord.meet7sum = ord.meet8sum = ord.meet9sum = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("카드결제 하시겠습니까?", "카드 결제", MessageBoxButtons.YesNo);
                listView1.Items.Clear();

                textBox_sumcash.Text = "0";

                cash = 0;
                ord.chamcount = ord.freshcount = ord.startcount = ord.jinrocount = ord.casscount = ord.hitecount = ord.terracount = ord.chunghacount = ord.colacount = ord.cidercount = ord.fantacount = ord.meet1count = ord.meet2count = ord.meet3count = ord.meet4count = ord.meet5count = ord.meet6count = ord.meet7count = ord.meet8count = ord.meet9count = 1;
                ord.chamsum = ord.freshsum = ord.startsum = ord.jinrosum = ord.casssum = ord.hitesum = ord.terrasum = ord.chunghasum = ord.colasum = ord.cidersum = ord.fantasum = ord.meet1sum = ord.meet2sum = ord.meet3sum = ord.meet4sum = ord.meet5sum = ord.meet6sum = ord.meet7sum = ord.meet8sum = ord.meet9sum = 0;
            }
        }


        private void metroButton3_Click_1(object sender, EventArgs e)
        {

            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet3count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton3.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton3.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet3count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet3Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet3count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton3.Text, Convert.ToString(ord.meet3count), Convert.ToString(ord.Meet3Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet3count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void d(object sender, EventArgs e)
        {

        }

        private void metroButton4_1_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.meet4count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == metroButton4.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = metroButton4.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.meet4count); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.Meet4Sum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.meet4count++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.metroButton4.Text, Convert.ToString(ord.meet4count), Convert.ToString(ord.Meet4Sum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.meet4count++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button00_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("결제할 메뉴가 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("카드결제 하시겠습니까?", "카드 결제", MessageBoxButtons.YesNo);
                listView1.Items.Clear();

                textBox_sumcash.Text = "0";

                cash = 0;
                ord.chamcount = ord.freshcount = ord.startcount = ord.jinrocount = ord.casscount = ord.hitecount = ord.terracount = ord.chunghacount = ord.colacount = ord.cidercount = ord.fantacount = ord.meet1count = ord.meet2count = ord.meet3count = ord.meet4count = ord.meet5count = ord.meet6count = ord.meet7count = ord.meet8count = ord.meet9count = 1;
                ord.chamsum = ord.freshsum = ord.startsum = ord.jinrosum = ord.casssum = ord.hitesum = ord.terrasum = ord.chunghasum = ord.colasum = ord.cidersum = ord.fantasum = ord.meet1sum = ord.meet2sum = ord.meet3sum = ord.meet4sum = ord.meet5sum = ord.meet6sum = ord.meet7sum = ord.meet8sum = ord.meet9sum = 0;
            }
        }
    }
}
