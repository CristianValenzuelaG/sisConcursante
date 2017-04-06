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
        /// <summary>
        /// Funcion para buscar por candidata que esten con el status true.
        /// </summary>
        /// <param name="valorBuscar">es el valor del texbox edel nombre de la candidata</param>
        /// <param name="sStatus">Valor del status</param>
        /// <returns>Regresa una candidata</returns>
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
        /// Funcion para agregar y modificar si regresa un pk se modifica
        /// </summary>
        /// <param name="nCandidata"> devuelve el valor para registrar la candidata </param>
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

        /// <summary>
        /// Con esta funcion se da de baja una  candidata cambiando su status
        /// </summary>
        /// <param name="nCandidata">regresa los valores de la candidata</param>
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

        /// <summary>
        /// Funcion de buscar por id de la candidata
        /// </summary>
        /// <param name="pkCandidata">se resive el valor int para buscarlo</param>
        /// <returns></returns>
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

        /// <summary>
        /// metodo para buscar por id se utiliza en web
        /// </summary>
        /// <param name="pkCandidata"></param>
        /// <returns></returns>
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



        public static List<candidata> BuscarCandiFecha(String valorBuscar, int anio, Boolean sStatus, int ciudad)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cAnoComvoca.Year == anio && r.cStatus == true && r.cNombreCom.Contains(valorBuscar) && r.fkMunicipio == ciudad).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        //Para la web
        /// <summary>
        /// Metodo para Verificar los valores en la web para identificar los valores
        /// </summary>
        /// <param name="valor">Nombre</param>
        /// <param name="Status">El status</param>
        /// <param name="mun">Y el string de la candidata o bien el municipio</param>
        /// <returns>Regresa una lista de todas las candidatas</returns>
        public static List<candidata> Buscar(string valor, Boolean Status, string mun)
        {
            
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus == Status && r.cNombreCom.Contains(valor) && r.municipio.mNombre.Contains(mun)&&r.cAnoComvoca.Year==2017)
                        .OrderByDescending(r => r.cRaking)
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }     

        /// <summary>
        /// Registra el like por medio de la pk de la candidata
        /// </summary>
        /// <param name="pkCandidata">reciive el valor de la candiata</param>
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
