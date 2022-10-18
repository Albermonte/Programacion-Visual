using Practica3;
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
        private bool m_DespertadorActivado = false;
        private const int MaxZonas = 4;

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
            // Init Tooltip
            this.toolTip1.SetToolTip(this.menuStrip1, Practica3.Properties.Resources.mensajeBarraMenus);
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
            if(!m_DespertadorActivado) return;
            if (!ct_Alarma.HoraValida)
            {
                System.Diagnostics.Debug.WriteLine("Hora alarma no válida");
                return;
            }

            DateTime horaActual = DateTime.Now + m_DesfaseHorario;
            DateTime horaAlarma = ct_Alarma.Hora;

            int segundosActual = horaActual.Second + horaActual.Minute * 60 + horaActual.Hour * 3600;
            int segundosAlarma = horaAlarma.Second + horaAlarma.Minute * 60 + horaAlarma.Hour * 3600;           // Segundos Alarma

            if (segundosActual >= segundosAlarma)
            {
                if (segundosActual - segundosAlarma < 300)
                {
                    Console.Beep();                                                                             // o bien System.Media.SystemSounds.Beep.Play();
                }
                else if (segundosAlarma - segundosActual > 86400 - 300)
                {
                    Console.Beep();                                                                             // o bien System.Media.SystemSounds.Beep.Play(); 
                }
            }
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

        private void bt_DialogZona_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();
            dlg.ShowDialog(this);

            if (DialogResult.OK == dlg.DialogResult)
            {
                string nombre = dlg.Nombre;
                string desfase = dlg.Diferencia.ToString();
                string signo = dlg.Positivo ? "Positivo" : "Negativo";

                // Visualizar una caja de diálogo que muestre los datos
                // de la zona recogidos en el diálogo
                MessageBox.Show("Nombre: " + nombre + "\nDesfase: " + desfase + "\nSigno: " + signo, "Datos de la zona", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set { 
                m_DespertadorActivado = value;
                // DespertadorActivar.Text = m_DespertadorActivado ? "Desacti&var" : "Acti&var";
                // DespertadorActivar.Checked = m_DespertadorActivado;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = !OpcionesDespertadorActivar.Enabled;
            }
        }

        private void DespertadorActivar_Click(object sender, EventArgs e)
        {
            DespertadorActivado = true;
        }

        private void DespertadorDesactivar_Click(object sender, EventArgs e)
        {
            DespertadorActivado = false;
        }
        private void DespertadorToogle_Click(object sender, EventArgs e)
        {
            DespertadorActivado = !DespertadorActivado;
        }

        public int NúmeroZonas
        {
            get { return menúContextoZona.Items.Count - 3; }
        }

        private void menúZona_DropDownOpened(object sender, EventArgs e)
        {
            if (NúmeroZonas >= MaxZonas) zonaAñadir.Available = false;
            else zonaAñadir.Available = true;

            if (NúmeroZonas < 1)
            {
                zonaEliminar.Available = false;
                zonaSeparador.Available = false;
            }
            else
            {
                zonaEliminar.Available = true;
                zonaSeparador.Available = true;
            }
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == MaxZonas)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }

            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = "Zona " + (NúmeroZonas + 1);
            // Especifique el manejador del evento Click de zonaNueva; la
            // respuesta a este evento vendrá dada por el método zona_Click.
            // Añada el elemento zonaNueva al menú menúZona.
            zonaNueva.Click += new System.EventHandler(this.zona_Click);
            menúContextoZona.Items.AddRange(new ToolStripItem[] { zonaNueva });
        }

        private void zona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString(), "Zona", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas == 0)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }
            menúContextoZona.Items.RemoveAt(menúContextoZona.Items.Count - 1);
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
