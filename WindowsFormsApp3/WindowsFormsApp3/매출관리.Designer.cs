
namespace WindowsFormsApp3
{
    partial class 매출관리
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.selDate = new MetroFramework.Controls.MetroLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatesalesBtn = new MetroFramework.Controls.MetroButton();
            this.totalpricetxtbox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 100);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(121, 30);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel1.Location = new System.Drawing.Point(34, 65);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(132, 32);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "매출 금액 : ";
            this.htmlLabel1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.htmlLabel2);
            this.groupBox1.Controls.Add(this.totalpricetxtbox);
            this.groupBox1.Controls.Add(this.updatesalesBtn);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.selDate);
            this.groupBox1.Controls.Add(this.htmlLabel3);
            this.groupBox1.Controls.Add(this.htmlLabel1);
            this.groupBox1.Location = new System.Drawing.Point(262, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매출 관리";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(150, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(411, 32);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "*";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selDate
            // 
            this.selDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.selDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.selDate.Location = new System.Drawing.Point(150, 23);
            this.selDate.Name = "selDate";
            this.selDate.Size = new System.Drawing.Size(415, 31);
            this.selDate.Style = MetroFramework.MetroColorStyle.Black;
            this.selDate.TabIndex = 7;
            this.selDate.Text = "*";
            this.selDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(121, 30);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel3.Location = new System.Drawing.Point(34, 120);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(132, 32);
            this.htmlLabel3.TabIndex = 5;
            this.htmlLabel3.Text = "매출 금액 : ";
            this.htmlLabel3.UseWaitCursor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.day,
            this.sales});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 297);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 348);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // day
            // 
            this.day.Text = "날짜";
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day.Width = 399;
            // 
            // sales
            // 
            this.sales.Text = "매출";
            this.sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sales.Width = 395;
            // 
            // updatesalesBtn
            // 
            this.updatesalesBtn.Location = new System.Drawing.Point(462, 173);
            this.updatesalesBtn.Name = "updatesalesBtn";
            this.updatesalesBtn.Size = new System.Drawing.Size(98, 42);
            this.updatesalesBtn.TabIndex = 10;
            this.updatesalesBtn.Text = "매출 수정";
            this.updatesalesBtn.UseSelectable = true;
            // 
            // totalpricetxtbox
            // 
            // 
            // 
            // 
            this.totalpricetxtbox.CustomButton.Image = null;
            this.totalpricetxtbox.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.totalpricetxtbox.CustomButton.Name = "";
            this.totalpricetxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalpricetxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalpricetxtbox.CustomButton.TabIndex = 1;
            this.totalpricetxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalpricetxtbox.CustomButton.UseSelectable = true;
            this.totalpricetxtbox.CustomButton.Visible = false;
            this.totalpricetxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.totalpricetxtbox.Lines = new string[] {
        "*"};
            this.totalpricetxtbox.Location = new System.Drawing.Point(150, 68);
            this.totalpricetxtbox.MaxLength = 32767;
            this.totalpricetxtbox.Name = "totalpricetxtbox";
            this.totalpricetxtbox.PasswordChar = '\0';
            this.totalpricetxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalpricetxtbox.SelectedText = "";
            this.totalpricetxtbox.SelectionLength = 0;
            this.totalpricetxtbox.SelectionStart = 0;
            this.totalpricetxtbox.ShortcutsEnabled = true;
            this.totalpricetxtbox.Size = new System.Drawing.Size(410, 23);
            this.totalpricetxtbox.TabIndex = 11;
            this.totalpricetxtbox.Text = "*";
            this.totalpricetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalpricetxtbox.UseSelectable = true;
            this.totalpricetxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalpricetxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(121, 30);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel2.Location = new System.Drawing.Point(34, 23);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(132, 32);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "선택 날짜 : ";
            this.htmlLabel2.UseWaitCursor = true;
            // 
            // 매출관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 659);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "매출관리";
            this.Text = "매출관리";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroLabel selDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader day;
        private System.Windows.Forms.ColumnHeader sales;
        private MetroFramework.Controls.MetroTextBox totalpricetxtbox;
        private MetroFramework.Controls.MetroButton updatesalesBtn;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
    }
}