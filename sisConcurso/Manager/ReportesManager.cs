using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasDatas.Modelo;

namespace sisConcurso.Manager
{
    class ReportesManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<String> getListaDepartamentos()
        {
            List<String> Deptos = new List<string>();
            try
            {
                using (var ctx = new DataModel())
                {
                    var Categoria = ctx.candidatas.GroupBy(r => r.fkMunicipio).ToList();
                    foreach (var item in Categoria)
                    {
                        Deptos.Add(item.Key.ToString());
                    }
                    Deptos.Add("TODOS");
                    return Deptos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<candidata> GetListado()
        {
            //List<> deptos = new List<string>();
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus == true).OrderByDescending(r=> r.cRaking).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            //return deptos;
        }
    }

}

