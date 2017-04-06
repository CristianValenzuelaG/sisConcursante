using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using HerramientasDatas.Modelo;
using sisConcurso.Manager;
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

        //Para la foto
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }

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

            municipio nMunicipio = MunicipioManage.BuscarporIDM(frmMainMunicipio.idMun);
            pk = nMunicipio.pkMunicipio;
            txtNombre.Text = nMunicipio.mNombre;
            txtDescripcion.Text = nMunicipio.mDescripion;
            picCamara.Image = ToolImagen.Base64StringToBitmap(nMunicipio.mLogotipo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            municipio nMunicipio = new municipio();
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || picCamara.Image == null)
            {
                MessageBox.Show("Error Faltan datos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
                if (pk > 0)
                {
                    nMunicipio.pkMunicipio = pk;
                    nMunicipio.mNombre = txtNombre.Text;
                    nMunicipio.mDescripion = txtDescripcion.Text;
                    nMunicipio.mLogotipo = ImagenString;


                    MunicipioManage.Guarda(nMunicipio);
                    mMunicipio.CargarMunicipio();
                }
                else
                {
                    nMunicipio.mNombre = txtNombre.Text;
                    nMunicipio.mDescripion = txtDescripcion.Text;
                    nMunicipio.mLogotipo = ImagenString;

                    MunicipioManage.Guarda(nMunicipio);

                }
                this.Close();
            }
        }

        private void frmRegistroMunicipio_Load(object sender, EventArgs e)
        {
            
        }


        //Para la fotografia
       
     
        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picCamara.Image = ImagenBitmap;
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*gif;*.bmp";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    string logo = BuscarImagen.FileName;
                    this.picCamara.ImageLocation = logo;
                    ImagenBitmap = new System.Drawing.Bitmap(logo);
                    ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
                    picCamara.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTXT va = new ValidacionesTXT();
            va.SoloLetra(e);
        }
    }
}
