namespace QLNV_RapChieuPhim
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblROLE = new System.Windows.Forms.Label();
            this.cbChucNang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1NV = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.btndetail = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picSort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1NV)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(15, 233);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.Size = new System.Drawing.Size(1188, 351);
            this.dgvMain.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "NHÂN VIÊN RẠP CHIẾU PHIM ABC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblROLE
            // 
            this.lblROLE.BackColor = System.Drawing.Color.Transparent;
            this.lblROLE.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROLE.Location = new System.Drawing.Point(88, 20);
            this.lblROLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblROLE.Name = "lblROLE";
            this.lblROLE.Size = new System.Drawing.Size(268, 34);
            this.lblROLE.TabIndex = 11;
            // 
            // cbChucNang
            // 
            this.cbChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbChucNang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucNang.ForeColor = System.Drawing.Color.Red;
            this.cbChucNang.FormattingEnabled = true;
            this.cbChucNang.Items.AddRange(new object[] {
            "CÔNG VIỆC",
            "LƯƠNG",
            "LƯỢT LÀM VIỆC",
            "NHÂN VIÊN"});
            this.cbChucNang.Location = new System.Drawing.Point(14, 189);
            this.cbChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(244, 34);
            this.cbChucNang.TabIndex = 13;
            this.cbChucNang.SelectedIndexChanged += new System.EventHandler(this.cbChucNang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(71, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "TÙY CHỌN";
            // 
            // dgv1NV
            // 
            this.dgv1NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1NV.Location = new System.Drawing.Point(266, 189);
            this.dgv1NV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1NV.Name = "dgv1NV";
            this.dgv1NV.RowHeadersWidth = 51;
            this.dgv1NV.Size = new System.Drawing.Size(13, 12);
            this.dgv1NV.TabIndex = 16;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(458, 188);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(285, 35);
            this.txtTimkiem.TabIndex = 18;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblsearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Blue;
            this.lblsearch.Location = new System.Drawing.Point(542, 158);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(140, 26);
            this.lblsearch.TabIndex = 20;
            this.lblsearch.Text = "TÌM KIẾM:";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.picNV);
            this.pnlUser.Controls.Add(this.lblROLE);
            this.pnlUser.Location = new System.Drawing.Point(16, 66);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(408, 70);
            this.pnlUser.TabIndex = 21;
            this.pnlUser.Click += new System.EventHandler(this.pnlUser_Click);
            // 
            // picNV
            // 
            this.picNV.BackColor = System.Drawing.Color.Transparent;
            this.picNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNV.Location = new System.Drawing.Point(20, 10);
            this.picNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(60, 52);
            this.picNV.TabIndex = 12;
            this.picNV.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNTienIch});
            this.menuStrip1.Location = new System.Drawing.Point(959, 66);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(81, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNTienIch
            // 
            this.MNTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.xemLươngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.MNTienIch.Name = "MNTienIch";
            this.MNTienIch.Size = new System.Drawing.Size(74, 24);
            this.MNTienIch.Text = "Tiện ích";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // xemLươngToolStripMenuItem
            // 
            this.xemLươngToolStripMenuItem.Name = "xemLươngToolStripMenuItem";
            this.xemLươngToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.xemLươngToolStripMenuItem.Text = "Xem Lương";
            this.xemLươngToolStripMenuItem.Click += new System.EventHandler(this.xemLươngToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.BackgroundImage = global::QLNV_RapChieuPhim.Properties.Resources.timkiem1;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(751, 188);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(41, 34);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // picreset
            // 
            this.picreset.BackColor = System.Drawing.Color.Transparent;
            this.picreset.BackgroundImage = global::QLNV_RapChieuPhim.Properties.Resources.reset;
            this.picreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picreset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picreset.ErrorImage = null;
            this.picreset.InitialImage = null;
            this.picreset.Location = new System.Drawing.Point(1157, 599);
            this.picreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(44, 34);
            this.picreset.TabIndex = 12;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // btndetail
            // 
            this.btndetail.BackColor = System.Drawing.Color.Transparent;
            this.btndetail.BackgroundImage = global::QLNV_RapChieuPhim.Properties.Resources.greenn;
            this.btndetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndetail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetail.ForeColor = System.Drawing.Color.Blue;
            this.btndetail.Location = new System.Drawing.Point(16, 592);
            this.btndetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(153, 53);
            this.btndetail.TabIndex = 5;
            this.btndetail.Text = "DETAIL";
            this.btndetail.UseVisualStyleBackColor = false;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.Red;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(971, 186);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(231, 34);
            this.cbSort.TabIndex = 23;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1108, 158);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 21);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Giảm dần";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picSort
            // 
            this.picSort.BackColor = System.Drawing.Color.Transparent;
            this.picSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSort.BackgroundImage")));
            this.picSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSort.ErrorImage = null;
            this.picSort.InitialImage = null;
            this.picSort.Location = new System.Drawing.Point(884, 186);
            this.picSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSort.Name = "picSort";
            this.picSort.Size = new System.Drawing.Size(44, 36);
            this.picSort.TabIndex = 25;
            this.picSort.TabStop = false;
            this.picSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1219, 670);
            this.Controls.Add(this.picSort);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.dgv1NV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChucNang);
            this.Controls.Add(this.picreset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btndetail);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1NV)).EndInit();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblROLE;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.ComboBox cbChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1NV;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox picNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNTienIch;
        private System.Windows.Forms.ToolStripMenuItem xemLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picSort;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
    }
}

