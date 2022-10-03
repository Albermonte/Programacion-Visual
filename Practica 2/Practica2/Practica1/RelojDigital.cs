using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private RelojAnalogico m_RelojAnalógico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();
            // Font
            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            ct_HoraActual.ForeColor = Color.Blue;
            // Background
            ct_HoraActual.BackColor = Color.White;
            MostrarHoraActual();
            m_RelojAnalógico.Show(this);
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalógico.Hora = hora;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcecaDe dlg = new AcecaDe();
            dlg.ShowDialog();
        }

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalógico.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            m_RelojAnalógico.Visible = !m_RelojAnalógico.Visible;
            bt_Mostrar.Text = m_RelojAnalógico.Visible ? "Ocultar analógico" : "Mostrar analógico";
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }

        private void bt_color_dialog_Click(object sender, EventArgs e)
        {
            ColorDialog dlgAbrir = new ColorDialog();
            dlgAbrir.Color = ct_HoraActual.BackColor;
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.BackColor = dlgAbrir.Color;
            }
        }

        private void bt_font_dialog_Click(object sender, EventArgs e)
        {
            FontDialog dlgAbrir = new FontDialog();
            // Show Color picker, default: false
            dlgAbrir.ShowColor = true;
            dlgAbrir.Color = ct_HoraActual.ForeColor;
            dlgAbrir.Font = ct_HoraActual.Font;
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.ForeColor = dlgAbrir.Color;
                ct_HoraActual.Font = dlgAbrir.Font;
            }
        }


        private void mostrarAnalógicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_Mostrar_Click(sender, e);
            mostrarAnalógicoToolStripMenuItem.Checked = m_RelojAnalógico.Visible;
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_color_dialog_Click(sender, e);
        }

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt_font_dialog_Click(sender, e);
        }
    }
}
