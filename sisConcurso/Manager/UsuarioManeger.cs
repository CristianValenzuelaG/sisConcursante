using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasDatas.Modelo;
using sisConcurso.Manager.Helpers;

namespace sisConcurso.Manager
{
    class UsuarioManeger
    {
        public static UsuarioHelper Autentificar(String sUsuario, String sPassword)
        {
            UsuarioHelper uHelper = new UsuarioHelper();
            usuario user = BuscarPorEmail(sUsuario);
            if (user != null)
            {
                if (user.sPassword == LoginTool.GetMD5(sPassword))
                {
                    uHelper.usuario = user;
                    uHelper.esValido = true;
                  
                }
                else
                {
                    uHelper.sMensaje = "Datos Incorrectos";
                }
            }
            return uHelper;
        }
        private static usuario BuscarPorEmail(string Email)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Include("role")
                        .Include("role.permisosnegadosrols")
                        .Include("role.permisosnegadosrols.permiso")
                        .Where(r => r.sEmail == Email).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void RegistrarNuevoUsuario(usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.usuarios.Add(nUsuario);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Con esta funcion se reaalize la busqueda por email
        /// </summary>
        /// <param name="valorBuscar">se manda el email</param>
        /// <param name="sStatus">se verifica si el usuario esta activo</param>
        /// <returns></returns>
        public static List<usuario> BuscarEmail(string valorBuscar, Boolean sStatus)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.sEmail.Contains(valorBuscar) && r.bStatus == sStatus).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GuardaUsuario(usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nUsuario.pkUsuario > 0)
                    {
                        ctx.Entry(nUsuario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nUsuario).State = EntityState.Added;
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static usuario BuscarPorID(int Id)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios
                        .Where(r => r.pkUsuario == Id)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void bajaUsuario(usuario nUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nUsuario.pkUsuario > 0)
                    {
                        ctx.Entry(nUsuario).State = EntityState.Modified;
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
    }

}
