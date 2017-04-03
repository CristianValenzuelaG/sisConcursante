namespace HerramientasData.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sisconcursante.candidatas")]
    public partial class candidata
    {
        [Key]
        public int pkCandidata { get; set; }

        [Required]
        [StringLength(45)]
        public string cNombreCom { get; set; }

        [Column(TypeName = "date")]
        public DateTime cFDN { get; set; }

        [Required]
        [StringLength(180)]
        public string cDescripcion { get; set; }

        [Required]
        [StringLength(45)]
        public string cCorre { get; set; }

        [Required]
        [StringLength(45)]
        public string cCurp { get; set; }

        [Required]
        [StringLength(45)]
        public string cNivelStudio { get; set; }

        [StringLength(1073741823)]
        public string cFoto { get; set; }

        [Column(TypeName = "date")]
        public DateTime cAnoComvoca { get; set; }

        public bool cStatus { get; set; }

        public int? fkMunicipio { get; set; }

        public int? fkUsuario { get; set; }

        public int? cRaking { get; set; }

        public virtual municipio municipio { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
