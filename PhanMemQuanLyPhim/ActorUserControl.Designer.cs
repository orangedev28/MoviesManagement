namespace PhanMemQuanLyPhim
{
    partial class ActorUserControl
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.richTextBoxTTDV = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvActor = new System.Windows.Forms.DataGridView();
            this.madienvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendienvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtindv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(367, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa Diễn Viên";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.Location = new System.Drawing.Point(230, 456);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(131, 49);
            this.btnAddEdit.TabIndex = 8;
            this.btnAddEdit.Text = "Thêm / Sửa Diễn Viên";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Violet;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.richTextBoxTTDV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 419);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Diễn Viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 27);
            this.txtName.TabIndex = 10;
            // 
            // richTextBoxTTDV
            // 
            this.richTextBoxTTDV.Location = new System.Drawing.Point(6, 227);
            this.richTextBoxTTDV.Name = "richTextBoxTTDV";
            this.richTextBoxTTDV.Size = new System.Drawing.Size(470, 189);
            this.richTextBoxTTDV.TabIndex = 10;
            this.richTextBoxTTDV.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thông Tin Diễn Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Diễn Viên";
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
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Diễn Viên";
            // 
            // dgvActor
            // 
            this.dgvActor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madienvien,
            this.tendienvien,
            this.thongtindv});
            this.dgvActor.Location = new System.Drawing.Point(532, 25);
            this.dgvActor.Name = "dgvActor";
            this.dgvActor.RowHeadersWidth = 51;
            this.dgvActor.RowTemplate.Height = 24;
            this.dgvActor.Size = new System.Drawing.Size(828, 480);
            this.dgvActor.TabIndex = 6;
            this.dgvActor.SelectionChanged += new System.EventHandler(this.dgvActor_SelectionChanged);
            // 
            // madienvien
            // 
            this.madienvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madienvien.HeaderText = "Mã Diễn Viên";
            this.madienvien.MinimumWidth = 6;
            this.madienvien.Name = "madienvien";
            // 
            // tendienvien
            // 
            this.tendienvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendienvien.HeaderText = "Tên Diễn Viên";
            this.tendienvien.MinimumWidth = 6;
            this.tendienvien.Name = "tendienvien";
            // 
            // thongtindv
            // 
            this.thongtindv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thongtindv.HeaderText = "Thông Tin DV";
            this.thongtindv.MinimumWidth = 6;
            this.thongtindv.Name = "thongtindv";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(37, 456);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(149, 49);
            this.btnRefesh.TabIndex = 10;
            this.btnRefesh.Text = "Làm mới nhập";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // ActorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvActor);
            this.Name = "ActorUserControl";
            this.Size = new System.Drawing.Size(1383, 539);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxTTDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvActor;
        private System.Windows.Forms.DataGridViewTextBoxColumn madienvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendienvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongtindv;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRefesh;
    }
}
