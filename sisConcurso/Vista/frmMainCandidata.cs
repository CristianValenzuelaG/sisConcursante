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
    public partial class frmMainCandidata : Form
    {
        /// <summary>
        /// Cargar candidatas 
        /// </summary>
        /// <param name="Nombre">para este parte del codigo te muestra  todas las candidatas  este  es el  metodo  que se utiliza para mostrar a pantalla </param>
        public void CargarCandidata(string Nombre)
        {
            List<candidata> nLista = new List<candidata>();
            foreach (var item in CandidataManage.BuscarNombreCandidata(Nombre, chkStatus.Checked))
            {
                nLista.Add(item);
            }
            this.grdDatos.DataSource = nLista;
        }
        public frmMainCandidata()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }
       
        /// <summary>
        ///   cargar el nombre de las candidatas  para madartelo a pantalla en el datagriew 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainCandidata_Load(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
           
        }
        /// <summary>
        /// este parte el codigo ya lo sabe profe para que es no hay necesidad que que se lo explique 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///  esto espara cuando  el campo txtNombre cambia y  puedas buscar  el nombre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
        }

        /// <summary>
        /// esta parte es para cuando seleccionas el checkbox y buscsas los que tengan el estatus  activo o inactivo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
        }

        /// <summary>
        /// en esta mandas a llamar el formulario para poder agregar una candidata 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistroCandidata nue = new frmRegistroCandidata();
            nue.ShowDialog();
        }
    }
}
