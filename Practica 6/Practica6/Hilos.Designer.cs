namespace Practica_6
{
    partial class Hilos
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
            this.bp_Progreso = new System.Windows.Forms.ProgressBar();
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.et_Velocidad = new System.Windows.Forms.Label();
            this.ct_Velocidad = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bp_Progreso
            // 
            this.bp_Progreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bp_Progreso.Location = new System.Drawing.Point(12, 240);
            this.bp_Progreso.Name = "bp_Progreso";
            this.bp_Progreso.Size = new System.Drawing.Size(310, 30);
            this.bp_Progreso.TabIndex = 0;
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Mostrar.Location = new System.Drawing.Point(12, 276);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(147, 23);
            this.bt_Mostrar.TabIndex = 1;
            this.bt_Mostrar.Text = "Ocultar Imagen";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Click += new System.EventHandler(this.Bt_Mostrar_Click);
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Iniciar.Location = new System.Drawing.Point(175, 276);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(147, 23);
            this.bt_Iniciar.TabIndex = 2;
            this.bt_Iniciar.Text = "Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.Bt_Iniciar_Click);
            // 
            // et_Velocidad
            // 
            this.et_Velocidad.AutoSize = true;
            this.et_Velocidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.et_Velocidad.Location = new System.Drawing.Point(39, 318);
            this.et_Velocidad.Name = "et_Velocidad";
            this.et_Velocidad.Size = new System.Drawing.Size(91, 19);
            this.et_Velocidad.TabIndex = 4;
            this.et_Velocidad.Text = "Velocidad: ";
            // 
            // ct_Velocidad
            // 
            this.ct_Velocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_Velocidad.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ct_Velocidad.Location = new System.Drawing.Point(175, 317);
            this.ct_Velocidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ct_Velocidad.Name = "ct_Velocidad";
            this.ct_Velocidad.Size = new System.Drawing.Size(147, 20);
            this.ct_Velocidad.TabIndex = 5;
            this.ct_Velocidad.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ct_Velocidad.Validated += new System.EventHandler(this.Ct_Velocidad_Validated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenu,
            this.ayudaMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenu
            // 
            this.archivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detenerMenu,
            this.salirMenu});
            this.archivoMenu.Name = "archivoMenu";
            this.archivoMenu.Size = new System.Drawing.Size(60, 20);
            this.archivoMenu.Text = "Archivo";
            // 
            // detenerMenu
            // 
            this.detenerMenu.Name = "detenerMenu";
            this.detenerMenu.Size = new System.Drawing.Size(180, 22);
            this.detenerMenu.Text = "Detener";
            this.detenerMenu.Click += new System.EventHandler(this.DetenerMenu_Click);
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(180, 22);
            this.salirMenu.Text = "&Salir";
            this.salirMenu.Click += new System.EventHandler(this.SalirMenu_Click);
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeMenu});
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(53, 20);
            this.ayudaMenu.Text = "Ayuda";
            // 
            // acercaDeMenu
            // 
            this.acercaDeMenu.Name = "acercaDeMenu";
            this.acercaDeMenu.Size = new System.Drawing.Size(180, 22);
            this.acercaDeMenu.Text = "Acerca De";
            this.acercaDeMenu.Click += new System.EventHandler(this.acercaDeMenu_Click_1);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.InitialImage = null;
            this.pb_Imagen.Location = new System.Drawing.Point(12, 34);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(310, 200);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 3;
            this.pb_Imagen.TabStop = false;
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.ct_Velocidad);
            this.Controls.Add(this.et_Velocidad);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.bt_Iniciar);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.bp_Progreso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hilos";
            this.Text = "Hilos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hilos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bp_Progreso;
        private System.Windows.Forms.Button bt_Mostrar;
        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.Label et_Velocidad;
        private System.Windows.Forms.NumericUpDown ct_Velocidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoMenu;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenu;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMenu;
        private System.Windows.Forms.ToolStripMenuItem detenerMenu;
    }
}

