namespace sisConcurso.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sisconcursante.permisos")]
    public partial class permiso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public permiso()
        {
            permisosnegadosrols = new HashSet<permisosnegadosrol>();
        }

        [Key]
        public int pkPermiso { get; set; }

        [Required]
        [StringLength(45)]
        public string sModulo { get; set; }

        [StringLength(100)]
        public string sDescripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permisosnegadosrol> permisosnegadosrols { get; set; }
    }
}
