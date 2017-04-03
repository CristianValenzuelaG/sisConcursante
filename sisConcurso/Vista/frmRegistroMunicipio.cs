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
using HerramientasData.Modelo;
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
            nMunicipio.mLogotipo = ImagenString;

            MunicipioManage.Guarda(nMunicipio);
            
            }
            this.Close();
        }

        private void frmRegistroMunicipio_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                cmbDispositivo.Items.Add(device.Name);
            }
            if (cmbDispositivo.Items.Count > 0)
            {
                cmbDispositivo.SelectedIndex = 0;
                videoSource = new VideoCaptureDevice();
            }
            else
            { 
                btnTomar.Enabled = false;
            }
        }


        //Para la fotografia
        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picCamara.Image = ImagenBitmap;
        }

        public void FinalizarControles()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }
        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picCamara.Image = ImagenBitmap;
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                //this.picImagen.Image = null;
                this.picCamara.Image = ImagenBitmap;
                picCamara.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbDispositivo.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
            }
        }
    }
}
