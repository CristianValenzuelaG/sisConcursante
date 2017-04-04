using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HerramientasDatas.Modelo;

namespace siWeb.ManagerWeb
{
    public class candidataManager
    {

        public static List<candidata> Listar(string valor = "")
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus == true && r.cNombreCom.Contains(valor)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static List<candidata> BuscarporMu(Boolean valor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus ==valor).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<candidata> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cStatus == status).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}