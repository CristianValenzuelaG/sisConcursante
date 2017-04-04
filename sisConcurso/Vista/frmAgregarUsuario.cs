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
    public partial class frmAgregarUsuario : Form
    {
        public static int iD_Buscar = 0;
        public static int MODIFICAR = 0;
        public static Boolean VALIDAR = true;
        public static Boolean VALIDARUsuario = true;
        frmMainUsuario mUsuario; //modificar
        private int pk;
        private int rakin;
        private int idlugar;
        private int idRol;

        public frmAgregarUsuario()
        {
            VALIDAR = true;
            InitializeComponent();

            cmbRol.Items.Insert(0, "Seleccione Opcion");
            cmbRol.Items.Insert(1, "Capturista");
            cmbRol.SelectedIndex = 0;
        }

        public frmAgregarUsuario(frmMainUsuario musuario)
        {
            InitializeComponent();
            mUsuario = musuario; //modificar
            VALIDAR = false;
            VALIDARUsuario = true;

            cmbRol.Items.Insert(0, "Seleccione Opcion");
            cmbRol.Items.Insert(1, "Capturista");
            usuario nUsuario = UsuarioManeger.BuscarPorID(frmMainUsuario.idConw);
            pk = nUsuario.pkUsuario;
            txtCuenta.Text = nUsuario.sEmail;
            label2.Visible = false;
            txtContra.Visible = false;
            txtContra.Text = nUsuario.sPassword;
            cmbRol.SelectedIndex = 1;
            idRol = Convert.ToInt32(nUsuario.fkRol);
            mUsuario.CargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario nUsuario = new usuario();
            if (cmbRol.SelectedIndex > 0)
            {
                if (pk > 0)
                {
                    nUsuario.pkUsuario = pk;
                    nUsuario.sEmail = txtCuenta.Text;
                    nUsuario.sPassword = txtContra.Text;
                    nUsuario.fkRol = idRol;
                    UsuarioManeger.GuardaUsuario(nUsuario);
                }
                else
                {
                    nUsuario.sEmail = txtCuenta.Text;
                    nUsuario.sPassword = txtContra.Text;
                    nUsuario.fkRol = Convert.ToInt32(cmbRol.SelectedIndex);
                    UsuarioManeger.GuardaUsuario(nUsuario);
                    mUsuario.CargarUsuarios();
                    
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor de Seleccionar un Rol", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
