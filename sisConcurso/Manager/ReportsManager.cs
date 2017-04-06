using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasDatas.Modelo;

namespace sisConcurso.Manager
{
    class ReportsManager
    {
        public static List<candidata> reporteCandidataXMunicipio(int pkMucipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return
                        (from r in
                            ctx.candidatas.Include("municipio")
                                .Include("usuario")
                                .Where(r => r.municipio.pkMunicipio == pkMucipio)
                                .ToList()
                            select new candidata
                            {
                                pkCandidata = r.pkCandidata,
                                cNombreCom = r.cNombreCom,
                                cCorre = r.cCorre,
                                cAnoComvoca = r.cAnoComvoca,
                                cDescripcion = r.cDescripcion
                            }).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        } 
    }
}
