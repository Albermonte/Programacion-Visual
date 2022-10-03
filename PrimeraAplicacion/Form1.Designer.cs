namespace PrimeraAplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.etMensaje = new System.Windows.Forms.Label();
            this.btMensajes = new System.Windows.Forms.Button();
            this.ttBoton = new System.Windows.Forms.ToolTip(this.components);
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteMensajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // etMensaje
            // 
            this.etMensaje.Font = new System.Drawing.Font("Britannic Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etMensaje.Location = new System.Drawing.Point(123, 131);
            this.etMensaje.Name = "etMensaje";
            this.etMensaje.Size = new System.Drawing.Size(644, 62);
            this.etMensaje.TabIndex = 0;
            this.etMensaje.Text = "Mensajes";
            // 
            // btMensajes
            // 
            this.btMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMensajes.Location = new System.Drawing.Point(123, 353);
            this.btMensajes.Name = "btMensajes";
            this.btMensajes.Size = new System.Drawing.Size(644, 67);
            this.btMensajes.TabIndex = 1;
            this.btMensajes.Text = "Mensajes";
            this.ttBoton.SetToolTip(this.btMensajes, "Muestra un mensaje de una lista de mensajes");
            this.btMensajes.UseVisualStyleBackColor = true;
            this.btMensajes.Click += new System.EventHandler(this.btMensajes_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(947, 42);
            this.menuOpciones.TabIndex = 2;
            this.menuOpciones.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguienteMensajeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(134, 38);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // siguienteMensajeToolStripMenuItem
            // 
            this.siguienteMensajeToolStripMenuItem.Name = "siguienteMensajeToolStripMenuItem";
            this.siguienteMensajeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.siguienteMensajeToolStripMenuItem.Text = "Siguiente &Mensaje";
            this.siguienteMensajeToolStripMenuItem.Click += new System.EventHandler(this.siguienteMensajeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 562);
            this.Controls.Add(this.btMensajes);
            this.Controls.Add(this.etMensaje);
            this.Controls.Add(this.menuOpciones);
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etMensaje;
        private System.Windows.Forms.Button btMensajes;
        private System.Windows.Forms.ToolTip ttBoton;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteMensajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

