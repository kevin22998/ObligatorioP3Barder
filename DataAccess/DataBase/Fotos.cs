namespace DataAccess.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fotos
    {
        [Key]
        public long IdFoto { get; set; }

        public long UsuarioId { get; set; }

        [Required]
        [StringLength(256)]
        public string RutaFoto { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
