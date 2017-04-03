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
        /// <summary>
        /// en esta parte  mandas a llamar el metodo para poder hacer que te los muestren en pantalla 
        /// </summary>
        /// <param name="Nombre"></param>
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

        /// <summary>
        /// en este es para que cuando el campo del textbox  nombre cambie  tenga que  buscar el nombre del municipio que estas escribiendo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarMunicipio(txtNombre.Text);
        }

        /// <summary>
        /// esto es para que cargue el datagriew con los datos del  municipo de todo el registro 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainMunicipio_Load(object sender, EventArgs e)
        {
            CargarMunicipio(txtNombre.Text);
            lblCantidad.Text ="Registros: "+ grDatos.Rows.Count.ToString();
        }

        /// <summary>
        /// este es para cuando precionas el  boton agregar y  es para que te  mande al form y  puedas agregar otro municipios 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistroMunicipio nMuni = new frmRegistroMunicipio();
            nMuni.ShowDialog();
        }
    }
}
