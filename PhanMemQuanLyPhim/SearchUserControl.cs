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
    public partial class SearchUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<Phim> phims = new List<Phim>();
        List<TheLoai> theLoais = new List<TheLoai>();
        List<DienVien> dienViens = new List<DienVien>();
        List<DaoDien> daoDiens = new List<DaoDien>();
        List<NhaSanXuat> nhaSanXuats = new List<NhaSanXuat>();
        List<NuocSanXuat> nuocSanXuats = new List<NuocSanXuat>();

        public SearchUserControl()
        {
            InitializeComponent();
            SearchUserControl_Load();
        }

        void SearchUserControl_Load()
        {
            phims = dbContext.Phims.ToList();
            theLoais = dbContext.TheLoais.ToList();
            dienViens = dbContext.DienViens.ToList();
            daoDiens = dbContext.DaoDiens.ToList();
            nhaSanXuats = dbContext.NhaSanXuats.ToList();
            nuocSanXuats = dbContext.NuocSanXuats.ToList();
            BindMovieGrid(phims);
        }

        private void BindMovieGrid(List<Phim> phims)
        {
            try
            {
                dgvMovie.Rows.Clear();
                foreach (var item in phims)
                {
                    int index = dgvMovie.Rows.Add();
                    dgvMovie.Rows[index].Cells[0].Value = item.MaPhim;
                    dgvMovie.Rows[index].Cells[1].Value = item.TenPhim;
                    dgvMovie.Rows[index].Cells[2].Value = item.ThoiLuong;
                    dgvMovie.Rows[index].Cells[3].Value = item.GioiHanTuoi;
                    dgvMovie.Rows[index].Cells[4].Value = item.TheLoai.TenTheLoai;
                    dgvMovie.Rows[index].Cells[5].Value = item.DienVien.TenDienVien;
                    dgvMovie.Rows[index].Cells[6].Value = item.DaoDien.TenDaoDien;
                    dgvMovie.Rows[index].Cells[7].Value = item.NhaSanXuat.TenNhaSX;
                    dgvMovie.Rows[index].Cells[8].Value = item.NuocSanXuat.TenNuocSX;
                    dgvMovie.Rows[index].Cells[9].Value = item.NoiDungChinh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                int count = 0;

                phims = dbContext.Phims.Where(p => p.MaPhim.ToLower().Contains(txtSearch.Text.ToLower())
                || p.TenPhim.ToLower().Contains(txtSearch.Text.ToLower())
                || p.TheLoai.TenTheLoai.ToLower().Contains(txtSearch.Text.ToLower())
                || p.DienVien.TenDienVien.ToLower().Contains(txtSearch.Text.ToLower())
                || p.DaoDien.TenDaoDien.ToLower().Contains(txtSearch.Text.ToLower())
                || p.NhaSanXuat.TenNhaSX.ToLower().Contains(txtSearch.Text.ToLower())
                || p.NuocSanXuat.TenNuocSX.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                BindMovieGrid(phims);
                count = phims.Count;
                txtSearchResults.Text = count.ToString();
            }
            else
            {
                phims = dbContext.Phims.ToList();
                BindMovieGrid(phims);
            }
        }
    }
}
