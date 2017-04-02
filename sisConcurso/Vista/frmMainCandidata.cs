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
       
        private void frmMainCandidata_Load(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.CargarCandidata(txtNombre.Text);
        }
    }
}
