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
    public partial class ProducerUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<NhaSanXuat> nhaSanXuats = new List<NhaSanXuat>();
        public ProducerUserControl()
        {
            InitializeComponent();
            ProducerUserControl_Load();
        }

        void ProducerUserControl_Load()
        {

            try
            {
                nhaSanXuats = dbContext.NhaSanXuats.ToList();
                BindProducerGrid(nhaSanXuats);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindProducerGrid(List<NhaSanXuat> nhaSanXuats)
        {
            try
            {
                dgvProducer.Rows.Clear();
                foreach (var item in nhaSanXuats)
                {
                    int index = dgvProducer.Rows.Add();
                    dgvProducer.Rows[index].Cells[0].Value = item.MaNhaSX;
                    dgvProducer.Rows[index].Cells[1].Value = item.TenNhaSX;
                    dgvProducer.Rows[index].Cells[2].Value = item.ThongTinNhaSX;
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
                NhaSanXuat pdc = nhaSanXuats.Where(p => p.MaNhaSX == ID).FirstOrDefault();

                if (pdc != null)
                {
                    pdc.TenNhaSX = txtName.Text;
                    pdc.MaNhaSX = txtID.Text;
                    pdc.ThongTinNhaSX = richTextBoxTTNSX.Text;
                    dbContext.SaveChanges();
                    nhaSanXuats = dbContext.NhaSanXuats.ToList();
                    BindProducerGrid(nhaSanXuats);
                    MessageBox.Show("Cập nhật Nhà SX thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    pdc = new NhaSanXuat();
                    pdc.MaNhaSX = txtID.Text;
                    pdc.TenNhaSX= txtName.Text;
                    pdc.ThongTinNhaSX = richTextBoxTTNSX.Text;
                    dbContext.NhaSanXuats.Add(pdc);
                    dbContext.SaveChanges();
                    nhaSanXuats = dbContext.NhaSanXuats.ToList();
                    BindProducerGrid(nhaSanXuats);
                    MessageBox.Show("Thêm mới Nhà SX thành công!", "Thông Báo", MessageBoxButtons.OK);
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
                NhaSanXuat pdc = nhaSanXuats.Where(p => p.MaNhaSX == ID).FirstOrDefault();
                if (pdc != null)
                {
                    dbContext.NhaSanXuats.Remove(pdc);
                    dbContext.SaveChanges();
                    nhaSanXuats = dbContext.NhaSanXuats.ToList();
                    BindProducerGrid(nhaSanXuats);
                    MessageBox.Show("Xóa Nhà SX thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Nhà SX cần xóa!", "Thông Báo", MessageBoxButtons.OK);
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
            richTextBoxTTNSX.Text = "";
        }

        private void dgvProducer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducer.SelectedRows.Count > 0)
                {
                    string ID = dgvProducer.SelectedRows[0].Cells[0].Value.ToString();
                    NhaSanXuat pdc = nhaSanXuats.Where(p => p.MaNhaSX == ID).FirstOrDefault();
                    txtID.Text = pdc.MaNhaSX.ToString();
                    txtName.Text = pdc.TenNhaSX.ToString();
                    richTextBoxTTNSX.Text = pdc.ThongTinNhaSX.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
