namespace WindowsFormsApp3
{
    partial class 상품관리
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
            this.DBGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtcode = new MetroFramework.Controls.MetroTextBox();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtwsprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtsale = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SearchBtn = new MetroFramework.Controls.MetroButton();
            this.UpdateBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.AppendBtn = new MetroFramework.Controls.MetroButton();
            this.DAOpenBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtpval = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.AllowUserToResizeRows = false;
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DBGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DBGrid.EnableHeadersVisualStyles = false;
            this.DBGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DBGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBGrid.Location = new System.Drawing.Point(23, 63);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBGrid.Size = new System.Drawing.Size(954, 475);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 595);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "상품코드";
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.CustomButton.Image = null;
            this.txtcode.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtcode.CustomButton.Name = "";
            this.txtcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcode.CustomButton.TabIndex = 1;
            this.txtcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcode.CustomButton.UseSelectable = true;
            this.txtcode.CustomButton.Visible = false;
            this.txtcode.Lines = new string[0];
            this.txtcode.Location = new System.Drawing.Point(121, 595);
            this.txtcode.MaxLength = 32767;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcode.SelectedText = "";
            this.txtcode.SelectionLength = 0;
            this.txtcode.SelectionStart = 0;
            this.txtcode.ShortcutsEnabled = true;
            this.txtcode.Size = new System.Drawing.Size(75, 23);
            this.txtcode.TabIndex = 1;
            this.txtcode.UseSelectable = true;
            this.txtcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(295, 595);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(75, 23);
            this.txtname.TabIndex = 3;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(244, 595);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "상품명";
            // 
            // txtwsprice
            // 
            // 
            // 
            // 
            this.txtwsprice.CustomButton.Image = null;
            this.txtwsprice.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtwsprice.CustomButton.Name = "";
            this.txtwsprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtwsprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwsprice.CustomButton.TabIndex = 1;
            this.txtwsprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwsprice.CustomButton.UseSelectable = true;
            this.txtwsprice.CustomButton.Visible = false;
            this.txtwsprice.Lines = new string[0];
            this.txtwsprice.Location = new System.Drawing.Point(877, 595);
            this.txtwsprice.MaxLength = 32767;
            this.txtwsprice.Name = "txtwsprice";
            this.txtwsprice.PasswordChar = '\0';
            this.txtwsprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtwsprice.SelectedText = "";
            this.txtwsprice.SelectionLength = 0;
            this.txtwsprice.SelectionStart = 0;
            this.txtwsprice.ShortcutsEnabled = true;
            this.txtwsprice.Size = new System.Drawing.Size(75, 23);
            this.txtwsprice.TabIndex = 5;
            this.txtwsprice.UseSelectable = true;
            this.txtwsprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtwsprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtwsprice.Click += new System.EventHandler(this.txtwsprice_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(806, 595);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "도매가";
            // 
            // txtsale
            // 
            // 
            // 
            // 
            this.txtsale.CustomButton.Image = null;
            this.txtsale.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtsale.CustomButton.Name = "";
            this.txtsale.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsale.CustomButton.TabIndex = 1;
            this.txtsale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsale.CustomButton.UseSelectable = true;
            this.txtsale.CustomButton.Visible = false;
            this.txtsale.Lines = new string[0];
            this.txtsale.Location = new System.Drawing.Point(683, 595);
            this.txtsale.MaxLength = 32767;
            this.txtsale.Name = "txtsale";
            this.txtsale.PasswordChar = '\0';
            this.txtsale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsale.SelectedText = "";
            this.txtsale.SelectionLength = 0;
            this.txtsale.SelectionStart = 0;
            this.txtsale.ShortcutsEnabled = true;
            this.txtsale.Size = new System.Drawing.Size(75, 23);
            this.txtsale.TabIndex = 7;
            this.txtsale.UseSelectable = true;
            this.txtsale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsale.Click += new System.EventHandler(this.textsale_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(622, 595);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "판매가";
            // 
            // SearchBtn
            // 
            this.SearchBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SearchBtn.Location = new System.Drawing.Point(490, 658);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(110, 60);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseSelectable = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateBtn.Location = new System.Drawing.Point(722, 658);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 60);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseSelectable = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DeleteBtn.Location = new System.Drawing.Point(838, 658);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 60);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.UseSelectable = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AppendBtn.Location = new System.Drawing.Point(606, 658);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(110, 60);
            this.AppendBtn.TabIndex = 11;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.UseSelectable = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(50, 691);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(92, 27);
            this.DAOpenBtn.TabIndex = 12;
            this.DAOpenBtn.Text = "새로고침";
            this.DAOpenBtn.UseSelectable = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(418, 595);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "상품분류";
            // 
            // txtpval
            // 
            // 
            // 
            // 
            this.txtpval.CustomButton.Image = null;
            this.txtpval.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtpval.CustomButton.Name = "";
            this.txtpval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpval.CustomButton.TabIndex = 1;
            this.txtpval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpval.CustomButton.UseSelectable = true;
            this.txtpval.CustomButton.Visible = false;
            this.txtpval.Lines = new string[0];
            this.txtpval.Location = new System.Drawing.Point(489, 595);
            this.txtpval.MaxLength = 32767;
            this.txtpval.Name = "txtpval";
            this.txtpval.PasswordChar = '\0';
            this.txtpval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpval.SelectedText = "";
            this.txtpval.SelectionLength = 0;
            this.txtpval.SelectionStart = 0;
            this.txtpval.ShortcutsEnabled = true;
            this.txtpval.Size = new System.Drawing.Size(75, 23);
            this.txtpval.TabIndex = 3;
            this.txtpval.UseSelectable = true;
            this.txtpval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // 상품관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.txtsale);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtwsprice);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtpval);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DBGrid);
            this.Name = "상품관리";
            this.Text = "상품관리";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DBGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtcode;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtwsprice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtsale;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton SearchBtn;
        private MetroFramework.Controls.MetroButton UpdateBtn;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton AppendBtn;
        private MetroFramework.Controls.MetroButton DAOpenBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtpval;
    }
}