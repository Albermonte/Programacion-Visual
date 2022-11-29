using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDFamosos;

namespace Practica7
{
    public partial class ElementoLista : UserControl
    {
        public ElementoLista()
        {
            InitializeComponent();
            // Obtener el enlace con la propiedad Image del control imgFamoso
            // para gestionar su evento Format
            Binding bImagen = this.imgFamoso.DataBindings["Image"];
            bImagen.Format += this.StringToBitmap;
            this.imgFamoso.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void StringToBitmap(object sender, ConvertEventArgs e)
        {
            // Format ocurre siempre que haya que mostrar en imgFamoso
            // el valor de la propiedad Imagen (la ruta de la imagen)
            if (e.DesiredType != typeof(Image)) return;
            // Convertir la ruta de la imagen a un Bitmap
            e.Value = Bitmap.FromFile(ObtenerRutaImagen(e.Value as string));
        }

        public CFamosoBO ObjetoViculado
        {
            get
            {
                return this.famosoBindingSource.DataSource as CFamosoBO;
            }
            set
            {
                // Vincular objeto
                this.famosoBindingSource.DataSource = value;
                // Establecer un tooltip en la imagen que muestre el ID correspondiente
                // al objeto CFamosoBO
                if (value != null)
                {
                    string msj = "ID famoso: " + value.Id;
                    this.ttElementoLista.SetToolTip(this.imgFamoso, msj);
                }
            }
        }

        private string ObtenerRutaImagen(string nombreImagen)
        {
            string carpeta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            carpeta = System.IO.Path.Combine(carpeta, "Imagenes");
            return System.IO.Path.Combine(carpeta, nombreImagen);
        }

        private void ElementoLista_Load(object sender, EventArgs e)
        {

        }
    }
}
