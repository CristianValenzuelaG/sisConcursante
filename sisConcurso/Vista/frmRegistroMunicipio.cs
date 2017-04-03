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
    public partial class frmRegistroMunicipio : Form
    {
        public frmRegistroMunicipio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  aqui mandas  a llamar todos los  valores que tienes en los textbox para guardarlos en la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            municipio nMunicipio = new municipio();
            nMunicipio.mNombre = txtNombre.Text;
            nMunicipio.mDescripion = txtDescripcion.Text;

            MunicipioManage.Guarda(nMunicipio);
            this.Close();
        }
    }
}
