namespace WindowsFormsApp3
{
    partial class 메인메뉴
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView3 = new MetroFramework.Controls.MetroListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView4 = new MetroFramework.Controls.MetroListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView5 = new MetroFramework.Controls.MetroListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(1160, 208);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(236, 99);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "상품관리";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(1160, 504);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(236, 92);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "재고관리";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.DisplayFocus = true;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Location = new System.Drawing.Point(1160, 800);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(236, 105);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "매출관리";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1119, 2);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(14, 1131);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(77, 103);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(388, 258);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "메뉴";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수량";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "가격";
            this.columnHeader3.Width = 80;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(629, 103);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(388, 258);
            this.metroListView1.TabIndex = 11;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "메뉴";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수량";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "가격";
            this.columnHeader6.Width = 80;
            // 
            // metroListView2
            // 
            this.metroListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(77, 436);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(388, 258);
            this.metroListView2.TabIndex = 11;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.View = System.Windows.Forms.View.Details;
            this.metroListView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "메뉴";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "수량";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "가격";
            this.columnHeader9.Width = 80;
            // 
            // metroListView3
            // 
            this.metroListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.metroListView3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView3.FullRowSelect = true;
            this.metroListView3.Location = new System.Drawing.Point(629, 436);
            this.metroListView3.Name = "metroListView3";
            this.metroListView3.OwnerDraw = true;
            this.metroListView3.Size = new System.Drawing.Size(388, 258);
            this.metroListView3.TabIndex = 11;
            this.metroListView3.UseCompatibleStateImageBehavior = false;
            this.metroListView3.UseSelectable = true;
            this.metroListView3.View = System.Windows.Forms.View.Details;
            this.metroListView3.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "메뉴";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "수량";
            this.columnHeader11.Width = 98;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "가격";
            this.columnHeader12.Width = 80;
            // 
            // metroListView4
            // 
            this.metroListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.metroListView4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView4.FullRowSelect = true;
            this.metroListView4.Location = new System.Drawing.Point(77, 800);
            this.metroListView4.Name = "metroListView4";
            this.metroListView4.OwnerDraw = true;
            this.metroListView4.Size = new System.Drawing.Size(388, 258);
            this.metroListView4.TabIndex = 11;
            this.metroListView4.UseCompatibleStateImageBehavior = false;
            this.metroListView4.UseSelectable = true;
            this.metroListView4.View = System.Windows.Forms.View.Details;
            this.metroListView4.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "메뉴";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "수량";
            this.columnHeader14.Width = 98;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "가격";
            this.columnHeader15.Width = 80;
            // 
            // metroListView5
            // 
            this.metroListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.metroListView5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView5.FullRowSelect = true;
            this.metroListView5.Location = new System.Drawing.Point(629, 800);
            this.metroListView5.Name = "metroListView5";
            this.metroListView5.OwnerDraw = true;
            this.metroListView5.Size = new System.Drawing.Size(388, 258);
            this.metroListView5.TabIndex = 11;
            this.metroListView5.UseCompatibleStateImageBehavior = false;
            this.metroListView5.UseSelectable = true;
            this.metroListView5.View = System.Windows.Forms.View.Details;
            this.metroListView5.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "메뉴";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "수량";
            this.columnHeader17.Width = 98;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "가격";
            this.columnHeader18.Width = 80;
            // 
            // 메인메뉴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 1106);
            this.Controls.Add(this.metroListView5);
            this.Controls.Add(this.metroListView4);
            this.Controls.Add(this.metroListView3);
            this.Controls.Add(this.metroListView2);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "메인메뉴";
            this.Padding = new System.Windows.Forms.Padding(29, 90, 29, 30);
            this.Text = "가게 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTile metroTile1;
        public MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public MetroFramework.Controls.MetroListView metroListView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        public MetroFramework.Controls.MetroListView metroListView3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        public MetroFramework.Controls.MetroListView metroListView4;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        public MetroFramework.Controls.MetroListView metroListView5;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}

