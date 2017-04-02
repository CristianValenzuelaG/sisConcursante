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

        private void frmRegistroCandidata_Load(object sender, EventArgs e)
        {
            this.CargarMunicipio();
        }
    }
}
