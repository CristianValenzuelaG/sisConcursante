using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerramientasDatas.Modelo;
using sisConcurso.Manager;

namespace sisConcurso.Vista
{
    public partial class frmMainUsuario : Form
    {
        public static int idConw;
        public void CargarUsuarios()
        {
            List<usuario> nLista = new List<usuario>();
            foreach (var item in UsuarioManeger.BuscarEmail(txtNombre.Text, checkBox1.Checked))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }
        public frmMainUsuario()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMainUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario nue = new frmAgregarUsuario();
            nue.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grDatos.SelectedCells.Count > 0)
            {
                idConw = Convert.ToInt32(grDatos.CurrentRow.Cells["pkUsuario"].Value);
                frmAgregarUsuario f = new frmAgregarUsuario(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grDatos.SelectedCells.Count > 0)
            {
                idConw = Convert.ToInt32(this.grDatos.CurrentRow.Cells["pkUsuario"].Value);
                frmEliminarUsuario f = new frmEliminarUsuario(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }
    }
}
