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
    public partial class MainForm : Form
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<Phim> phims = new List<Phim>();
        List<TheLoai> theLoais = new List<TheLoai>();
        List<DienVien> dienViens = new List<DienVien>();
        List<DaoDien> daoDiens = new List<DaoDien>();
        List<NhaSanXuat> nhaSanXuats = new List<NhaSanXuat>();
        List<NuocSanXuat> nuocSanXuats = new List<NuocSanXuat>();

        public MainForm()
        {
            InitializeComponent();
            MainForm_Load();
        }

        void MainForm_Load()
        {
            //ptbMain.ImageLocation = "D:\\Máy cũ ổ 2\\Khang tải xuống/f1108e0990f657a80ee7.jpg"; //path to image
            ptbMain.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void moviemngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieUserControl mvControl = new MovieUserControl();
            mvControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(mvControl);
        }

        private void categorymngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryUserControl cgrControl = new CategoryUserControl();
            cgrControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(cgrControl);
        }

        private void actormngDiễnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorUserControl atControl = new ActorUserControl();
            atControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(atControl);
        }

        private void directormngĐạoDiễnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorUserControl drtControl = new DirectorUserControl();
            drtControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(drtControl);
        }

        private void producermngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProducerUserControl pdcControl = new ProducerUserControl();
            pdcControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(pdcControl);
        }

        private void countrymngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryUserControl ctControl = new CountryUserControl();
            ctControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(ctControl);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUserControl searchControl = new SearchUserControl();
            searchControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(searchControl);
        }

        private void mvreportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVRPUserControl mvrpControl = new MVRPUserControl();
            mvrpControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(mvrpControl);
        }

        private void closeappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
