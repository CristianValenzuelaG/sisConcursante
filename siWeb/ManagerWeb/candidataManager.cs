using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HerramientasData.Modelo;

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


        public static List<candidata> BuscarporMu(string valor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.candidatas.Where(r => r.cNombreCom ==valor).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}