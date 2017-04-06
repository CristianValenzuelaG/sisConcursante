using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Manager.Helpers;
using sisConcurso.Vista;

namespace sisConcurso
{
    public partial class Form1 : Form
    {
        public static UsuarioHelper uHelper;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Concurso "+ DateTime.Today.Year;
        }
        /// <summary>
        /// Esta funcion verifica los controles por medio del tag y verifica si tiene permiso para usarlo
        /// </summary>
        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = uHelper.TienePermiso(permisos);
                }
            }
        }
        private void btConcursante_Click(object sender, EventArgs e)
        {
            frmMainCandidata candi = new frmMainCandidata();
            candi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMainMunicipio muni = new frmMainMunicipio();
            muni.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (uHelper == null)
            {
                frmLogincs vLogin = new frmLogincs();
                vLogin.ShowDialog();
            }
            if (uHelper.esValido && uHelper != null)
            {
                ProcesarPermisos();

            }
            else
            {
                MessageBox.Show("Se require se autentifique", "Eror..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMainUsuario ma = new frmMainUsuario();
            ma.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmMainReportes repor = new frmMainReportes();
            repor.Show();
        }
    }
}
