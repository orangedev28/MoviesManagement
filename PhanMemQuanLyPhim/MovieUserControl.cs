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
    public partial class MovieUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<Phim> phims = new List<Phim>();
        List<TheLoai> theLoais = new List<TheLoai>();
        List<DienVien> dienViens = new List<DienVien>();
        List<DaoDien> daoDiens = new List<DaoDien>();
        List<NhaSanXuat> nhaSanXuats = new List<NhaSanXuat>();
        List<NuocSanXuat> nuocSanXuats = new List<NuocSanXuat>();

        public MovieUserControl()
        {
            InitializeComponent();
            MVUserControl_Load();
        }

        void MVUserControl_Load()
        {
            phims = dbContext.Phims.ToList();
            theLoais = dbContext.TheLoais.ToList();
            dienViens = dbContext.DienViens.ToList();
            daoDiens = dbContext.DaoDiens.ToList();
            nhaSanXuats = dbContext.NhaSanXuats.ToList();
            nuocSanXuats = dbContext.NuocSanXuats.ToList();
            FillCategoryCombobox(theLoais);
            FillActorCombobox(dienViens);
            FillDirectorCombobox(daoDiens);
            FillProducerCombobox(nhaSanXuats);
            FillCountryCombobox(nuocSanXuats);
            BindMovieGrid(phims);
        }

        private void FillCategoryCombobox(List<TheLoai> theLoais)
        {
            this.cmbCategory.DataSource = theLoais;
            this.cmbCategory.DisplayMember = "TenTheLoai";
            this.cmbCategory.ValueMember = "MaTheLoai";
        }

        private void FillActorCombobox(List<DienVien> dienViens)
        {
            this.cmbActor.DataSource = dienViens;
            this.cmbActor.DisplayMember = "TenDienVien";
            this.cmbActor.ValueMember = "MaDienVien";
        }

        private void FillDirectorCombobox(List<DaoDien> daoDiens)
        {
            this.cmbDirector.DataSource = daoDiens;
            this.cmbDirector.DisplayMember = "TenDaoDien";
            this.cmbDirector.ValueMember = "MaDaoDien";
        }

        private void FillProducerCombobox(List<NhaSanXuat> nhaSanXuats)
        {
            this.cmbProducer.DataSource = nhaSanXuats;
            this.cmbProducer.DisplayMember = "TenNhaSX";
            this.cmbProducer.ValueMember = "MaNhaSX";
        }

        private void FillCountryCombobox(List<NuocSanXuat> nuocSanXuats)
        {
            this.cmbCountry.DataSource = nuocSanXuats;
            this.cmbCountry.DisplayMember = "TenNuocSX";
            this.cmbCountry.ValueMember = "MaNuocSX";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TheLoai cgr = (TheLoai)cmbCategory.SelectedItem;
                DienVien at = (DienVien)cmbActor.SelectedItem;
                DaoDien drt = (DaoDien)cmbDirector.SelectedItem;
                NhaSanXuat pdc = (NhaSanXuat)cmbProducer.SelectedItem;
                NuocSanXuat ct = (NuocSanXuat)cmbCountry.SelectedItem;
                
                if (txtID.Text == "" || txtName.Text == "" || txtTime.Text == "" || txtAge.Text == "" || richTextBoxContent.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin phim!");
                }

                Phim ph = new Phim();
                ph.MaPhim = txtID.Text;
                ph.TenPhim = txtName.Text;
                ph.ThoiLuong = txtTime.Text;
                ph.GioiHanTuoi = txtAge.Text;
                ph.NoiDungChinh = richTextBoxContent.Text;
                ph.MaTheLoai = cgr.MaTheLoai;
                ph.MaDienVien = at.MaDienVien;
                ph.MaDaoDien = drt.MaDaoDien;
                ph.MaNhaSX = pdc.MaNhaSX;
                ph.MaNuocSX = ct.MaNuocSX;
                dbContext.Phims.Add(ph);
                dbContext.SaveChanges();
                phims = dbContext.Phims.ToList();
                BindMovieGrid(phims);
                MessageBox.Show("Thêm mới phim thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Phim ph = dbContext.Phims.FirstOrDefault(p => p.MaPhim == txtID.Text);
                TheLoai cgr = (TheLoai)cmbCategory.SelectedItem;
                DienVien at = (DienVien)cmbActor.SelectedItem;
                DaoDien drt = (DaoDien)cmbDirector.SelectedItem;
                NhaSanXuat pdc = (NhaSanXuat)cmbProducer.SelectedItem;
                NuocSanXuat ct = (NuocSanXuat)cmbCountry.SelectedItem;

                if (ph != null)
                {

                    ph.TenPhim = txtName.Text;
                    ph.MaPhim = txtID.Text;
                    ph.ThoiLuong = txtTime.Text;
                    ph.GioiHanTuoi = txtAge.Text;
                    ph.NoiDungChinh = richTextBoxContent.Text;
                    ph.MaTheLoai = cgr.MaTheLoai;
                    ph.MaDienVien = at.MaDienVien;
                    ph.MaDaoDien = drt.MaDaoDien;
                    ph.MaNhaSX = pdc.MaNhaSX;
                    ph.MaNuocSX = ct.MaNuocSX;
                    dbContext.SaveChanges();
                    BindMovieGrid(phims);
                    MessageBox.Show("Cập nhật Phim thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Phim cần sửa!", "Thông Báo", MessageBoxButtons.OK);
            
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
                Phim ph = dbContext.Phims.FirstOrDefault(p => p.MaPhim == txtID.Text);
                DialogResult dl = MessageBox.Show("Bạn có muốn xóa Phim này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dl == DialogResult.Yes)
                {
                    if (ph != null)
                    {
                        dbContext.Phims.Remove(ph);
                        dbContext.SaveChanges();
                        phims = dbContext.Phims.ToList();
                        BindMovieGrid(phims);
                        MessageBox.Show("Xóa Phim thành công!", "Thông Báo", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã Phim cần xóa!", "Thông Báo", MessageBoxButtons.OK);
                    }
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
            txtTime.Text = "";
            txtAge.Text = "";
            richTextBoxContent.Text = "";
        }

        private void dgvMovie_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovie.SelectedRows.Count > 0)
                {
                    string ID = dgvMovie.SelectedRows[0].Cells[0].Value.ToString();
                    Phim ph = dbContext.Phims.FirstOrDefault(p => p.MaPhim == ID);
                    txtID.Text = ph.MaPhim.ToString();
                    txtName.Text = ph.TenPhim.ToString();
                    txtTime.Text = ph.ThoiLuong.ToString();
                    txtAge.Text = ph.GioiHanTuoi.ToString();
                    richTextBoxContent.Text = ph.NoiDungChinh.ToString();
                    cmbCategory.Text = ph.TheLoai.TenTheLoai;
                    cmbActor.Text = ph.DienVien.TenDienVien;
                    cmbDirector.Text = ph.DaoDien.TenDaoDien;
                    cmbProducer.Text = ph.NhaSanXuat.TenNhaSX;
                    cmbCountry.Text = ph.NuocSanXuat.TenNuocSX;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
