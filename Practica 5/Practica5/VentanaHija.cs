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

namespace pr5
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string título)
        {
            InitializeComponent();
            this.Text = título;

        }
        public PictureBox PictureBox
        {
            get { return m_PictureBox; }
        }

        private bool greyFilter = false;

        private void ajustarLaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si no estamos en modo ajustar, activamos este modo
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                //Al utilizar Zoom en lugar de StretchImage las proporciones de la imagen se mantienen
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;          
            }
            // Si estamos en modo ajustar, desactivamos este modo
            else if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            //Check para comprobar si el modo está activo
            ajustarLaVentanaToolStripMenuItem.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        private void rotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.PictureBox.Refresh();
        }

        private void añadirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FromImage nos proporciona la superficie de dibujo para dibujar sobre la imagen
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))             
            {
                // Utilizar el método DrawString de gfx para pintar el texto
                // "Programación Visual" en la posición 0,0 del área de
                // cliente, utilizando una fuente Arial de 20 ptos
                // y una brocha del color deseado
                Font fuente = new Font("Arial", 20, FontStyle.Regular);
                SolidBrush brocha = new SolidBrush(Color.DarkRed);
                Point punto = new Point(0, 0);
                gfx.DrawString("Programación Visual", fuente, brocha, punto);
            }
            // Refrescar el picture box
            this.PictureBox.Refresh();
            // using-> liberar los recursos no administrados de gfx
            // Al finalizar using-> se invoca al metodo Dispose() de Graphics
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = this.PictureBox;
            Image imagen = pictureBox.Image;
            greyFilter = !greyFilter;

            if (greyFilter)
                using (Graphics gfx = Graphics.FromImage(imagen))
                {
                    // Matriz para realizar una transformación al gris
                    // manteniendo los valores de luminancia correctos
                    ColorMatrix cm = new ColorMatrix(new float[][]
                    {
                     new float[]{0.3f,0.3f,0.3f,0,0},
                     new float[]{0.59f,0.59f,0.59f,0,0},
                     new float[]{0.11f,0.11f,0.11f,0,0},
                     new float[]{0,0,0,1,0},
                     new float[]{0,0,0,0,1}});
                    // Información acerca de la manipulación de los colores del
                    // mapa de bits
                    ImageAttributes atrImg = new ImageAttributes();
                    atrImg.SetColorMatrix(cm);

                    // Dibujar la imagen:
                    // DrawImage(Imagen, RectImgDestino, 
                    // XImgFuente, YImgFuente, anchoImgFuente, anchoImgFuente, 
                    // UnidadesGráficas, AtributosImagen) 
                    gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, atrImg);
                }
            else
            {
                PictureBox.Image = Properties.Resources.Pajaro;
            }
            // Refrescar pictureBox
            escalaDeGrisesToolStripMenuItem.Checked = greyFilter;
            this.PictureBox.Refresh();
        }
        private void GuardarComo()
        {
            // Mostrar el diálogo SaveFileDialog y configurarlo de forma análoga al OpenFileDialog de la opción "Abrir"
            SaveFileDialog dlgGuardarComo = new SaveFileDialog();

            dlgGuardarComo.Filter = "Archivos BMP|*.bmp|Archivos GIF|*.gif|Archivos JPG o JPEG|*.jpg;*.jpeg|Archivos PNG|*.png|Archivos EXIF|*.exif|Archivos TIFF|*.tiff";

            dlgGuardarComo.Title = "Guardar como...";

            // Si el resultado del diálogo es distinto de OK, terminar
            if (dlgGuardarComo.ShowDialog() == DialogResult.OK)
            {
                if (dlgGuardarComo.FileName.ToUpper().EndsWith(".JPG"))
                {
                    ImageFormat formato = ImageFormat.Jpeg;
                    this.PictureBox.Image.Save(dlgGuardarComo.FileName, formato);
                }
                if (dlgGuardarComo.FileName.ToUpper().EndsWith(".BMP"))
                {
                    ImageFormat formato = ImageFormat.Bmp;
                    this.PictureBox.Image.Save(dlgGuardarComo.FileName, formato);
                }
                if (dlgGuardarComo.FileName.ToUpper().EndsWith(".GIF"))
                {
                    ImageFormat formato = ImageFormat.Gif;
                    this.PictureBox.Image.Save(dlgGuardarComo.FileName, formato);
                }
                if (dlgGuardarComo.FileName.ToUpper().EndsWith(".PNG"))
                {
                    ImageFormat formato = ImageFormat.Png;
                    this.PictureBox.Image.Save(dlgGuardarComo.FileName, formato);
                }
            }
            else
            {
                return;
            }

            // Actualizar el título de esta ventana
            this.Text = dlgGuardarComo.FileName;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text.StartsWith("Doc"))
            {
                GuardarComo();
            }
            else
            {
                this.PictureBox.Image.Save(this.Text);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
    }
    

}
