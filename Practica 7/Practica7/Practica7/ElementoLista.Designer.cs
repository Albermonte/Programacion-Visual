namespace Practica7
{
    partial class ElementoLista
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgFamoso = new System.Windows.Forms.PictureBox();
            this.famosoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etFechaNaci = new System.Windows.Forms.Label();
            this.etApellidos = new System.Windows.Forms.Label();
            this.etNombre = new System.Windows.Forms.Label();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etNomApEdad = new System.Windows.Forms.Label();
            this.ttElementoLista = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFamoso
            // 
            this.imgFamoso.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.famosoBindingSource, "Imagen", true));
            this.imgFamoso.Location = new System.Drawing.Point(21, 17);
            this.imgFamoso.Name = "imgFamoso";
            this.imgFamoso.Size = new System.Drawing.Size(105, 120);
            this.imgFamoso.TabIndex = 1;
            this.imgFamoso.TabStop = false;
            // 
            // famosoBindingSource
            // 
            this.famosoBindingSource.DataSource = typeof(BDFamosos.CFamosoBO);
            // 
            // etFechaNaci
            // 
            this.etFechaNaci.AutoSize = true;
            this.etFechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etFechaNaci.Location = new System.Drawing.Point(137, 120);
            this.etFechaNaci.Name = "etFechaNaci";
            this.etFechaNaci.Size = new System.Drawing.Size(131, 13);
            this.etFechaNaci.TabIndex = 14;
            this.etFechaNaci.Text = "Fecha de Nacimiento:";
            // 
            // etApellidos
            // 
            this.etApellidos.AutoSize = true;
            this.etApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etApellidos.Location = new System.Drawing.Point(201, 92);
            this.etApellidos.Name = "etApellidos";
            this.etApellidos.Size = new System.Drawing.Size(62, 13);
            this.etApellidos.TabIndex = 13;
            this.etApellidos.Text = "Apellidos:";
            // 
            // etNombre
            // 
            this.etNombre.AutoSize = true;
            this.etNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNombre.Location = new System.Drawing.Point(206, 60);
            this.etNombre.Name = "etNombre";
            this.etNombre.Size = new System.Drawing.Size(54, 13);
            this.etNombre.TabIndex = 12;
            this.etNombre.Text = "Nombre:";
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Cumple", true));
            this.txtFechaNaci.Location = new System.Drawing.Point(272, 117);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(159, 20);
            this.txtFechaNaci.TabIndex = 11;
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Apellidos", true));
            this.txtApellidos.Location = new System.Drawing.Point(272, 89);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(159, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(272, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // etNomApEdad
            // 
            this.etNomApEdad.AutoSize = true;
            this.etNomApEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "NombreAprellidosEdad", true));
            this.etNomApEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNomApEdad.Location = new System.Drawing.Point(135, 20);
            this.etNomApEdad.Name = "etNomApEdad";
            this.etNomApEdad.Size = new System.Drawing.Size(211, 20);
            this.etNomApEdad.TabIndex = 8;
            this.etNomApEdad.Text = "Apellidos, Nombre (edad)";
            // 
            // ElementoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.etFechaNaci);
            this.Controls.Add(this.etApellidos);
            this.Controls.Add(this.etNombre);
            this.Controls.Add(this.txtFechaNaci);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etNomApEdad);
            this.Controls.Add(this.imgFamoso);
            this.Name = "ElementoLista";
            this.Size = new System.Drawing.Size(444, 157);
            this.Load += new System.EventHandler(this.ElementoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFamoso;
        private System.Windows.Forms.BindingSource famosoBindingSource;
        private System.Windows.Forms.Label etFechaNaci;
        private System.Windows.Forms.Label etApellidos;
        private System.Windows.Forms.Label etNombre;
        private System.Windows.Forms.TextBox txtFechaNaci;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label etNomApEdad;
        private System.Windows.Forms.ToolTip ttElementoLista;
    }
}
