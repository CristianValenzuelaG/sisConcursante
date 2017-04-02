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
        public static int idCon;
        public void CargarCandidata()
        {
            List<candidata> nLista = new List<candidata>();
            foreach (var item in CandidataManage.BuscarNombreCandidata(txtNombre.Text, chkStatus.Checked))
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
            this.CargarCandidata();
           
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.CargarCandidata();
        }
        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.CargarCandidata();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistroCandidata nue = new frmRegistroCandidata();
            nue.ShowDialog();
        }

        //private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (grdDatos.SelectedCells.Count > 0)
        //    {
        //        int selectedrowindex = grdDatos.SelectedCells[0].RowIndex;

        //        DataGridViewRow selectedRow = grdDatos.Rows[selectedrowindex];

        //         idCon = Convert.ToInt32(selectedRow.Cells["pkCandidata"].Value);

        //        frmRegistroCandidata f = new frmRegistroCandidata(this);
        //        f.ShowDialog();

        //        //this.Close();


        //    }
        //    else { MessageBox.Show("No hay elementos");}
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.SelectedCells.Count > 0)
            {
                idCon = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["pkCandidata"].Value);
                frmEliminarCandidata f = new frmEliminarCandidata(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdDatos.SelectedCells.Count > 0)
            {
                idCon = Convert.ToInt32(this.grdDatos.CurrentRow.Cells["pkCandidata"].Value);
                frmRegistroCandidata f = new frmRegistroCandidata(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }
    }
}
