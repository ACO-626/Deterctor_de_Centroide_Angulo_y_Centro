using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Deterctor_de_Contornos
{
    public partial class FormPrincipal : Form
    {
        //Imagen original en color
        Image<Bgr, byte> img;
        //Matriz que almacena 0 y 1 dependiendo del color de la imagen de contornos binarizada
        int[,] matrizImagen;
        //Imagen binarizada
        Image<Gray, byte> GrayImg;
        //Imagen que se muestra
        Image<Gray, byte> imgout;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = img.ToBitmap();
            }
        }


        #region DetectarBorde
        private void detectarBorde()
        {
            
                if(img!=null)
                {
                    GrayImg = img.Convert<Gray, byte>().ThresholdBinary(new Gray((int)numericBorde1.Value), new Gray((int)numericBorde2.Value));
                    Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                    Mat hier = new Mat();

                    imgout = new Image<Gray, byte>(img.Width, img.Height, new Gray(0));

                    CvInvoke.FindContours(GrayImg, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                    CvInvoke.DrawContours(imgout, contours, -1, new MCvScalar(255, 255, 255));

                    pictureBox2.Image = imgout.Bitmap;
                }else
                {
                    MessageBox.Show("Debe cargar una imagen antes de buscar el borde", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
     
        }

        //Botón
        private void btnBorde_Click(object sender, EventArgs e)
        {
            detectarBorde();
        }
        //Borde en Menú
        private void detectarBordeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            detectarBorde();

        }

        #endregion

        #region menuDetectarCentros
        private void detectarCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(img!=null)
            {
                if (imgout != null)
                {
                    detectarCentro();
                }
                else
                {
                    detectarBorde();
                    detectarCentro();
                }
            }else
            {
                MessageBox.Show("Debe cargar una imagen antes de buscar el borde", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }
        #endregion

        #region detectarCentro
        private void detectarCentro()
        {
            matrizImagen = new int[img.Height, img.Width];
            

            if (img!=null)
            {
                for(int i = 0;i<img.Height;i++)
                {
                    for(int j=0;j<img.Width;j++)
                    {
                        if (imgout[i, j].Intensity == 0)
                        {
                            matrizImagen[i, j] = 0;
                        }
                                                        
                        
                    }
                }
            }

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {

                    imgout[i, j] = new Gray(0);

                }
            }
            CvInvoke.DrawContours(imgout, contours, 0, new MCvScalar(255, 255, 255));
            CvInvoke.cvGetCentralMoment();
            //Representación del contenido de la matriz
            /*for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (matrizImagen[i,j]==0)
                    {
                        imgout[i, j] = new Gray(0);
                    }else
                    {
                        imgout[i, j] = new Gray(255);
                    }

                }
            }*/
            pictureBox2.Image = imgout.Bitmap;

        }
        #endregion

        #region ContarObjetos
        private void button4_Click(object sender, EventArgs e)
        {   
            if(imgout!=null)
            {
                contarObjetos();
            }
            else
            {
                if(img!=null)
                {
                    detectarBorde();
                    contarObjetos();
                }else
                {
                    MessageBox.Show("Debe cargar una imagen antes de buscar el borde", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            
        }

        private void contarObjetos()
        {
            int contador=0;
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            //lbNumObj.Text = "Número de objetos: " + contours.Size.ToString();
            for(int i=0;i<contours.Size;i++)
            {
                var area = CvInvoke.ContourArea(contours[i]);
                if(area>(int)numericSenCount.Value)
                {
                    contador++;
                }
                   
            }
            lbNumObj.Text = "Número de objetos: " + contador.ToString();
            //findContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_EXTERNAL);
        }

        #endregion

        private void btnCentros_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                if (imgout != null)
                {
                    detectarCentro();
                }
                else
                {
                    detectarBorde();
                    detectarCentro();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar una imagen antes de buscar el borde", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
