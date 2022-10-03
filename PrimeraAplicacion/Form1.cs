using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraAplicacion
{
    public partial class Form1 : Form
    {
        private Color colorTexto = Color.Blue;
        private String[] sMensajes;
        private int indiceMensajes = 0;
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            etMensaje.ForeColor = ColorTexto;
            btMensajes.Text = Properties.Resources.sTituloMensaje;
            try
            {

            sMensajes = File.ReadAllLines("../../TextFile1.txt");
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Color ColorTexto { get => colorTexto; set => colorTexto = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btMensajes_Click(object sender, EventArgs e)
        {
            etMensaje.Text = sMensajes[indiceMensajes++];
            if (indiceMensajes == sMensajes.Length) indiceMensajes = 0;
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siguienteMensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btMensajes.PerformClick();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
