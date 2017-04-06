using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Reporte;

namespace sisConcurso.Vista
{
    public partial class frmMainReportes : Form
    {
        public frmMainReportes()
        {
            InitializeComponent();

        }
        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = Form1.uHelper.TienePermiso(permisos);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmCandidataconmasaltapuntuacion nueva = new frmCandidataconmasaltapuntuacion();
            nueva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCandidataxConvocatoria nuev = new frmCandidataxConvocatoria();
            nuev.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCandidataMunicipio  muni = new frmCandidataMunicipio();
            muni.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCandidataxCaptu captu = new frmCandidataxCaptu();
            captu.Show();
        }

        private void frmMainReportes_Load(object sender, EventArgs e)
        {
            ProcesarPermisos();
        }
    }
}
