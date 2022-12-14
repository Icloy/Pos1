namespace WindowsFormsApp3
{
    partial class 재고관리_수정
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DAOpenBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtsttext = new MetroFramework.Controls.MetroTextBox();
            this.txtcount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DBGrid = new MetroFramework.Controls.MetroGrid();
            this.UpdateBtn = new MetroFramework.Controls.MetroButton();
            this.AppendBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(50, 676);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(92, 27);
            this.DAOpenBtn.TabIndex = 28;
            this.DAOpenBtn.Text = "새로고침";
            this.DAOpenBtn.UseSelectable = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DeleteBtn.Location = new System.Drawing.Point(838, 643);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 60);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.UseSelectable = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(639, 583);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "비고";
            // 
            // txtsttext
            // 
            // 
            // 
            // 
            this.txtsttext.CustomButton.Image = null;
            this.txtsttext.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtsttext.CustomButton.Name = "";
            this.txtsttext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsttext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsttext.CustomButton.TabIndex = 1;
            this.txtsttext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsttext.CustomButton.UseSelectable = true;
            this.txtsttext.CustomButton.Visible = false;
            this.txtsttext.Lines = new string[0];
            this.txtsttext.Location = new System.Drawing.Point(682, 583);
            this.txtsttext.MaxLength = 32767;
            this.txtsttext.Name = "txtsttext";
            this.txtsttext.PasswordChar = '\0';
            this.txtsttext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsttext.SelectedText = "";
            this.txtsttext.SelectionLength = 0;
            this.txtsttext.SelectionStart = 0;
            this.txtsttext.ShortcutsEnabled = true;
            this.txtsttext.Size = new System.Drawing.Size(270, 23);
            this.txtsttext.TabIndex = 21;
            this.txtsttext.UseSelectable = true;
            this.txtsttext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsttext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtcount
            // 
            // 
            // 
            // 
            this.txtcount.CustomButton.Image = null;
            this.txtcount.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtcount.CustomButton.Name = "";
            this.txtcount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcount.CustomButton.TabIndex = 1;
            this.txtcount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcount.CustomButton.UseSelectable = true;
            this.txtcount.CustomButton.Visible = false;
            this.txtcount.Lines = new string[0];
            this.txtcount.Location = new System.Drawing.Point(545, 583);
            this.txtcount.MaxLength = 32767;
            this.txtcount.Name = "txtcount";
            this.txtcount.PasswordChar = '\0';
            this.txtcount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcount.SelectedText = "";
            this.txtcount.SelectionLength = 0;
            this.txtcount.SelectionStart = 0;
            this.txtcount.ShortcutsEnabled = true;
            this.txtcount.Size = new System.Drawing.Size(75, 23);
            this.txtcount.TabIndex = 18;
            this.txtcount.UseSelectable = true;
            this.txtcount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(502, 583);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "수량";
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
            this.txtcode.Location = new System.Drawing.Point(401, 583);
            this.txtcode.MaxLength = 32767;
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcode.SelectedText = "";
            this.txtcode.SelectionLength = 0;
            this.txtcode.SelectionStart = 0;
            this.txtcode.ShortcutsEnabled = true;
            this.txtcode.Size = new System.Drawing.Size(75, 23);
            this.txtcode.TabIndex = 15;
            this.txtcode.UseSelectable = true;
            this.txtcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(330, 583);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "상품코드";
            // 
            // DBGrid
            // 
            this.DBGrid.AllowUserToResizeRows = false;
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DBGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.DBGrid.EnableHeadersVisualStyles = false;
            this.DBGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DBGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DBGrid.Location = new System.Drawing.Point(23, 63);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBGrid.Size = new System.Drawing.Size(954, 475);
            this.DBGrid.TabIndex = 14;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.UpdateBtn.Location = new System.Drawing.Point(606, 643);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 60);
            this.UpdateBtn.TabIndex = 29;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseSelectable = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AppendBtn
            // 
            this.AppendBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AppendBtn.Location = new System.Drawing.Point(722, 643);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(110, 60);
            this.AppendBtn.TabIndex = 27;
            this.AppendBtn.Text = "추가";
            this.AppendBtn.UseSelectable = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click_1);
            // 
            // 재고관리_수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtsttext);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DBGrid);
            this.Name = "재고관리_수정";
            this.Text = "수정";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton DAOpenBtn;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtsttext;
        private MetroFramework.Controls.MetroTextBox txtcount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid DBGrid;
        private MetroFramework.Controls.MetroButton UpdateBtn;
        private MetroFramework.Controls.MetroButton AppendBtn;
    }
}