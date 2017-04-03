namespace HerramientasData.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sisconcursante.permisosnegadosrol")]
    public partial class permisosnegadosrol
    {
        [Key]
        public int pkPermisosNegadosRol { get; set; }

        public bool bStatus { get; set; }

        public int? fkPermisos { get; set; }

        public int? fkRoles { get; set; }

        public virtual permiso permiso { get; set; }

        public virtual role role { get; set; }
    }
}
