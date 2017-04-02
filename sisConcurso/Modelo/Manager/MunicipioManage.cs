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

        public void eliminar(int pkMunicipio)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    municipio muni = ctx.municipios.Single(r => r.pkMunicipio == pkMunicipio);
                    ctx.Entry(muni).State = EntityState.Deleted;
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
