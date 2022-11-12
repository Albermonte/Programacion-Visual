    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Threading;

namespace Practica_6
{
    public partial class Hilos : Form
    {
        public Hilos()
        {
            InitializeComponent();
            // Valor del progreso coincida con la velocidad mostrada
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;                          
            bp_Progreso.Increment(1);
            // Incrementamos en 1 la barra de progreso
            pb_Imagen.Image = Properties.Resources.Pajaro;
        }

        private void Bt_Mostrar_Click(object sender, EventArgs e)
        {
            pb_Imagen.Visible = !pb_Imagen.Visible;
            bt_Mostrar.Text = pb_Imagen.Visible ? "Ocultar Imagen" : "Mostrar Imagen";
        }

        private void AcercaDeMenu_Click(object sender, EventArgs e)
        {

        }

        private void SalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ct_Velocidad_Validated(object sender, EventArgs e)
        {
            // Valor del progreso coincida con la velocidad mostrada
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;                          
        }

        private List<int> m_Valores = new List<int> { 0 };
        private int m_Indice;

        // Creación del hilo A
        private Thread m_HiloA;                                                     
        // Creación del hilo B
        private Thread m_HiloB;                                                     

        private void Bt_Iniciar_Click(object sender, EventArgs e)
        {
            // Inicializamos a 0 todos los elementos de la lista así como el indice
            m_Valores.Clear();                                                          
            m_Indice = 0;
            bp_Progreso.Value = 0;

            // Deshabilitamos ambos botones
            bt_Iniciar.Enabled = false;                                                
            ct_Velocidad.Enabled = false;

            // Abreviado-> m_HiloA = new Thread (ActualizarA)
            m_HiloA = new Thread(new ThreadStart(ActualizarA));         
            m_HiloB = new Thread(new ThreadStart(ActualizarB));
            m_HiloA.Start();
            m_HiloB.Start();
        }

        // Ejecutado por los 2 hilos
        private void Progresar()            
        {
            // Añadir elemento en la lista m_Valores
            m_Valores.Add(m_Indice);
            // Actualizar barra de progreso
            ActualizarBarraProgreso();   // bp_Progreso.Value = m_Indice;
            // Incrementar m_Indice
            m_Indice++;

            if (m_Indice == bp_Progreso.Maximum)
            {
                ActualizarBotonIniciar();   // bp_Progreso.Enabled = true;
                ActualizarCtVelocidad();    // ct_Velocidad.Enabled = true;
            }
        }

        private void ActualizarA()
        {
            while (m_Indice <= bp_Progreso.Maximum)
            {
                if(m_PararHiloA.WaitOne(0))
                {
                    m_ParadoHiloA.Set();
                    ActualizarBotonIniciar();
                    ActualizarCtVelocidad();

                    return;
                }

                /*
                Monitor.Enter(bp_Progreso);
                try { Progresar(); }
                finally { Monitor.Exit(bp_Progreso); }
                */

                // Con Lock el codigo es más eficiente ya que el objeto usado para la sincronización solo se evalua una vez
                lock (bp_Progreso)                                           
                {                                               
                    Progresar();                                             
                }                                                            
            }

            for (int i = 0; i < m_Valores.Count; i++)
            {
                if (i != m_Valores[i])
                {
                    MessageBox.Show("Valores[" + i + "] = " + m_Valores[i] + " y debía valer " + i);
                    break;
                }
            }
        }

        private void ActualizarB()
        {
            while (m_Indice <= bp_Progreso.Maximum)
            {
                if (m_PararHiloB.WaitOne(0))
                {
                    m_ParadoHiloB.Set();
                    bt_Iniciar.Enabled = true;
                    ct_Velocidad.Enabled = true;

                    return;
                }
                lock (bp_Progreso)                                           
                {                                              
                    Progresar();                                            
                }
                
            }
        }

