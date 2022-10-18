using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class DlgDatosZona : Form
    {
        private string m_Nombre;
        private TimeSpan m_Diferencia;
        private bool m_Positivo = true;

        public DlgDatosZona()
        {
            InitializeComponent();
        }

        public string Nombre { get => m_Nombre; set => m_Nombre = value; }
        public TimeSpan Diferencia { get => m_Diferencia; set => m_Diferencia = value; }
        public bool Positivo { get => m_Positivo; set => m_Positivo = value; }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (ct_Nombre.Text != "")
                this.Nombre = ct_Nombre.Text;
            else
            {
                MessageBox.Show("Introduzca un nombre válido",
                "Error en los datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ct_DiffHora.HoraValida)
            {
                DateTime hora = ct_DiffHora.Hora;
                this.Diferencia = new TimeSpan(hora.Hour, hora.Minute,hora.Second);
            }
            else
            {
                MessageBox.Show("Introduzca una diferencia horaria válida",
                "Error en los datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_DiffHora.Focus();
                ct_DiffHora.SelectAll();
                return;
            }
            this.Positivo = rb_Positivo.Checked;
            // Como los datos son válidos el resultado devuelto por el
            // diálogo debe ser OK
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
