namespace PhanMemQuanLyPhim
{
    partial class ProducerUserControl
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
            this.richTextBoxTTNSX = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducer = new System.Windows.Forms.DataGridView();
            this.manhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtinnhasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefesh
            // 
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(28, 453);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(149, 49);
            this.btnRefesh.TabIndex = 20;
            this.btnRefesh.Text = "Làm mới nhập";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(363, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 49);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa Nhà SX";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.Location = new System.Drawing.Point(226, 453);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(131, 49);
            this.btnAddEdit.TabIndex = 18;
            this.btnAddEdit.Text = "Thêm / Sửa Nhà SX";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.richTextBoxTTNSX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 419);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhà SX";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 27);
            this.txtName.TabIndex = 10;
            // 
            // richTextBoxTTNSX
            // 
            this.richTextBoxTTNSX.Location = new System.Drawing.Point(6, 227);
            this.richTextBoxTTNSX.Name = "richTextBoxTTNSX";
            this.richTextBoxTTNSX.Size = new System.Drawing.Size(470, 189);
            this.richTextBoxTTNSX.TabIndex = 10;
            this.richTextBoxTTNSX.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thông Tin Nhà SX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhà SX";
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
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Nhà SX";
            // 
            // dgvProducer
            // 
            this.dgvProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhasx,
            this.tennhasx,
            this.thongtinnhasx});
            this.dgvProducer.Location = new System.Drawing.Point(528, 22);
            this.dgvProducer.Name = "dgvProducer";
            this.dgvProducer.RowHeadersWidth = 51;
            this.dgvProducer.RowTemplate.Height = 24;
            this.dgvProducer.Size = new System.Drawing.Size(829, 480);
            this.dgvProducer.TabIndex = 16;
            this.dgvProducer.SelectionChanged += new System.EventHandler(this.dgvProducer_SelectionChanged);
            // 
            // manhasx
            // 
            this.manhasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manhasx.HeaderText = "Mã Nhà SX";
            this.manhasx.MinimumWidth = 6;
            this.manhasx.Name = "manhasx";
            // 
            // tennhasx
            // 
            this.tennhasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennhasx.HeaderText = "Tên Nhà SX";
            this.tennhasx.MinimumWidth = 6;
            this.tennhasx.Name = "tennhasx";
            // 
            // thongtinnhasx
            // 
            this.thongtinnhasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thongtinnhasx.HeaderText = "Thông Tin Nhà SX";
            this.thongtinnhasx.MinimumWidth = 6;
            this.thongtinnhasx.Name = "thongtinnhasx";
            // 
            // ProducerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducer);
            this.Name = "ProducerUserControl";
            this.Size = new System.Drawing.Size(1378, 535);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox richTextBoxTTNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongtinnhasx;
    }
}
