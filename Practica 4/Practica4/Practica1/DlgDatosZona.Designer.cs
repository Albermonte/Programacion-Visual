namespace Practica3
{
    partial class DlgDatosZona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ct_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_DiffHora = new Practica3.EditHora();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Positivo = new System.Windows.Forms.RadioButton();
            this.rb_Negativo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // ct_Nombre
            // 
            this.ct_Nombre.Location = new System.Drawing.Point(80, 31);
            this.ct_Nombre.Name = "ct_Nombre";
            this.ct_Nombre.Size = new System.Drawing.Size(285, 20);
            this.ct_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diferencia horaria:";
            // 
            // ct_DiffHora
            // 
            this.ct_DiffHora.BeepOnError = true;
            this.ct_DiffHora.Hora = new System.DateTime(((long)(0)));
            this.ct_DiffHora.Location = new System.Drawing.Point(125, 76);
            this.ct_DiffHora.Mask = "90:00:99";
            this.ct_DiffHora.Name = "ct_DiffHora";
            this.ct_DiffHora.PromptChar = '-';
            this.ct_DiffHora.Size = new System.Drawing.Size(100, 20);
            this.ct_DiffHora.TabIndex = 2;
            this.ct_DiffHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_DiffHora.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(406, 30);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 5;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(406, 59);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 6;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Signo:";
            // 
            // rb_Positivo
            // 
            this.rb_Positivo.AutoSize = true;
            this.rb_Positivo.Checked = true;
            this.rb_Positivo.Location = new System.Drawing.Point(297, 78);
            this.rb_Positivo.Name = "rb_Positivo";
            this.rb_Positivo.Size = new System.Drawing.Size(62, 17);
            this.rb_Positivo.TabIndex = 3;
            this.rb_Positivo.TabStop = true;
            this.rb_Positivo.Text = "Positivo";
            this.rb_Positivo.UseVisualStyleBackColor = true;
            this.rb_Positivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Negativo
            // 
            this.rb_Negativo.AutoSize = true;
            this.rb_Negativo.Location = new System.Drawing.Point(297, 101);
            this.rb_Negativo.Name = "rb_Negativo";
            this.rb_Negativo.Size = new System.Drawing.Size(68, 17);
            this.rb_Negativo.TabIndex = 4;
            this.rb_Negativo.Text = "Negativo";
            this.rb_Negativo.UseVisualStyleBackColor = true;
            // 
            // DlgDatosZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(510, 142);
            this.Controls.Add(this.rb_Negativo);
            this.Controls.Add(this.rb_Positivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.ct_DiffHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DlgDatosZona";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Datos de zona horaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_Nombre;
        private System.Windows.Forms.Label label2;
        private EditHora ct_DiffHora;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_Positivo;
        private System.Windows.Forms.RadioButton rb_Negativo;
    }
}