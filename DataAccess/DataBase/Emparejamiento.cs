namespace DataAccess.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emparejamiento")]
    public partial class Emparejamiento
    {
        [Key]
        public long IdEmparejamiento { get; set; }

        public long UsuarioId { get; set; }

        public long IdPeleadorElegido { get; set; }

        [StringLength(25)]
        public string Ganador { get; set; }

        public long Estado { get; set; }

        public virtual Estado Estado1 { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
