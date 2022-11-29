using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDFamosos;

namespace Practica7
{
    public partial class Form1 : Form
    {

        ColCFamosos colFamosos;
        CFamosoBLL bd;

        public Form1()
        {
            InitializeComponent();

            bd = new CFamosoBLL();
            colFamosos = bd.ObtenerFilasFamosos();

            // Agregar al panel un control ElementoLista por cada objeto CFamosoBO
            foreach (CFamosoBO obj in colFamosos)
            {
                ElementoLista elemento = new ElementoLista();
                elemento.ObjetoViculado = obj;
                this.flowLayoutPanel1.Controls.Add(elemento);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < colFamosos.Count; i++)
            {
                //Actualizar la base de datos con los cambios realizados
                //...
                if (colFamosos[i].Modificado) bd.ActualizarFamosos(colFamosos[i]);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
