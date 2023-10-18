using PhanMemQuanLyPhim.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyPhim
{
    public partial class CategoryUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<TheLoai> theLoais = new List<TheLoai>();
        public CategoryUserControl()
        {
            InitializeComponent();
            CategoryUserControl_Load();
        }

        void CategoryUserControl_Load()
        {

            try
            {
                theLoais = dbContext.TheLoais.ToList();
                BindCategoryGrid(theLoais);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindCategoryGrid(List<TheLoai> theLoais)
        {
            try
            {
                dgvCategory.Rows.Clear();
                foreach (var item in theLoais)
                {
                    int index = dgvCategory.Rows.Add();
                    dgvCategory.Rows[index].Cells[0].Value = item.MaTheLoai;
                    dgvCategory.Rows[index].Cells[1].Value = item.TenTheLoai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtID.Text;
                TheLoai cgr = theLoais.Where(p => p.MaTheLoai == ID).FirstOrDefault();

                if (cgr != null)
                {
                    cgr.TenTheLoai = txtName.Text;
                    cgr.MaTheLoai = txtID.Text;  
                    dbContext.SaveChanges();
                    theLoais = dbContext.TheLoais.ToList();
                    BindCategoryGrid(theLoais);
                    MessageBox.Show("Cập nhật Thể loại thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    cgr = new TheLoai();
                    cgr.MaTheLoai = txtID.Text;
                    cgr.TenTheLoai = txtName.Text;
                    dbContext.TheLoais.Add(cgr);
                    dbContext.SaveChanges();
                    theLoais = dbContext.TheLoais.ToList();
                    BindCategoryGrid(theLoais);
                    MessageBox.Show("Thêm mới Thể loại thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtID.Text;
                TheLoai cgr = theLoais.Where(p => p.MaTheLoai == ID).FirstOrDefault();
                if (cgr != null)
                {
                    dbContext.TheLoais.Remove(cgr);
                    dbContext.SaveChanges();
                    theLoais = dbContext.TheLoais.ToList();
                    BindCategoryGrid(theLoais);
                    MessageBox.Show("Xóa Thể Loại thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Thể loại cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategory.SelectedRows.Count > 0)
                {
                    string ID = dgvCategory.SelectedRows[0].Cells[0].Value.ToString();
                    TheLoai cgr = theLoais.Where(p => p.MaTheLoai == ID).FirstOrDefault();
                    txtID.Text = cgr.MaTheLoai.ToString();
                    txtName.Text = cgr.TenTheLoai.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
