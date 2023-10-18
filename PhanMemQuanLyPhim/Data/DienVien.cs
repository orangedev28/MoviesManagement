namespace PhanMemQuanLyPhim.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienVien")]
    public partial class DienVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DienVien()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(20)]
        public string MaDienVien { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDienVien { get; set; }

        public string ThongTinDienVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
