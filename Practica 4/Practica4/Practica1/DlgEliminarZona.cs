using Practica1;
using Practica4;
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
    public partial class DlgEliminarZona : Form
    {
        private string m_Nombre;
        private TimeSpan m_Diferencia;
        private bool m_Positivo = true;
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();
        private int m_ZonaSeleccionada = -1;

        public DlgEliminarZona()
        {
            InitializeComponent();
        }

        public string Nombre { get => m_Nombre; set => m_Nombre = value; }
        public TimeSpan Diferencia { get => m_Diferencia; set => m_Diferencia = value; }
        public bool Positivo { get => m_Positivo; set => m_Positivo = value; }
        public int ZonaSeleccionada
        {
            get { return m_ZonaSeleccionada; }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            m_ZonaSeleccionada = lb_Zonas.SelectedIndex;
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            m_Zonas = ((RelojDigital)Owner).Zonas;    

            foreach (ZonaHoraria elemento in m_Zonas)
            {
                lb_Zonas.Items.Add(elemento.Nombre);
            }
            lb_Zonas.SelectedIndex = 0;
        }

        private void lb_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreZona = (string)lb_Zonas.SelectedItem;
            ZonaHoraria zonaSeleccionada =
                m_Zonas.Find(
                    delegate (ZonaHoraria zona) // predicado anónimo
                    {
                        return zona.Nombre == nombreZona;
                    }
                );
            ct_DiffHora.Text = zonaSeleccionada.Diferencia.ToString();
            if (zonaSeleccionada.Positivo)
                ct_Signo.Text = "Positivo";
            else
                ct_Signo.Text = "Negativo";
        }
    }
}
