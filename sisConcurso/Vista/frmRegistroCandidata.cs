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
    public partial class frmRegistroCandidata : Form
    {
        public static int iD_Buscar = 0;
        public static int MODIFICAR = 0;
        public static Boolean VALIDAR = true;
        public static Boolean VALIDARCandidata = true;
        frmMainCandidata mCandidata;//modificar
        private int pk;
        private int rakin;
        private int idlugar;
        private int idusuario;

        //Para la foto
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }

        public void CargarMunicipio()//cargar el combobox
        {
            this.cmbMunicipio.DataSource = MunicipioManage.llenarcombo();
            this.cmbMunicipio.DisplayMember = "mNombre";
            this.cmbMunicipio.ValueMember = "pkMunicipio";
        }
        public frmRegistroCandidata()
        {
            VALIDAR = true;
            InitializeComponent();


        }
        public frmRegistroCandidata(frmMainCandidata mcandidata)
        {
            InitializeComponent();
            mCandidata = mcandidata;//modificar
            VALIDAR = false;
            VALIDARCandidata = true;

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
            rakin = Convert.ToInt32(nCandidata.cRaking);
            idusuario = Convert.ToInt32(nCandidata.fkUsuario);
            picFoto.Image = ToolImagen.Base64StringToBitmap(nCandidata.cFoto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                nCandidata.fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
                nCandidata.fkUsuario = idusuario;
                nCandidata.cFoto = ImagenString;


                CandidataManage.Guarda(nCandidata);
                mCandidata.CargarCandidata();
            }
            else
            {
                
                nCandidata.cNombreCom = txtNombre.Text;
                nCandidata.cCorre = txtCorreo.Text;
                nCandidata.cAnoComvoca = dtpAño.Value.Date;
                nCandidata.cCurp = txtCurp.Text;
                nCandidata.cDescripcion = txtDescripcion.Text;
                nCandidata.cNivelStudio = txtEstudio.Text;
                nCandidata.cFDN = dtpFDN.Value.Date;
                nCandidata.fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
                nCandidata.cRaking = 1;
                nCandidata.cFoto = ImagenString;

                CandidataManage.Guarda(nCandidata);
            }
            

            this.Close();



        }

        private void frmRegistroCandidata_Load(object sender, EventArgs e)
        {

            this.CargarMunicipio();
            //para llenar el combo con todas las camaras conectadas a la computadora

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

        private void btnTomar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                //this.picImagen.Image = null;
                this.picFoto.Image = ImagenBitmap;
                picFoto.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbDispositivo.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
            }
        }

        //Para la fotografia
        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picFoto.Image = ImagenBitmap;
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
            picFoto.Image = ImagenBitmap;
        }
    }
}
