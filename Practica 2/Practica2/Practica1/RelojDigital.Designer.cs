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
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.horaActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_color_dialog = new System.Windows.Forms.Button();
            this.bt_font_dialog = new System.Windows.Forms.Button();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 24);
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ct_HoraActual.Location = new System.Drawing.Point(66, 209);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(100, 20);
            this.ct_HoraActual.TabIndex = 1;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // horaActual
            // 
            this.horaActual.AutoSize = true;
            this.horaActual.Location = new System.Drawing.Point(84, 184);
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
            this.bt_Mostrar.Location = new System.Drawing.Point(66, 251);
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
            this.bt_color_dialog.Location = new System.Drawing.Point(12, 94);
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
            this.bt_font_dialog.Location = new System.Drawing.Point(125, 94);
            this.bt_font_dialog.Name = "bt_font_dialog";
            this.bt_font_dialog.Size = new System.Drawing.Size(96, 23);
            this.bt_font_dialog.TabIndex = 5;
            this.bt_font_dialog.Text = "Cambiar fuente";
            this.bt_font_dialog.UseVisualStyleBackColor = true;
            this.bt_font_dialog.Visible = false;
            this.bt_font_dialog.Click += new System.EventHandler(this.bt_font_dialog_Click);
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
            this.mostrarAnalógicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarAnalógicoToolStripMenuItem.Text = "Mostrar analógico";
            this.mostrarAnalógicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalógicoToolStripMenuItem_Click);
            // 
            // cambiarColorToolStripMenuItem
            // 
            this.cambiarColorToolStripMenuItem.Name = "cambiarColorToolStripMenuItem";
            this.cambiarColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarColorToolStripMenuItem.Text = "Cambiar color";
            this.cambiarColorToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorToolStripMenuItem_Click);
            // 
            // cambiarFuenteToolStripMenuItem
            // 
            this.cambiarFuenteToolStripMenuItem.Name = "cambiarFuenteToolStripMenuItem";
            this.cambiarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarFuenteToolStripMenuItem.Text = "Cambiar fuente";
            this.cambiarFuenteToolStripMenuItem.Click += new System.EventHandler(this.cambiarFuenteToolStripMenuItem_Click);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(233, 297);
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
    }
}

