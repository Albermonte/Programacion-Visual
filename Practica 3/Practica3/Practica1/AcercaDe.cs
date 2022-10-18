using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class AcecaDe : Form
    {
        public AcecaDe()
        {
            InitializeComponent();
        }

        private void AcecaDe_Load(object sender, EventArgs e)
        {
            this.creditos.Text = Practica3.Properties.Resources.textoAcercaDe;
        }
    }
}
