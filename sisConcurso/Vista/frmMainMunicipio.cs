using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Modelo;
using sisConcurso.Modelo.Manager;

namespace sisConcurso.Vista
{
    public partial class frmMainMunicipio : Form
    {
        public void CargarMunicipio(string Nombre)
        {
            List<municipio> nLista = new List<municipio>();
            foreach (var item in MunicipioManage.BuscarporMunicipio(Nombre))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }
        public frmMainMunicipio()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarMunicipio(txtNombre.Text);
        }

        private void frmMainMunicipio_Load(object sender, EventArgs e)
        {
            CargarMunicipio(txtNombre.Text);
            lblCantidad.Text ="Registros: "+ grDatos.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistroMunicipio nMuni = new frmRegistroMunicipio();
            nMuni.ShowDialog();
        }
    }
}
