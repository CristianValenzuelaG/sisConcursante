namespace Herramientas_de_conexion.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sisconcursante.municipios")]
    public partial class municipio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public municipio()
        {
            candidatas = new HashSet<candidata>();
        }

        [Key]
        public int pkMunicipio { get; set; }

        [Required]
        [StringLength(45)]
        public string mNombre { get; set; }

        [StringLength(1073741823)]
        public string mLogotipo { get; set; }

        [Required]
        [StringLength(180)]
        public string mDescripion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidata> candidatas { get; set; }
    }
}
