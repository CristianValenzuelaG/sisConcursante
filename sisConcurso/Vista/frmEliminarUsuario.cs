using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerramientasDatas.Modelo;
using sisConcurso.Manager;

namespace sisConcurso.Vista
{
    public partial class frmEliminarUsuario : Form
    {
        frmMainUsuario mUsuario;//modificar
        private int pk;
        private string contra;
        private int idRol;
        public frmEliminarUsuario(frmMainUsuario musuario)
        {
            InitializeComponent();
            mUsuario = musuario;
            usuario nUsuario = UsuarioManeger.BuscarPorID(frmMainUsuario.idConw);
            pk = nUsuario.pkUsuario;
            txtCuenta.Text = nUsuario.sEmail;
            contra = nUsuario.sPassword;
            cmbRol.Items.Insert(0, "Seleccione Opcion");
            cmbRol.Items.Insert(1, "Capturista");
            cmbRol.SelectedIndex = 1;
            idRol = Convert.ToInt32(nUsuario.fkRol);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario nUsuario = new usuario();
            nUsuario.pkUsuario = pk;
            nUsuario.sEmail = txtCuenta.Text;
            nUsuario.sPassword = contra;
            nUsuario.fkRol = idRol;
            nUsuario.bStatus = false;
            UsuarioManeger.bajaUsuario(nUsuario);
            mUsuario.CargarUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
