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
