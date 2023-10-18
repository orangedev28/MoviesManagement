namespace PhanMemQuanLyPhim
{
    partial class SearchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.maphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioihantuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovie
            // 
            this.dgvMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphim,
            this.tenphim,
            this.thoiluong,
            this.gioihantuoi,
            this.theloai,
            this.dienvien,
            this.daodien,
            this.nhasx,
            this.quocgia,
            this.noidung});
            this.dgvMovie.Location = new System.Drawing.Point(24, 172);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.RowHeadersWidth = 51;
            this.dgvMovie.RowTemplate.Height = 24;
            this.dgvMovie.Size = new System.Drawing.Size(1410, 355);
            this.dgvMovie.TabIndex = 9;
            // 
            // maphim
            // 
            this.maphim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphim.HeaderText = "Mã Phim";
            this.maphim.MinimumWidth = 6;
            this.maphim.Name = "maphim";
            // 
            // tenphim
            // 
            this.tenphim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenphim.HeaderText = "Tên Phim";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            // 
            // thoiluong
            // 
            this.thoiluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoiluong.HeaderText = "Thời Lượng";
            this.thoiluong.MinimumWidth = 6;
            this.thoiluong.Name = "thoiluong";
            // 
            // gioihantuoi
            // 
            this.gioihantuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioihantuoi.HeaderText = "GH Tuổi";
            this.gioihantuoi.MinimumWidth = 6;
            this.gioihantuoi.Name = "gioihantuoi";
            // 
            // theloai
            // 
            this.theloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.MinimumWidth = 6;
            this.theloai.Name = "theloai";
            // 
            // dienvien
            // 
            this.dienvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dienvien.HeaderText = "Diễn Viên";
            this.dienvien.MinimumWidth = 6;
            this.dienvien.Name = "dienvien";
            // 
            // daodien
            // 
            this.daodien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.daodien.HeaderText = "Đạo Diễn";
            this.daodien.MinimumWidth = 6;
            this.daodien.Name = "daodien";
            // 
            // nhasx
            // 
            this.nhasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nhasx.HeaderText = "Nhà SX";
            this.nhasx.MinimumWidth = 6;
            this.nhasx.Name = "nhasx";
            // 
            // quocgia
            // 
            this.quocgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quocgia.HeaderText = "Quốc Gia";
            this.quocgia.MinimumWidth = 6;
            this.quocgia.Name = "quocgia";
            // 
            // noidung
            // 
            this.noidung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noidung.HeaderText = "Nội Dung Chính";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            // 
            // txtSearchResults
            // 
            this.txtSearchResults.Location = new System.Drawing.Point(160, 93);
            this.txtSearchResults.Name = "txtSearchResults";
            this.txtSearchResults.Size = new System.Drawing.Size(100, 27);
            this.txtSearchResults.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kết quả tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(263, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(913, 27);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.txtSearchResults);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1410, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tìm Kiếm";
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMovie);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(1460, 549);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioihantuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn daodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn quocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.TextBox txtSearchResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
