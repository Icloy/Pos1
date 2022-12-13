namespace WindowsFormsApp3
{
    partial class 재고관리
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DAOpenBtn = new MetroFramework.Controls.MetroButton();
            this.listView2 = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(838, 658);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(110, 60);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "수정";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(634, 658);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 60);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "검색";
            this.metroButton1.UseSelectable = true;
            // 
            // DAOpenBtn
            // 
            this.DAOpenBtn.Location = new System.Drawing.Point(23, 658);
            this.DAOpenBtn.Name = "DAOpenBtn";
            this.DAOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.DAOpenBtn.TabIndex = 21;
            this.DAOpenBtn.Text = "DAOpenBtn";
            this.DAOpenBtn.UseSelectable = true;
            this.DAOpenBtn.Click += new System.EventHandler(this.DAOpenBtn_Click);
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(23, 63);
            this.listView2.Name = "listView2";
            this.listView2.OwnerDraw = true;
            this.listView2.Size = new System.Drawing.Size(925, 561);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.UseSelectable = true;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.DAOpenBtn);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form3";
            this.Text = "재고관리";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton DAOpenBtn;
        private MetroFramework.Controls.MetroListView listView2;
    }
}