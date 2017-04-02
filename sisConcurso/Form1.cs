using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Vista;

namespace sisConcurso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Concurso "+ DateTime.Today.Year;
        }

        private void btConcursante_Click(object sender, EventArgs e)
        {
            frmMainCandidata candi = new frmMainCandidata();
            candi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMainMunicipio muni = new frmMainMunicipio();
            muni.Show();
        }
    }
}
