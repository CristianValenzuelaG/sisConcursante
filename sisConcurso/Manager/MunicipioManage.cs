using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasDatas.Modelo;

namespace sisConcurso.Manager
{
    public class MunicipioManage
    {
        /// <summary>
        /// Metodo para buscar por municipio regresando una lista
        /// </summary>
        /// <param name="valorBuscar">se manda el nombre del municipio</param>
        /// <returns>Regresa los valores de la lista de municipio</returns>
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
        /// Metodo para guardar y modificar un municipio
        /// </summary>
        /// <param name="nMunicipio">Se manda los datos del municipio</param>
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
        /// Funcion para llenar el combo de los municipios
        /// </summary>
        /// <returns>Regresa una lista de municipios para llenar un combobox</returns>
        public static List<municipio> llenarcombo() // cargar datos de la base de datos 
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

        /// <summary>
        /// Metodo para buscar por id Municipio
        /// </summary>
        /// <param name="pkMunicipio">Se envia el id del munipio</param>
        /// <returns>Regresa el registro de un municipio por el pk mandado</returns>
        public static municipio BuscarporIDM(int pkMunicipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.municipios.Where(r => r.pkMunicipio == pkMunicipio).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Funcion para eliminar un registro de municipio dependiendo el id mandado
        /// </summary>
        /// <param name="pkMunicipio">Id del municipio a borrar</param>
        public void eliminar(int pkMunicipios)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    municipio muni = ctx.municipios.Single(r => r.pkMunicipio == pkMunicipios);
                  
                    ctx.Entry(muni).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// obtiene todos los datos del municipio
        /// </summary>
        /// <returns>regresa una lista de todos los municipios</returns>
        public static List<municipio> getAll()
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
