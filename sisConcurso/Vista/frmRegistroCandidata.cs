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
        public static int iD_Buscar = 0;
        public static int MODIFICAR = 0;
        public static Boolean VALIDAR = true;
        public static Boolean VALIDARCandidata = true;
        List<candidata> nCandidatas = new List<candidata>();
        frmMainCandidata mCandidata;//modificar
        public void CargarMunicipio()//cargar el combobox
        {
            this.cmbMunicipio.DataSource = MunicipioManage.llenarcombo();
            this.cmbMunicipio.DisplayMember = "mNombre";
            this.cmbMunicipio.ValueMember = "pkMunicipio";
        }
        public frmRegistroCandidata()
        {
            VALIDAR = true;
            InitializeComponent();


        }
        public frmRegistroCandidata(frmMainCandidata mcandidata)
        {
            InitializeComponent();
            mCandidata = mcandidata;//modificar
            VALIDAR = false;
            VALIDARCandidata = true;

            candidata nCandidata = CandidataManage.BuscarporID(frmMainCandidata.idCon);
                txtNombre.Text = nCandidata.cNombreCom;
                txtCorreo.Text = nCandidata.cCorre;
                dtpAño.Value = nCandidata.cAnoComvoca;
                txtCurp.Text = nCandidata.cCurp;
                txtDescripcion.Text = nCandidata.cDescripcion;
                txtEstudio.Text = nCandidata.cNivelStudio;
                dtpFDN.Value = nCandidata.cFDN;
                cmbMunicipio.SelectedValue = nCandidata.fkMunicipio;
            
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
