namespace Practica1
{
    partial class RelojDigital
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despertadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúZona = new System.Windows.Forms.ToolStripMenuItem();
            this.menúContextoZona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.horaActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_color_dialog = new System.Windows.Forms.Button();
            this.bt_font_dialog = new System.Windows.Forms.Button();
            this.ct_Alarma = new Practica3.EditHora();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.bt_DialogZona = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.menúContextoAlarma.SuspendLayout();
            this.menúContextoZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.despertadorToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.menúZona});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // despertadorToolStripMenuItem
            // 
            this.despertadorToolStripMenuItem.DropDown = this.menúContextoAlarma;
            this.despertadorToolStripMenuItem.Name = "despertadorToolStripMenuItem";
            this.despertadorToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.despertadorToolStripMenuItem.Text = "Despertador";
            // 
            // menúContextoAlarma
            // 
            this.menúContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menúContextoAlarma.Name = "menúContextoAlarma";
            this.menúContextoAlarma.OwnerItem = this.despertadorToolStripMenuItem;
            this.menúContextoAlarma.Size = new System.Drawing.Size(129, 48);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(128, 22);
            this.OpcionesDespertadorActivar.Text = "Activar";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.DespertadorActivar_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(128, 22);
            this.OpcionesDespertadorDesactivar.Text = "Desactivar";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.DespertadorDesactivar_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAnalógicoToolStripMenuItem,
            this.cambiarColorToolStripMenuItem,
            this.cambiarFuenteToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // mostrarAnalógicoToolStripMenuItem
            // 
            this.mostrarAnalógicoToolStripMenuItem.Checked = true;
            this.mostrarAnalógicoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarAnalógicoToolStripMenuItem.Name = "mostrarAnalógicoToolStripMenuItem";
            this.mostrarAnalógicoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.mostrarAnalógicoToolStripMenuItem.Text = "Mostrar analógico";
            this.mostrarAnalógicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalógicoToolStripMenuItem_Click);
            // 
            // cambiarColorToolStripMenuItem
            // 
            this.cambiarColorToolStripMenuItem.Name = "cambiarColorToolStripMenuItem";
            this.cambiarColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cambiarColorToolStripMenuItem.Text = "Cambiar color";
            this.cambiarColorToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorToolStripMenuItem_Click);
            // 
            // cambiarFuenteToolStripMenuItem
            // 
            this.cambiarFuenteToolStripMenuItem.Name = "cambiarFuenteToolStripMenuItem";
            this.cambiarFuenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cambiarFuenteToolStripMenuItem.Text = "Cambiar fuente";
            this.cambiarFuenteToolStripMenuItem.Click += new System.EventHandler(this.cambiarFuenteToolStripMenuItem_Click);
            // 
            // menúZona
            // 
            this.menúZona.DropDown = this.menúContextoZona;
            this.menúZona.Name = "menúZona";
            this.menúZona.Size = new System.Drawing.Size(46, 20);
            this.menúZona.Text = "Zona";
            this.menúZona.DropDownOpened += new System.EventHandler(this.menúZona_DropDownOpened);
            // 
            // menúContextoZona
            // 
            this.menúContextoZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaEliminar,
            this.zonaSeparador});
            this.menúContextoZona.Name = "menúContextoZona";
            this.menúContextoZona.OwnerItem = this.menúZona;
            this.menúContextoZona.Size = new System.Drawing.Size(204, 54);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.zonaAñadir.Size = new System.Drawing.Size(203, 22);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.zonaEliminar.Size = new System.Drawing.Size(203, 22);
            this.zonaEliminar.Text = "Eliminar";
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(200, 6);
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ct_HoraActual.Location = new System.Drawing.Point(198, 220);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(100, 20);
            this.ct_HoraActual.TabIndex = 1;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // horaActual
            // 
            this.horaActual.AutoSize = true;
            this.horaActual.Location = new System.Drawing.Point(220, 188);
            this.horaActual.Name = "horaActual";
            this.horaActual.Size = new System.Drawing.Size(65, 13);
            this.horaActual.TabIndex = 2;
            this.horaActual.Text = "Hora actual:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.Location = new System.Drawing.Point(139, 254);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(100, 23);
            this.bt_Mostrar.TabIndex = 3;
            this.bt_Mostrar.Text = "Ocultar analógico";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Visible = false;
            this.bt_Mostrar.Click += new System.EventHandler(this.bt_Mostrar_Click);
            // 
            // bt_color_dialog
            // 
            this.bt_color_dialog.Location = new System.Drawing.Point(85, 120);
            this.bt_color_dialog.Name = "bt_color_dialog";
            this.bt_color_dialog.Size = new System.Drawing.Size(93, 23);
            this.bt_color_dialog.TabIndex = 4;
            this.bt_color_dialog.Text = "Cambiar color";
            this.bt_color_dialog.UseVisualStyleBackColor = true;
            this.bt_color_dialog.Visible = false;
            this.bt_color_dialog.Click += new System.EventHandler(this.bt_color_dialog_Click);
            // 
            // bt_font_dialog
            // 
            this.bt_font_dialog.Location = new System.Drawing.Point(198, 120);
            this.bt_font_dialog.Name = "bt_font_dialog";
            this.bt_font_dialog.Size = new System.Drawing.Size(96, 23);
            this.bt_font_dialog.TabIndex = 5;
            this.bt_font_dialog.Text = "Cambiar fuente";
            this.bt_font_dialog.UseVisualStyleBackColor = true;
            this.bt_font_dialog.Visible = false;
            this.bt_font_dialog.Click += new System.EventHandler(this.bt_font_dialog_Click);
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.ContextMenuStrip = this.menúContextoAlarma;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(85, 220);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(100, 20);
            this.ct_Alarma.TabIndex = 6;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Location = new System.Drawing.Point(114, 188);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(39, 13);
            this.alarmLabel.TabIndex = 7;
            this.alarmLabel.Text = "Alarma";
            // 
            // bt_DialogZona
            // 
            this.bt_DialogZona.Location = new System.Drawing.Point(139, 60);
            this.bt_DialogZona.Name = "bt_DialogZona";
            this.bt_DialogZona.Size = new System.Drawing.Size(100, 23);
            this.bt_DialogZona.TabIndex = 8;
            this.bt_DialogZona.Text = "Diálogo zona";
            this.bt_DialogZona.UseVisualStyleBackColor = true;
            this.bt_DialogZona.Click += new System.EventHandler(this.bt_DialogZona_Click);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 297);
            this.ContextMenuStrip = this.menúContextoZona;
            this.Controls.Add(this.bt_DialogZona);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.bt_font_dialog);
            this.Controls.Add(this.bt_color_dialog);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.horaActual);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelojDigital";
            this.Text = "Reloj Digital";
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menúContextoAlarma.ResumeLayout(false);
            this.menúContextoZona.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Label horaActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Mostrar;
        private System.Windows.Forms.Button bt_color_dialog;
        private System.Windows.Forms.Button bt_font_dialog;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnalógicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarFuenteToolStripMenuItem;
        private Practica3.EditHora ct_Alarma;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Button bt_DialogZona;
        private System.Windows.Forms.ToolStripMenuItem despertadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúZona;
        private System.Windows.Forms.ContextMenuStrip menúContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.ContextMenuStrip menúContextoZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

