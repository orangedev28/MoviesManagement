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
    public partial class CountryUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<NuocSanXuat> nuocSanXuats = new List<NuocSanXuat>();
        public CountryUserControl()
        {
            InitializeComponent();
            CountryUserControl_Load();
        }

        void CountryUserControl_Load()
        {

            try
            {
                nuocSanXuats = dbContext.NuocSanXuats.ToList();
                BindCountryGrid(nuocSanXuats);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindCountryGrid(List<NuocSanXuat> nuocSanXuats)
        {
            try
            {
                dgvCountry.Rows.Clear();
                foreach (var item in nuocSanXuats)
                {
                    int index = dgvCountry.Rows.Add();
                    dgvCountry.Rows[index].Cells[0].Value = item.MaNuocSX;
                    dgvCountry.Rows[index].Cells[1].Value = item.TenNuocSX;
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
                NuocSanXuat ct = nuocSanXuats.Where(p => p.MaNuocSX == ID).FirstOrDefault();

                if (ct != null)
                {
                    ct.TenNuocSX = txtName.Text;
                    ct.MaNuocSX = txtID.Text;
                    dbContext.SaveChanges();
                    nuocSanXuats = dbContext.NuocSanXuats.ToList();
                    BindCountryGrid(nuocSanXuats);
                    MessageBox.Show("Cập nhật Nước SX thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    ct = new NuocSanXuat();
                    ct.MaNuocSX = txtID.Text;
                    ct.TenNuocSX = txtName.Text;
                    dbContext.NuocSanXuats.Add(ct);
                    dbContext.SaveChanges();
                    nuocSanXuats = dbContext.NuocSanXuats.ToList();
                    BindCountryGrid(nuocSanXuats);
                    MessageBox.Show("Thêm mới Nước SX thành công!", "Thông Báo", MessageBoxButtons.OK);
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
                NuocSanXuat ct = nuocSanXuats.Where(p => p.MaNuocSX == ID).FirstOrDefault();
                if (ct != null)
                {
                    dbContext.NuocSanXuats.Remove(ct);
                    dbContext.SaveChanges();
                    nuocSanXuats = dbContext.NuocSanXuats.ToList();
                    BindCountryGrid(nuocSanXuats);
                    MessageBox.Show("Xóa Nước SX thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Nước SX cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCountry_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCountry.SelectedRows.Count > 0)
                {
                    string ID = dgvCountry.SelectedRows[0].Cells[0].Value.ToString();
                    NuocSanXuat ct = nuocSanXuats.Where(p => p.MaNuocSX == ID).FirstOrDefault();
                    txtID.Text = ct.MaNuocSX.ToString();
                    txtName.Text = ct.TenNuocSX.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
