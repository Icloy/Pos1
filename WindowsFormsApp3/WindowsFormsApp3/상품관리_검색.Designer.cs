﻿
namespace WindowsFormsApp3
{
    partial class 상품관리_검색
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
            this.SearchDBGrid = new MetroFramework.Controls.MetroGrid();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Searchtxt = new MetroFramework.Controls.MetroTextBox();
            this.SearchBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDBGrid
            // 
            this.SearchDBGrid.AllowUserToResizeRows = false;
            this.SearchDBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchDBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchDBGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SearchDBGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchDBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SearchDBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchDBGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.SearchDBGrid.EnableHeadersVisualStyles = false;
            this.SearchDBGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchDBGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchDBGrid.Location = new System.Drawing.Point(17, 105);
            this.SearchDBGrid.Name = "SearchDBGrid";
            this.SearchDBGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchDBGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SearchDBGrid.RowHeadersWidth = 62;
            this.SearchDBGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SearchDBGrid.RowTemplate.Height = 23;
            this.SearchDBGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchDBGrid.Size = new System.Drawing.Size(681, 336);
            this.SearchDBGrid.TabIndex = 2;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(74, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(17, 76);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "품목명 검색";
            // 
            // Searchtxt
            // 
            // 
            // 
            // 
            this.Searchtxt.CustomButton.Image = null;
            this.Searchtxt.CustomButton.Location = new System.Drawing.Point(425, 1);
            this.Searchtxt.CustomButton.Name = "";
            this.Searchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Searchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Searchtxt.CustomButton.TabIndex = 1;
            this.Searchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Searchtxt.CustomButton.UseSelectable = true;
            this.Searchtxt.CustomButton.Visible = false;
            this.Searchtxt.Lines = new string[0];
            this.Searchtxt.Location = new System.Drawing.Point(98, 76);
            this.Searchtxt.MaxLength = 32767;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.SelectionLength = 0;
            this.Searchtxt.SelectionStart = 0;
            this.Searchtxt.ShortcutsEnabled = true;
            this.Searchtxt.Size = new System.Drawing.Size(519, 23);
            this.Searchtxt.TabIndex = 4;
            this.Searchtxt.UseSelectable = true;
            this.Searchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Searchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(623, 76);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseSelectable = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // 상품관리_검색
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 457);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.SearchDBGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "상품관리_검색";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 13);
            this.Text = "검색";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroGrid SearchDBGrid;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox Searchtxt;
        private MetroFramework.Controls.MetroButton SearchBtn;
    }
}