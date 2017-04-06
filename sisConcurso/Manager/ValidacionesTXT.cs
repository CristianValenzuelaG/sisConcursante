using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisConcurso.Manager
{
    public class ValidacionesTXT
    {
        /// <summary>
        /// Funcion para validar la curp 
        /// </summary>
        /// <param name="curp">Valor del texbox para el registro de la curp</param>
        /// <returns>Regresaa un error si no tiene el formato correcto</returns>
        public static bool ValidarCurp(string curp)
        {
            string expresion = "^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$";
            if (Regex.IsMatch(curp, expresion))
            {
                if (Regex.Replace(curp, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// esta funcion sirve para  saber los caracteres que necesita  un gmail
        /// </summary>
        /// <param name="email"> mandas el valor para que verifique que  caracteres o signos tiene </param>
        /// <returns> la expresion te valida que puedas usar los . lo , los @ dependiento del gmail</returns>
        public static bool ValidarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// esta funcion  te valida que nomas te permita las letras y que no  dejes entrar numeros
        /// </summary>
        /// <param name="e">este valor te  manda  el dato que introdusiste para verificarlo que sea pura letra  </param>
        public void SoloLetra(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {


            }
        }

        /// <summary>
        /// en esta funcion te permite que introduscas dolo numeros 
        /// </summary>
        /// <param name="e">en esta  dato te madna el valor para saber si tiene un caracteres y te  los denegue</param>
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}