        private void ActualizarBarraProgreso()                                          // ActualizarBarraProgreso se ejecute en el hilo principal, en lugar de secundario
        {
            if (bp_Progreso.InvokeRequired)     // devuelve true si el hilo desde el que ha sido invocado este metodo no es el hilo que creo el control
            {
                MethodInvoker delegado = new MethodInvoker(ActualizarBarraProgreso);
                // Elija la sentencia más adecuada de las dos siguientes:
                // Progreso.BeginInvoke(delegado);
                 bp_Progreso.Invoke(delegado);
            }
            else
            {
                bp_Progreso.PerformStep();
            }
        }

        private void ActualizarBotonIniciar()                                           // ActualizarBotonIniciar se ejecute en el hilo principal, en lugar de secundario
        {
            if (bt_Iniciar.InvokeRequired)
            {
                MethodInvoker delegado = new MethodInvoker(ActualizarBotonIniciar);
                bt_Iniciar.BeginInvoke(delegado);
            }
            else
            {
                bt_Iniciar.Enabled = true;
            }
        }

        private void ActualizarCtVelocidad()                                            // ActualizarCtVelocidad se ejecute en el hilo principal, en lugar de secundario
        {
            if (ct_Velocidad.InvokeRequired)
            {
                MethodInvoker delegado = new MethodInvoker(ActualizarCtVelocidad);
                ct_Velocidad.BeginInvoke(delegado);
            }
            else
            {
                ct_Velocidad.Enabled = true;
            }
        }

        ManualResetEvent m_PararHiloA = new ManualResetEvent(false);
        ManualResetEvent m_ParadoHiloA = new ManualResetEvent(false);
        ManualResetEvent m_PararHiloB = new ManualResetEvent(false);
        ManualResetEvent m_ParadoHiloB = new ManualResetEvent(false);

        // Se encarga de decirle al hilo secundario que se detenga y de esperar a que la detención se haga efectiva
        private void PararHiloA()       
        {
            if( m_HiloA != null && m_HiloA.IsAlive)
            {
                // Activamos el evento para decirle al hilo que pare
                m_PararHiloA.Set();
                // Esperar a que el hilo haya terminado
                while(m_HiloA.IsAlive)
                {
                    // evitar una espera activa
                    m_ParadoHiloA.WaitOne(200, false);              
                    // procesar eventos pendientes
                    Application.DoEvents();                         
                }
            }
        }

        private void PararHiloB()
        {
            if (m_HiloB != null && m_HiloB.IsAlive)
            {
                // Activamos el evento para decirle al hilo que pare
                m_PararHiloB.Set();
                // Esperar a que el hilo haya terminado
                while (m_HiloB.IsAlive)
                {
                    // evitar una espera activa
                    m_ParadoHiloB.WaitOne(200, false);              
                    // procesar eventos pendientes
                    Application.DoEvents();                         
                }
            }
        }

        private void Hilos_FormClosed(object sender, FormClosedEventArgs e)
        {
            PararHiloA();
            PararHiloB();
            if(m_ParadoHiloA.WaitOne(0))
            {
                MessageBox.Show("Hilo A parado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (m_ParadoHiloB.WaitOne(0))
            {
                MessageBox.Show("Hilo B parado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DetenerMenu_Click(object sender, EventArgs e)
        {
            PararHiloA();
            PararHiloB();
            if (m_ParadoHiloA.WaitOne(0))
            {
                MessageBox.Show("HiloA ha sido parado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (m_ParadoHiloB.WaitOne(0))
            {
                MessageBox.Show("HiloB ha sido parado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            m_ParadoHiloA.Reset();
            m_PararHiloA.Reset();
            m_ParadoHiloB.Reset();
            m_PararHiloB.Reset();

            m_HiloA = null;
            m_HiloB = null;
        }

        private void acercaDeMenu_Click_1(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }
    }
}

/* Un delegado es un objeto de la clase Delegate que representa un fragmento de código (generalmente un método) que se puede ejecutar. Similar a un puntero a función
 * Parar será activada por el hilo principal para notificar al secundario de que se debe detener.
 * Parado servirá para que el gilo secundario avise al principal cuando se haya detenido
 * 
 * BeginInvoque/Invoke realizan un cambio de contexto desde el hilo actual al hilo que creó
 * el control
 * */