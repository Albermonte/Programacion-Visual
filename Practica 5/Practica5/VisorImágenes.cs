using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5
{
    public partial class VisorImágenes : Form
    {
        public VisorImágenes()
        {
            InitializeComponent();
            Menu_actualizar();
        }
        public VentanaHija HijaActiva
        {
            get { return (VentanaHija)this.ActiveMdiChild; }
        }

        private void boton_click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numeroHijas = this.MdiChildren.Length;
            string titulo = "Doc " + (numeroHijas + 1);
            NuevaHija(titulo);
            this.HijaActiva.PictureBox.Image = Properties.Resources.Pajaro;

        }

        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog
            OpenFileDialog dlgAbrir = new OpenFileDialog();

            // Mediante la propiedad Filter indicamos el tipo de archivos
            // que se permiten abrir y mediante Title especificamos
            // un título explicativo para la ventana.  
            dlgAbrir.Filter = "Ficheros BMP|*.bmp" + "|Ficheros GIF|*.gif" + "|Ficheros JPG o JPEG|*.jpg;*.jpeg" + "|Ficheros PNG|*.png" + "|Ficheros EXIF|*.exif" + "|Ficheros TIFF|*.tiff";
            dlgAbrir.Title = "Abrir";
            dlgAbrir.FilterIndex = 3;

            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                abrirArchivo(dlgAbrir.FileName);
            }
            else
            {
                return;
            }
        }

        private void abrirArchivo(string fileName)
        {
            byte[] contenidoArchivo = File.ReadAllBytes(fileName);

            // Creamos un flujo de tipo MemoryStream pasándole el contenido del archivo
            MemoryStream stream = new MemoryStream(contenidoArchivo);

            // Usamos el método FromStream de la clase Image para crear una "imagen" a partir del flujo anterior
            // Creamos una nueva ventana hija con el método NuevaHija, pasándole como título el nombre del archivo abierto      
            NuevaHija(fileName);                                                                                  // Llamamos a NuevaHija para crear una nueva ventana                                                                              

            // Obtenemos una referencia a la nueva ventana mediante la propiedad HijaActiva
            // Asignados "imagen" al pictureBox de la nueva ventana
            HijaActiva.PictureBox.Image = Image.FromStream(stream);                                         // Y ponemos la imágen abierta en la nueva ventana creada
            HijaActiva.MdiParent = this;
            //HijaActiva.PictureBox.Image = Image.FromFile(fileName);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HijaActiva == null)
            {
                MessageBox.Show("No hay ninguna ventana activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.HijaActiva.Close();
           
        }

        private void VisorImágenes_MdiChildActivate(object sender, EventArgs e)
        {
            Menu_actualizar();
        }

        private void Menu_actualizar()
        {
            cerrarToolStripMenuItem.Enabled = this.HijaActiva != null;
            cascadaToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoVerticalToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoHorizontalToolStripMenuItem.Enabled = this.HijaActiva != null;
        }

        private void VisorImágenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") && !file.ToUpper().EndsWith(".BMP") && !file.ToUpper().EndsWith(".GIF"))
                {
                    e.Effect = DragDropEffects.None; // Alguno de los archivos no es una imagen
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes
        }

        private void VisorImágenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                abrirArchivo(file);
            }
        }

        private void NuevoBarraHerramientas_Click(object sender, EventArgs e)
        {
            int numeroHijas = this.MdiChildren.Length;
            string titulo = "Doc " + (numeroHijas + 1);
            NuevaHija(titulo);
            this.HijaActiva.PictureBox.Image = Properties.Resources.Pajaro;
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog
            OpenFileDialog dlgAbrir = new OpenFileDialog();

            // Mediante la propiedad Filter indicamos el tipo de archivos
            // que se permiten abrir y mediante Title especificamos
            // un título explicativo para la ventana.  
            dlgAbrir.Filter = "Ficheros BMP|*.bmp" + "|Ficheros GIF|*.gif" + "|Ficheros JPG o JPEG|*.jpg;*.jpeg" + "|Ficheros PNG|*.png" + "|Ficheros EXIF|*.exif" + "|Ficheros TIFF|*.tiff";
            dlgAbrir.Title = "Abrir";
            dlgAbrir.FilterIndex = 3;

            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                abrirArchivo(dlgAbrir.FileName);
            }
            else
            {
                return;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (this.HijaActiva == null)
            {
                MessageBox.Show("No hay ninguna ventana activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.HijaActiva.Close();
        }

        private void Acercade_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        private void NuevoBarraHerramientas_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Crea una nueva ventana con una imagen predefinida";
        }

        private void NuevoBarraHerramientas_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void Abrir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abra una imagen desde su ordenador";
        }

        private void Acercade_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abra la ventana de Acerca De";
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraEstado.Visible = !barraEstado.Visible;
            barraDeEstadoToolStripMenuItem.Checked = barraEstado.Visible;
        }

        private void barraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraHerramientas.Visible = !barraHerramientas.Visible;
            barraDeHerramientasToolStripMenuItem.Checked = barraHerramientas.Visible;
        }
    }
}
