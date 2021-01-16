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

        //Graficos
        Graphics papel;
        Pen pluma = new Pen(Color.DarkGreen);


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


            }
            else
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

        #region detectarCentroide
        private void detectarCentro()
        {
            matrizImagen = new int[img.Height, img.Width];
            

            /*if (img!=null)
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
            }*/

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            
            for (int x=0;x<contours.Size;x++)
            {
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {

                        imgout[i, j] = new Gray(0);

                    }
                }
                var area = CvInvoke.ContourArea(contours[x]);
                if (area > (int)numericSenCount.Value)
                {
                    CvInvoke.DrawContours(imgout, contours, x, new MCvScalar(255, 255, 255));
                    MCvMoments moments = CvInvoke.Moments(imgout.Mat, false);
                    Point centroide = new Point((int)(moments.M10 / moments.M00), (int)(moments.M01 / moments.M00));
                    
                    papel = pictureBox1.CreateGraphics();
                    pluma.Width = 5;
                    pluma.Color = Color.DarkRed;
                    papel.DrawRectangle(pluma, (int)(moments.M10 / moments.M00), (int)(moments.M01 / moments.M00), 5, 5);
                }
                
            }
            detectarBorde();
            //pictureBox2.Image = imgout.Bitmap;
            

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

        #region btnCentros
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
        #endregion

        private void btnCentro_Click(object sender, EventArgs e)
        {
            
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            
            for(int i=0;i<contours.Size;i++)
            {

                var area = CvInvoke.ContourArea(contours[i]);
                if (area > (int)numericSenCount.Value)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    RotatedRect box = CvInvoke.MinAreaRect(contours[i]);
                    PointF[] Vertices = box.GetVertices();
                    PointF point = box.Center;
                    papel = pictureBox1.CreateGraphics();
                    pluma.Width = 5;
                    pluma.Color = Color.DarkBlue;
                    papel.DrawRectangle(pluma, point.X, point.Y, 5, 5);
                }
                
            }
            
            /*PointF edge1 = new PointF(Vertices[1].X - Vertices[0].X,
            Vertices[1].Y - Vertices[0].Y);
            PointF edge2 = new PointF(Vertices[2].X - Vertices[1].X, Vertices[2].Y - Vertices[1].Y);
            double edge1Magnitude = Math.Sqrt(Math.Pow(edge1.X, 2) + Math.Pow(edge1.Y, 2));
            double edge2Magnitude = Math.Sqrt(Math.Pow(edge2.X, 2) + Math.Pow(edge2.Y, 2));
            PointF primaryEdge = edge1Magnitude > edge2Magnitude ? edge1 : edge2;
            PointF reference = new PointF(Vertices[1].X, Vertices[0].Y);
            double thetaRads = Math.Acos(Math.Sqrt(Math.Pow((primaryEdge.X * reference.X),2) + Math.Pow((primaryEdge.Y * reference.Y),2))/ (Math.Sqrt(Math.Pow(primaryEdge.X,2)+Math.Pow(reference.X,2))* Math.Sqrt(Math.Pow(primaryEdge.Y, 2) + Math.Pow(reference.Y, 2))));
            double thetaDeg = thetaRads * 180 / Math.PI;
            MessageBox.Show(thetaDeg.ToString());*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);


            for(int i=0;i<contours.Size;i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                RotatedRect box = CvInvoke.MinAreaRect(contours[i]);
                PointF[] Vertices = box.GetVertices();
                //MessageBox.Show(Vertices[0].X.ToString() + "," + Vertices[0].Y.ToString() + " " + Vertices[1].X.ToString() + "," + Vertices[1].Y.ToString());
                //MessageBox.Show(Vertices[2].X.ToString() + "," + Vertices[2].Y.ToString() + " " + Vertices[3].X.ToString() + "," + Vertices[3].Y.ToString());
                //Vector AB
                PointF vecAB = new PointF((Vertices[1].X) - (Vertices[0].X), (Vertices[1].Y) - (Vertices[0].Y));
                PointF vecBC = new PointF((Vertices[2].X) - (Vertices[1].X), (Vertices[2].Y) - (Vertices[1].Y));
                //Modulo de Vab
                double modAB = Math.Sqrt(Math.Pow(vecAB.X, 2) + Math.Pow(vecAB.Y, 2));
                double modBC = Math.Sqrt(Math.Pow(vecBC.X, 2) + Math.Pow(vecBC.Y, 2));
                if(modAB<modBC)
                {
                    vecAB = vecBC;
                    modAB = modBC;
                }
                //MessageBox.Show(vecAB.ToString());
                //VectorHorizontal
                PointF vecHor = new PointF(1, 0);
                //Modulo de Vab
                //double modAB = Math.Sqrt(Math.Pow(vecAB.X, 2) + Math.Pow(vecAB.Y, 2));            
                double modHor = 1.0;
                double proPunto = vecAB.X * vecHor.X;

                double anguloRad = Math.Acos(proPunto / modAB * modHor);
                double anguloDeg = (anguloRad * 180) / Math.PI;
                //MessageBox.Show(anguloDeg.ToString());
               
                var blob = CvInvoke.BoundingRectangle(contours[i]);
                blob.Y -= 5;
                CvInvoke.PutText(img, "Angulo:" + anguloDeg.ToString(), blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                //CvInvoke.PutText(imgout, "Angulo: " + anguloDeg.ToString(), blob.Location, Emgu.CV.CvEnum.FontFace.HersheyPlain, 1.0, new MCvScalar(100));
                pictureBox1.Image = img.ToBitmap();
                //pictureBox2.Image = imgout.ToBitmap();
            }


        }

        private void btnInfo_Click(object sender, EventArgs e)
        {


            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contours.Size; i++)
            {
                var area = CvInvoke.ContourArea(contours[i]);
                if (area > (int)numericSenCount.Value)
                {
                    var blob = CvInvoke.BoundingRectangle(contours[i]);
                    blob.Y -= 5;
                    CvInvoke.PutText(img, "#:" + (i + 1).ToString(), blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                }
                

            }
            //pictureBox1.Image = img.ToBitmap();
            for (int i = 0; i < contours.Size; i++)
            {         
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                papel = pictureBox1.CreateGraphics();
                pluma.Width = 5;
                pluma.Color = Color.Green;
                papel.DrawRectangle(pluma, rect);

            }


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

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (img != null)
            {

                if (imgout != null)
                {
                    Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                    Mat mat = new Mat();
                    CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                    for (int i=0;i<contours.Size;i++)
                    {                        
                        var area = CvInvoke.ContourArea(contours[i]);
                        if (area > (int)numericSenCount.Value)
                        {
                            
                        }
                    }
                    
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
            
            detectarBorde();
            numericSenCount.Value = 150;
            if (imgout != null)
            {
                
                Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                Mat mat = new Mat();
                CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                var area = 0.0;
                var AUX=0.0;    
                for (int i = 0; i < contours.Size; i++)
                {
                    //area = CvInvoke.ContourArea(contours[i]);
                   for(int j=0;j<contours.Size;j++)
                    {
                        area = CvInvoke.ContourArea(contours[i]);
                        AUX = CvInvoke.ContourArea(contours[i + 1]);
                        if (area>AUX)
                        {

                        }
                    }
                }

            }
            else
            {
                detectarBorde();
                detectarCentro();
            }
            */

            List<double> areas = new List<double>();

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat mat = new Mat();
            CvInvoke.FindContours(imgout, contours, mat, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            var area = 0.0;

            for (int j = 0; j < contours.Size; j++)
            {
                areas.Add(CvInvoke.ContourArea(contours[j]));
            }
            areas.Reverse();
            var blob = CvInvoke.BoundingRectangle(contours[0]);
            blob.Y -= 5;
            CvInvoke.PutText(img, "Calle", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));

        }
    }
    
}
