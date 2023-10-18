namespace PhanMemQuanLyPhim.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [Key]
        [StringLength(20)]
        public string MaPhim { get; set; }

        [Required]
        public string TenPhim { get; set; }

        [Required]
        [StringLength(20)]
        public string ThoiLuong { get; set; }

        [Required]
        [StringLength(50)]
        public string GioiHanTuoi { get; set; }

        [Required]
        public string NoiDungChinh { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTheLoai { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDienVien { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDaoDien { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNhaSX { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNuocSX { get; set; }

        public virtual DaoDien DaoDien { get; set; }

        public virtual DienVien DienVien { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }

        public virtual NuocSanXuat NuocSanXuat { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
