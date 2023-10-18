using Microsoft.Reporting.WinForms;
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
    public partial class MVRPUserControl : UserControl
    {
        MovieDbContext dbContext = new MovieDbContext();
        List<Phim> phims = new List<Phim>();
        List<MovieReport> movieReports = new List<MovieReport>();

        public MVRPUserControl()
        {
            InitializeComponent();
            MVRPUserControl_Load();
        }

        void MVRPUserControl_Load()
        {
            phims = dbContext.Phims.ToList();
            foreach (Phim i in phims)
            {
                MovieReport temp = new MovieReport();
                temp.MaPhim = i.MaPhim;
                temp.TenPhim = i.TenPhim;
                temp.ThoiLuong = i.ThoiLuong;
                temp.GioiHanTuoi = i.GioiHanTuoi;
                temp.NoiDungChinh = i.NoiDungChinh;
                temp.TenTheLoai = i.TheLoai.TenTheLoai;
                temp.TenDienVien = i.DienVien.TenDienVien;
                temp.TenDaoDien = i.DaoDien.TenDaoDien;
                temp.TenNhaSX = i.NhaSanXuat.TenNhaSX;
                temp.TenNuocSX = i.NuocSanXuat.TenNuocSX;
                movieReports.Add(temp);
            }

            this.reportViewer1.LocalReport.ReportPath = "..\\..\\MovieReport.rdlc";
            ReportParameter reportParameter = new ReportParameter("ReportParameter1", String.Format("Tổng số phim: {0}", phims.Count()));
            reportViewer1.Dock = DockStyle.Fill; // them 2 hang nay full screen
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            
            var reportDataSource = new ReportDataSource("MovieDataSet", movieReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
