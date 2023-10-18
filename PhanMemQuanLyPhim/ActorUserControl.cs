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
    public partial class ActorUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<DienVien> dienViens = new List<DienVien>();
        public ActorUserControl()
        {
            InitializeComponent();
            ActorUserControl_Load();
        }

        void ActorUserControl_Load()
        {

            try
            {
                dienViens = dbContext.DienViens.ToList();
                BindActorGrid(dienViens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindActorGrid(List<DienVien> dienViens)
        {
            try
            {
                dgvActor.Rows.Clear();
                foreach (var item in dienViens)
                {
                    int index = dgvActor.Rows.Add();
                    dgvActor.Rows[index].Cells[0].Value = item.MaDienVien;
                    dgvActor.Rows[index].Cells[1].Value = item.TenDienVien;
                    dgvActor.Rows[index].Cells[2].Value = item.ThongTinDienVien;
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
                DienVien at = dienViens.Where(p => p.MaDienVien== ID).FirstOrDefault();

                if (at != null)
                {
                    at.TenDienVien = txtName.Text;
                    at.MaDienVien = txtID.Text;
                    at.ThongTinDienVien = richTextBoxTTDV.Text;
                    dbContext.SaveChanges();
                    dienViens = dbContext.DienViens.ToList();
                    BindActorGrid(dienViens);
                    MessageBox.Show("Cập nhật Diễn Viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    at = new DienVien();
                    at.MaDienVien = txtID.Text;
                    at.TenDienVien = txtName.Text;
                    at.ThongTinDienVien = richTextBoxTTDV.Text;
                    dbContext.DienViens.Add(at);
                    dbContext.SaveChanges();
                    dienViens = dbContext.DienViens.ToList();
                    BindActorGrid(dienViens);
                    MessageBox.Show("Thêm mới Diễn Viên thành công!", "Thông Báo", MessageBoxButtons.OK);
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
                DienVien at = dienViens.Where(p => p.MaDienVien == ID).FirstOrDefault();
                if (at != null)
                {
                    dbContext.DienViens.Remove(at);
                    dbContext.SaveChanges();
                    dienViens = dbContext.DienViens.ToList();
                    BindActorGrid(dienViens);
                    MessageBox.Show("Xóa Diễn Viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Diễn Viên cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvActor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvActor.SelectedRows.Count > 0)
                {
                    string ID = dgvActor.SelectedRows[0].Cells[0].Value.ToString();
                    DienVien at = dienViens.Where(p => p.MaDienVien == ID).FirstOrDefault();
                    txtID.Text = at.MaDienVien.ToString();
                    txtName.Text = at.TenDienVien.ToString();
                    richTextBoxTTDV.Text = at.ThongTinDienVien.ToString();
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
            richTextBoxTTDV.Text = "";
        }
    }
}
