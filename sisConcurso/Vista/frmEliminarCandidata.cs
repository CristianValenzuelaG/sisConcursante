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
    public partial class frmEliminarCandidata : Form
    {
        frmMainCandidata mCandidata;//modificar
        private int pk;
        private string rakin;
        private int idlugar;
        private int idusuario;
        public frmEliminarCandidata(frmMainCandidata mcandidata)
        {
            InitializeComponent();
            mCandidata = mcandidata;
            candidata nCandidata = CandidataManage.BuscarporID(frmMainCandidata.idCon);
            pk = nCandidata.pkCandidata;
            txtNombre.Text = nCandidata.cNombreCom;
            txtCorreo.Text = nCandidata.cCorre;
            dtpAño.Value = nCandidata.cAnoComvoca;
            txtCurp.Text = nCandidata.cCurp;
            txtDescripcion.Text = nCandidata.cDescripcion;
            txtEstudio.Text = nCandidata.cNivelStudio;
            dtpFDN.Value = nCandidata.cFDN;
            idlugar = Convert.ToInt32(nCandidata.fkMunicipio);
            rakin = nCandidata.cRaking.ToString();
            idusuario = Convert.ToInt32(nCandidata.fkUsuario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            candidata nCandidata = new candidata();
            if (pk > 0)
            {
                nCandidata.pkCandidata = pk;
                nCandidata.cNombreCom = txtNombre.Text;
                nCandidata.cCorre = txtCorreo.Text;
                nCandidata.cAnoComvoca = dtpAño.Value.Date;
                nCandidata.cCurp = txtCurp.Text;
                nCandidata.cDescripcion = txtDescripcion.Text;
                nCandidata.cNivelStudio = txtEstudio.Text;
                nCandidata.cFDN = dtpFDN.Value.Date;
                nCandidata.cRaking = Convert.ToInt32(rakin);
                nCandidata.fkMunicipio = idlugar;
                nCandidata.fkUsuario = idusuario;

                nCandidata.cStatus = false;
                CandidataManage.bajaCandidata(nCandidata);
                mCandidata.CargarCandidata();
            }
            else
            {
            }
            
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
