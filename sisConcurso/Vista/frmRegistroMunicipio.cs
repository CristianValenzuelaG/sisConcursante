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
        public static int iD_Buscar = 0;
        public static int MODIFICAR = 0;
        public static Boolean VALIDAR = true;
        public static Boolean VALIDARMunicipio = true;
        frmMainMunicipio mMunicipio;//modificar
        private int pk;


        public frmRegistroMunicipio( )
        {
            InitializeComponent();
            VALIDAR = true;
        }
        public frmRegistroMunicipio(frmMainMunicipio mmunicipio)
        {
            InitializeComponent();
            mMunicipio = mmunicipio;//modificar
            VALIDAR = false;
            VALIDARMunicipio = true;

            municipio nMunicipio =MunicipioManage.BuscarporIDM(frmMainMunicipio.idMun);
            pk = nMunicipio.pkMunicipio;
            txtNombre.Text = nMunicipio.mNombre;
            txtDescripcion.Text = nMunicipio.mDescripion; 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            municipio nMunicipio = new municipio();
            if (pk > 0)
            {
                nMunicipio.pkMunicipio = pk;
                nMunicipio.mNombre = txtNombre.Text;
                nMunicipio.mDescripion = txtDescripcion.Text;

                MunicipioManage.Guarda(nMunicipio);
                mMunicipio.CargarMunicipio();
            }
            else
            {
            nMunicipio.mNombre = txtNombre.Text;
            nMunicipio.mDescripion = txtDescripcion.Text;

            MunicipioManage.Guarda(nMunicipio);
            
            }
            this.Close();
        }
    }
}
