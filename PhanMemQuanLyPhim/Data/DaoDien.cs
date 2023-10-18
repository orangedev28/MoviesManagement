namespace PhanMemQuanLyPhim.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaoDien")]
    public partial class DaoDien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaoDien()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(20)]
        public string MaDaoDien { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDaoDien { get; set; }

        public string ThongTinDaoDien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
