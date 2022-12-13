
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.totalpricetxtbox = new MetroFramework.Controls.MetroTextBox();
            this.selDate = new MetroFramework.Controls.MetroLabel();
            this.updatesalesBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dbgrid = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(43, 150);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(170, 40);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel1.Location = new System.Drawing.Point(43, 163);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(189, 48);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "매출 금액 : ";
            this.htmlLabel1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.htmlLabel2);
            this.groupBox1.Controls.Add(this.totalpricetxtbox);
            this.groupBox1.Controls.Add(this.updatesalesBtn);
            this.groupBox1.Controls.Add(this.selDate);
            this.groupBox1.Controls.Add(this.htmlLabel1);
            this.groupBox1.Location = new System.Drawing.Point(374, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(809, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매출 관리";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(170, 40);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel2.Location = new System.Drawing.Point(43, 68);
            this.htmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(189, 48);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "선택 날짜 : ";
            this.htmlLabel2.UseWaitCursor = true;
            // 
            // totalpricetxtbox
            // 
            // 
            // 
            // 
            this.totalpricetxtbox.CustomButton.Image = null;
            this.totalpricetxtbox.CustomButton.Location = new System.Drawing.Point(791, 3);
            this.totalpricetxtbox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalpricetxtbox.CustomButton.Name = "";
            this.totalpricetxtbox.CustomButton.Size = new System.Drawing.Size(41, 44);
            this.totalpricetxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalpricetxtbox.CustomButton.TabIndex = 1;
            this.totalpricetxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalpricetxtbox.CustomButton.UseSelectable = true;
            this.totalpricetxtbox.CustomButton.Visible = false;
            this.totalpricetxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.totalpricetxtbox.Lines = new string[] {
        "*"};
            this.totalpricetxtbox.Location = new System.Drawing.Point(208, 167);
            this.totalpricetxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalpricetxtbox.MaxLength = 32767;
            this.totalpricetxtbox.Name = "totalpricetxtbox";
            this.totalpricetxtbox.PasswordChar = '\0';
            this.totalpricetxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalpricetxtbox.SelectedText = "";
            this.totalpricetxtbox.SelectionLength = 0;
            this.totalpricetxtbox.SelectionStart = 0;
            this.totalpricetxtbox.ShortcutsEnabled = true;
            this.totalpricetxtbox.Size = new System.Drawing.Size(586, 34);
            this.totalpricetxtbox.TabIndex = 11;
            this.totalpricetxtbox.Text = "*";
            this.totalpricetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalpricetxtbox.UseSelectable = true;
            this.totalpricetxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalpricetxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // selDate
            // 
            this.selDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.selDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.selDate.Location = new System.Drawing.Point(208, 68);
            this.selDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selDate.Name = "selDate";
            this.selDate.Size = new System.Drawing.Size(593, 46);
            this.selDate.Style = MetroFramework.MetroColorStyle.Black;
            this.selDate.TabIndex = 7;
            this.selDate.Text = "*";
            this.selDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatesalesBtn
            // 
            this.updatesalesBtn.Location = new System.Drawing.Point(208, 261);
            this.updatesalesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updatesalesBtn.Name = "updatesalesBtn";
            this.updatesalesBtn.Size = new System.Drawing.Size(140, 63);
            this.updatesalesBtn.TabIndex = 10;
            this.updatesalesBtn.Text = "매출 수정";
            this.updatesalesBtn.UseSelectable = true;
            this.updatesalesBtn.Click += new System.EventHandler(this.updatesalesBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(654, 261);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 63);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "DB 열기";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dbgrid
            // 
            this.dbgrid.AllowUserToResizeRows = false;
            this.dbgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dbgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dbgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.dbgrid.EnableHeadersVisualStyles = false;
            this.dbgrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dbgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dbgrid.Location = new System.Drawing.Point(43, 453);
            this.dbgrid.Name = "dbgrid";
            this.dbgrid.ReadOnly = true;
            this.dbgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dbgrid.RowHeadersWidth = 62;
            this.dbgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbgrid.RowTemplate.Height = 30;
            this.dbgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgrid.Size = new System.Drawing.Size(1140, 502);
            this.dbgrid.TabIndex = 7;
            this.dbgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrid_CellClick);
            // 
            // 매출관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 988);
            this.Controls.Add(this.dbgrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "매출관리";
            this.Padding = new System.Windows.Forms.Padding(29, 90, 29, 30);
            this.Text = "매출관리";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel selDate;
        private MetroFramework.Controls.MetroTextBox totalpricetxtbox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton updatesalesBtn;
        private MetroFramework.Controls.MetroGrid dbgrid;
    }
}