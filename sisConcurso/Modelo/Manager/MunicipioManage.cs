using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisConcurso.Modelo.Manager
{
    class MunicipioManage
    {

        public static List<municipio> BuscarporMunicipio(string valorBuscar)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.municipios.Where(r => r.mNombre.Contains(valorBuscar)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
