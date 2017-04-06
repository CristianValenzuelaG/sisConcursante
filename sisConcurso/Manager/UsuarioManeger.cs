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
        /// <summary>
        /// Funcion para la autenticacion de un usuario
        /// </summary>
        /// <param name="sUsuario">Regresa un strin del email registrado</param>
        /// <param name="sPassword">Regresa la contraseña</param>
        /// <returns>Regresa un true si se presenta el registro</returns>
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

        /// <summary>
        /// Metodo para buscar por email del usuario
        /// </summary>
        /// <param name="Email">String del email mandado desde el texbox</param>
        /// <returns>Regresa un usuario con los datos mandados</returns>
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

        /// <summary>
        /// Metodo para verificar los datos para registrar un nuevo usuario
        /// </summary>
        /// <param name="nUsuario">Manda los datos del usuario a registrar</param>
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

        /// <summary>
        /// buscar por id del usuario 
        /// </summary>
        /// <param name="Id">dato del pk del usuario</param>
        /// <returns>regresa un registro de un usuario dependiendo el id mandado</returns>
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

        /// <summary>
        /// Se manda  los datos para dar baja al usuario
        /// </summary>
        /// <param name="nUsuario">Regresa para dar debaja al usuario con todos los datos</param>
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
