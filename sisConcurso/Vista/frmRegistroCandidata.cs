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
    public partial class frmRegistroCandidata : Form
    {
        /// <summary>
        /// para este  te  ayuda a que cuando agregues el combo este con los datos de los con los municipios que ya esten en la base e datos 
        /// </summary>
        public void CargarMunicipio()//cargar el combobox
        {
            this.cmbMunicipio.DataSource = MunicipioManage.llenarcombo();
            this.cmbMunicipio.DisplayMember = "mNombre";
            this.cmbMunicipio.ValueMember = "pkMunicipio";
        }
        public frmRegistroCandidata()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// aqui mandas los datos que esten en  los campos del form para que los mandes a guardar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            candidata nCandidata = new candidata();

            nCandidata.cNombreCom = txtNombre.Text;
            nCandidata.cCorre = txtCorreo.Text;
            nCandidata.cAnoComvoca = dtpAño.Value.Date;
            nCandidata.cCurp = txtCurp.Text;
            nCandidata.cDescripcion = txtDescripcion.Text;
            nCandidata.cNivelStudio = txtEstudio.Text;
            nCandidata.cFDN = dtpFDN.Value.Date;
            nCandidata.fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);

            CandidataManage.Guarda(nCandidata);

        }

        /// <summary>
        /// en este  es para que en el momento    en el     que cargue  el romulario se   cargue el combo con todos los municipios 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistroCandidata_Load(object sender, EventArgs e)
        {
            this.CargarMunicipio();
        }
    }
}
