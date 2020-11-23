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

        Image<Bgr, byte> imgInput;
        int[,] matrizImagen;

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
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = imgInput.ToBitmap();
            }
        }

        private void detectarBordeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            detectarBorde();

        }
        #region DetectarBorde
        private void detectarBorde()
        {
            Image<Gray, byte> imgOutput = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();

            Image<Gray, byte> imgout = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));

            CvInvoke.FindContours(imgOutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            CvInvoke.DrawContours(imgout, contours, -1, new MCvScalar(255, 255,255));

            pictureBox2.Image = imgout.Bitmap;
        }
        #endregion

        private void detectarCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detectarBorde();

        }


        private void detectarCentro()
        {

        }
    }
}
