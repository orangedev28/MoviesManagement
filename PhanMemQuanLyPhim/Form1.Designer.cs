namespace PhanMemQuanLyPhim
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviemngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorymngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actormngDiễnViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directormngĐạoDiễnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producermngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countrymngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mvreportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.ptbMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.mvreportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviemngToolStripMenuItem,
            this.categorymngToolStripMenuItem,
            this.actormngDiễnViênToolStripMenuItem,
            this.directormngĐạoDiễnToolStripMenuItem,
            this.producermngToolStripMenuItem,
            this.countrymngToolStripMenuItem,
            this.findToolStripMenuItem,
            this.closeappToolStripMenuItem});
            this.optionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionToolStripMenuItem.Image")));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.optionToolStripMenuItem.Text = "Chức năng chính";
            // 
            // moviemngToolStripMenuItem
            // 
            this.moviemngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moviemngToolStripMenuItem.Image")));
            this.moviemngToolStripMenuItem.Name = "moviemngToolStripMenuItem";
            this.moviemngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moviemngToolStripMenuItem.Text = "Quản lý  Phim";
            this.moviemngToolStripMenuItem.Click += new System.EventHandler(this.moviemngToolStripMenuItem_Click);
            // 
            // categorymngToolStripMenuItem
            // 
            this.categorymngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categorymngToolStripMenuItem.Image")));
            this.categorymngToolStripMenuItem.Name = "categorymngToolStripMenuItem";
            this.categorymngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categorymngToolStripMenuItem.Text = "Quản lý Thể Loại";
            this.categorymngToolStripMenuItem.Click += new System.EventHandler(this.categorymngToolStripMenuItem_Click);
            // 
            // actormngDiễnViênToolStripMenuItem
            // 
            this.actormngDiễnViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actormngDiễnViênToolStripMenuItem.Image")));
            this.actormngDiễnViênToolStripMenuItem.Name = "actormngDiễnViênToolStripMenuItem";
            this.actormngDiễnViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actormngDiễnViênToolStripMenuItem.Text = "Quản lý Diễn Viên";
            this.actormngDiễnViênToolStripMenuItem.Click += new System.EventHandler(this.actormngDiễnViênToolStripMenuItem_Click);
            // 
            // directormngĐạoDiễnToolStripMenuItem
            // 
            this.directormngĐạoDiễnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("directormngĐạoDiễnToolStripMenuItem.Image")));
            this.directormngĐạoDiễnToolStripMenuItem.Name = "directormngĐạoDiễnToolStripMenuItem";
            this.directormngĐạoDiễnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.directormngĐạoDiễnToolStripMenuItem.Text = "Quản lý Đạo Diễn";
            this.directormngĐạoDiễnToolStripMenuItem.Click += new System.EventHandler(this.directormngĐạoDiễnToolStripMenuItem_Click);
            // 
            // producermngToolStripMenuItem
            // 
            this.producermngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("producermngToolStripMenuItem.Image")));
            this.producermngToolStripMenuItem.Name = "producermngToolStripMenuItem";
            this.producermngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.producermngToolStripMenuItem.Text = "Quản lý Nhà SX";
            this.producermngToolStripMenuItem.Click += new System.EventHandler(this.producermngToolStripMenuItem_Click);
            // 
            // countrymngToolStripMenuItem
            // 
            this.countrymngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("countrymngToolStripMenuItem.Image")));
            this.countrymngToolStripMenuItem.Name = "countrymngToolStripMenuItem";
            this.countrymngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.countrymngToolStripMenuItem.Text = "Quản lý Nước SX";
            this.countrymngToolStripMenuItem.Click += new System.EventHandler(this.countrymngToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "Tìm kiếm Phim";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // closeappToolStripMenuItem
            // 
            this.closeappToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeappToolStripMenuItem.Image")));
            this.closeappToolStripMenuItem.Name = "closeappToolStripMenuItem";
            this.closeappToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeappToolStripMenuItem.Text = "Đóng Ứng dụng";
            this.closeappToolStripMenuItem.Click += new System.EventHandler(this.closeappToolStripMenuItem_Click);
            // 
            // mvreportToolStripMenuItem
            // 
            this.mvreportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mvreportToolStripMenuItem.Image")));
            this.mvreportToolStripMenuItem.Name = "mvreportToolStripMenuItem";
            this.mvreportToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.mvreportToolStripMenuItem.Text = "Báo cáo";
            this.mvreportToolStripMenuItem.Click += new System.EventHandler(this.mvreportToolStripMenuItem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(1441, 578);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(194, 52);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng Ứng Dụng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.ptbMain);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 28);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1322, 639);
            this.panelControl.TabIndex = 3;
            // 
            // ptbMain
            // 
            this.ptbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMain.Image = global::PhanMemQuanLyPhim.Properties.Resources.f1108e0990f657a80ee7;
            this.ptbMain.Location = new System.Drawing.Point(0, 0);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(1322, 639);
            this.ptbMain.TabIndex = 0;
            this.ptbMain.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 667);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Phim";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox ptbMain;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorymngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actormngDiễnViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directormngĐạoDiễnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producermngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countrymngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviemngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mvreportToolStripMenuItem;
    }
}

