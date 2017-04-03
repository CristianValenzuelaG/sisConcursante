using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisConcurso.Modelo.Manager
{
    class MunicipioManage
    {
        /// <summary>
        /// este es el metodo para poder buscar el municipio donde en la tabla municipio buscar el nombre de cada lista 
        /// </summary>
        /// <param name="valorBuscar"></param>
        /// <returns></returns>
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

        /// <summary>
        /// para este metodo es para poder agregar el municipio y poder modificarlo
        /// </summary>
        /// <param name="nMunicipio"></param>
        public static void Guarda(municipio nMunicipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nMunicipio.pkMunicipio > 0)
                    {
                        ctx.Entry(nMunicipio).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nMunicipio).State = EntityState.Added;
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// este  es para poder  cargar datos de la base de datos y que se cargue el combo con cada municipio  
        /// /// </summary>
        /// <returns></returns>
        public static List<municipio> llenarcombo() 
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.municipios.ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
