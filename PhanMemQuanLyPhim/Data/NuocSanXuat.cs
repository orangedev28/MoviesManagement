namespace PhanMemQuanLyPhim.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NuocSanXuat")]
    public partial class NuocSanXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NuocSanXuat()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(20)]
        public string MaNuocSX { get; set; }

        [Required]
        [StringLength(200)]
        public string TenNuocSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
