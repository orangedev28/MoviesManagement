namespace PhanMemQuanLyPhim
{
    partial class DirectorUserControl
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
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.richTextBoxTTDD = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDirector = new System.Windows.Forms.DataGridView();
            this.madaodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtindd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefesh
            // 
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(24, 454);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(149, 49);
            this.btnRefesh.TabIndex = 15;
            this.btnRefesh.Text = "Làm mới nhập";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(359, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 49);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa Đạo Diễn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.Location = new System.Drawing.Point(222, 454);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(131, 49);
            this.btnAddEdit.TabIndex = 13;
            this.btnAddEdit.Text = "Thêm / Sửa Đạo Diễn";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.richTextBoxTTDD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 419);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Đạo Diễn";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 27);
            this.txtName.TabIndex = 10;
            // 
            // richTextBoxTTDD
            // 
            this.richTextBoxTTDD.Location = new System.Drawing.Point(6, 227);
            this.richTextBoxTTDD.Name = "richTextBoxTTDD";
            this.richTextBoxTTDD.Size = new System.Drawing.Size(470, 189);
            this.richTextBoxTTDD.TabIndex = 10;
            this.richTextBoxTTDD.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thông Tin Đạo Diễn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Đạo Diễn";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(238, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 27);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Đạo Diễn";
            // 
            // dgvDirector
            // 
            this.dgvDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madaodien,
            this.tendaodien,
            this.thongtindd});
            this.dgvDirector.Location = new System.Drawing.Point(524, 23);
            this.dgvDirector.Name = "dgvDirector";
            this.dgvDirector.RowHeadersWidth = 51;
            this.dgvDirector.RowTemplate.Height = 24;
            this.dgvDirector.Size = new System.Drawing.Size(829, 480);
            this.dgvDirector.TabIndex = 11;
            this.dgvDirector.SelectionChanged += new System.EventHandler(this.dgvDirector_SelectionChanged);
            // 
            // madaodien
            // 
            this.madaodien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madaodien.HeaderText = "Mã Đạo Diễn";
            this.madaodien.MinimumWidth = 6;
            this.madaodien.Name = "madaodien";
            // 
            // tendaodien
            // 
            this.tendaodien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendaodien.HeaderText = "Tên Đạo Diễn";
            this.tendaodien.MinimumWidth = 6;
            this.tendaodien.Name = "tendaodien";
            // 
            // thongtindd
            // 
            this.thongtindd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thongtindd.HeaderText = "Thông Tin ĐD";
            this.thongtindd.MinimumWidth = 6;
            this.thongtindd.Name = "thongtindd";
            // 
            // DirectorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDirector);
            this.Name = "DirectorUserControl";
            this.Size = new System.Drawing.Size(1372, 544);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox richTextBoxTTDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn madaodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongtindd;
    }
}
