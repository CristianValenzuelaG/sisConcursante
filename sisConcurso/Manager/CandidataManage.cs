using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasDatas.Modelo;


namespace sisConcurso.Manager
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

        public static void bajaCandidata(candidata nCandidata)
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
                        
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static candidata BuscarporID(int pkCandidata)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.pkCandidata == pkCandidata).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<candidata> BuscarporIDLi(int pkCandidata)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.pkCandidata == pkCandidata).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        //Para la web
        public static List<candidata> Buscar(string valor, Boolean Status, string mun)
        {
            
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus == Status && r.cNombreCom.Contains(valor) && r.municipio.mNombre.Contains(mun))
                        .OrderByDescending(r => r.cRaking)
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }     
        public static void Like(int pkCandidata)
        {
           candidata nCandidata = CandidataManage.BuscarporID(pkCandidata);
            try
            {
                using (var ctx = new DataModel())
                {
                    int likes = Convert.ToInt32(nCandidata.cRaking);
                    int like = 1;
                    likes += like;

                    nCandidata.cRaking = likes;
                    ctx.candidatas.Attach(nCandidata);
                    ctx.Entry(nCandidata).State = EntityState.Modified;
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
