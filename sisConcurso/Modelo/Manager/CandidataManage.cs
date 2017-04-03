using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisConcurso.Modelo.Manager
{
    public class CandidataManage
    {
        /// <summary>
        /// para este es para poder buscar el nombre  de la candidata ya que lo busca de la base de datos con el contexto mandas la base de  datos donde el Nombre  que contenga en la base de datos  dependiendo del estatus este activo 
        /// </summary>
        /// <param name="valorBuscar"></param>
        /// <param name="sStatus"></param>
        /// <returns></returns>
        public static List<candidata> BuscarNombreCandidata(string valorBuscar, Boolean sStatus)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cNombreCom.Contains(valorBuscar) && r.cStatus == sStatus).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///    en esta es para poder guardad los datos  de la candidata y tambien poderlos modificar  con el contexto  
        /// </summary>
        /// <param name="nCandidata"></param>
        public static void Guarda(candidata nCandidata)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nCandidata.pkCandidata > 0)
                    {
                        ctx.Entry(nCandidata).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nCandidata).State = EntityState.Added;
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
