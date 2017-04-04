using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HerramientasDatas.Modelo;

namespace sisConcurso.Manager.Helpers
{
    public class UsuarioHelper
    {
        public usuario usuario { get; set; }
        public Boolean esValido { get; set; }
        public String sMensaje { get; set; }

        public Boolean TienePermiso(int idPermiso)
        {
            Boolean tiene = true;
            foreach (permisosnegadosrol item in usuario.role.permisosnegadosrols)
            {
                if (item.permiso.pkPermiso == idPermiso)
                {
                    tiene = false;
                    break;
                }
            }
            return tiene;
        }

        public UsuarioHelper()
        {
            this.usuario = null;
            this.esValido = false;
            this.sMensaje = "Datos incorrectos";
        }
    }
}
