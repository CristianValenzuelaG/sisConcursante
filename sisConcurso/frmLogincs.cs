using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Manager;
using sisConcurso.Manager.Helpers;

namespace sisConcurso
{
    public partial class frmLogincs : Form
    {
        UsuarioHelper uHelper;
        public frmLogincs()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            uHelper = UsuarioManeger.Autentificar(txtUsuario.Text,
               txtPassword.Text);
            if (uHelper.esValido)
            {
                Form1.uHelper = uHelper;
                this.Close();

            }
            else
            {
                MessageBox.Show(uHelper.sMensaje, "Autentificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTXT va = new ValidacionesTXT();
            va.SoloNumeros(e);
        }
    }
}
