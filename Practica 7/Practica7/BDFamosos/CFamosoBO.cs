using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
   public class CFamosoBO : INotifyPropertyChanged
    {
        // Propiedades relacionadas con la tabla famoso
        private int ID;
        public int Id
        {
            get { return ID; }
            set
            {
                ID = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        // Añadir el resto de las propiedades
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Apellidos"));
            }
        }
        private DateTime cumple;
        public DateTime Cumple
        {
            get { return cumple; }
            set
            {
                cumple = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Cumple"));
            }
        }

        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Imagen"));
            }
        }
        // Constructores
        public CFamosoBO() { }
        public CFamosoBO(int id, string nom, string ape, DateTime cum, string ima = null)
        {
            Id = id; Nombre = nom; Apellidos = ape; Cumple = cum; Imagen = ima;
        }
        // Otras propiedades
        private bool modificado;
        public bool Modificado
        {
            get { return modificado; }
            set { modificado = value; }
        }
        public string Edad
        {
            get // complete el código
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - Cumple.Year;
                if (hoy.Month < Cumple.Month || (hoy.Month == Cumple.Month && hoy.Day < Cumple.Day)) --edad;
                return String.Format("{0}", edad);
            }
        }
        public string NombreAprellidosEdad
        {
            get
            {
                // Devolver un string de la forma, p.ej.: Lawrence, Jennifer (22)
                return Apellidos + ", " + Nombre + " (" + String.Format("{0}", Edad) + ")";
            }
        }
        // Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e); // generar evento
            }
        }
    }
}
