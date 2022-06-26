namespace DataAccess.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Emparejamiento = new HashSet<Emparejamiento>();
            Fotos = new HashSet<Fotos>();
        }

        [Key]
        public long IdUsuario { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(25)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(25)]
        public string Pais { get; set; }

        [Required]
        [StringLength(25)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Salt { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emparejamiento> Emparejamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fotos> Fotos { get; set; }
    }
}
