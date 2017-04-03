namespace Herramientas_de_conexion.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sisconcursante.usuarios")]
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            candidatas = new HashSet<candidata>();
        }

        [Key]
        public int pkUsuario { get; set; }

        [Required]
        [StringLength(45)]
        public string sEmail { get; set; }

        [Required]
        [StringLength(45)]
        public string sPassword { get; set; }

        public bool bStatus { get; set; }

        public int? fkRol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidata> candidatas { get; set; }

        public virtual role role { get; set; }
    }
}
