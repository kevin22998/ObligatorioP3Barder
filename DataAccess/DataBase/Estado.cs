namespace DataAccess.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estado()
        {
            Emparejamiento = new HashSet<Emparejamiento>();
        }

        [Key]
        public long IdEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emparejamiento> Emparejamiento { get; set; }
    }
}
