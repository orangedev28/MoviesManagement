using PhanMemQuanLyPhim.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyPhim
{
    public partial class DirectorUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<DaoDien> daoDiens = new List<DaoDien>();
        public DirectorUserControl()
        {
            InitializeComponent();
            DirectorUserControl_Load();
        }

        void DirectorUserControl_Load()
        {

            try
            {
                daoDiens = dbContext.DaoDiens.ToList();
                BindDirectorGrid(daoDiens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDirectorGrid(List<DaoDien> daoDiens)
        {
            try
            {
                dgvDirector.Rows.Clear();
                foreach (var item in daoDiens)
                {
                    int index = dgvDirector.Rows.Add();
                    dgvDirector.Rows[index].Cells[0].Value = item.MaDaoDien;
                    dgvDirector.Rows[index].Cells[1].Value = item.TenDaoDien;
                    dgvDirector.Rows[index].Cells[2].Value = item.ThongTinDaoDien;
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
                DaoDien drt = daoDiens.Where(p => p.MaDaoDien == ID).FirstOrDefault();

                if (drt != null)
                {
                    drt.TenDaoDien = txtName.Text;
                    drt.MaDaoDien = txtID.Text;
                    drt.ThongTinDaoDien = richTextBoxTTDD.Text;
                    dbContext.SaveChanges();
                    daoDiens = dbContext.DaoDiens.ToList();
                    BindDirectorGrid(daoDiens);
                    MessageBox.Show("Cập nhật Đạo Diễn thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    drt = new DaoDien();
                    drt.MaDaoDien = txtID.Text;
                    drt.TenDaoDien = txtName.Text;
                    drt.ThongTinDaoDien = richTextBoxTTDD.Text;
                    dbContext.DaoDiens.Add(drt);
                    dbContext.SaveChanges();
                    daoDiens = dbContext.DaoDiens.ToList();
                    BindDirectorGrid(daoDiens);
                    MessageBox.Show("Thêm mới Đạo Diễn thành công!", "Thông Báo", MessageBoxButtons.OK);
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
                DaoDien drt = daoDiens.Where(p => p.MaDaoDien == ID).FirstOrDefault();
                if (drt != null)
                {
                    dbContext.DaoDiens.Remove(drt);
                    dbContext.SaveChanges();
                    daoDiens = dbContext.DaoDiens.ToList();
                    BindDirectorGrid(daoDiens);
                    MessageBox.Show("Xóa Đạo Diễn thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Đạo Diễn cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            richTextBoxTTDD.Text = "";
        }

        private void dgvDirector_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDirector.SelectedRows.Count > 0)
                {
                    string ID = dgvDirector.SelectedRows[0].Cells[0].Value.ToString();
                    DaoDien drt = daoDiens.Where(p => p.MaDaoDien == ID).FirstOrDefault();
                    txtID.Text = drt.MaDaoDien.ToString();
                    txtName.Text = drt.TenDaoDien.ToString();
                    richTextBoxTTDD.Text = drt.ThongTinDaoDien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
