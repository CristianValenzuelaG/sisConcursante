﻿using System;
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
    public partial class frmMainMunicipio : Form
    {
        public static int idMun;
        public void CargarMunicipio()
        {
            List<municipio> nLista = new List<municipio>();
            foreach (var item in MunicipioManage.BuscarporMunicipio(txtNombre.Text))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
            lblCantidad.Text = "Registros: " + grDatos.Rows.Count.ToString();
        }
        public frmMainMunicipio()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarMunicipio();
        }

        private void frmMainMunicipio_Load(object sender, EventArgs e)
        {
            CargarMunicipio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistroMunicipio nMuni = new frmRegistroMunicipio();
            nMuni.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grDatos.SelectedCells.Count > 0)
            {
                idMun = Convert.ToInt32(this.grDatos.CurrentRow.Cells["pkMunicipio"].Value);
                frmRegistroMunicipio f = new frmRegistroMunicipio(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay elementos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult me = MessageBox.Show("Esta a punto de borra un municipio esta segur@ que quiere hacerlo ? ",
                "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (me == DialogResult.OK)
            {
                if (grDatos.SelectedCells.Count > 0)
                {
                    MunicipioManage deli = new MunicipioManage();
                    deli.eliminar(Convert.ToInt32(this.grDatos.CurrentRow.Cells["pkMunicipio"].Value));
                }
                else
                {
                    MessageBox.Show("Error no a seleccionado ningun municipio", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
            this.CargarMunicipio();

        }
    }
}
