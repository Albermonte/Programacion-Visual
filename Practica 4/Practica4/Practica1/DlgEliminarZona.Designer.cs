namespace Practica3
{
    partial class DlgEliminarZona
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Zonas = new System.Windows.Forms.ListBox();
            this.ct_Signo = new System.Windows.Forms.TextBox();
            this.ct_DiffHora = new Practica3.EditHora();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diferencia horaria:";
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Aceptar.Location = new System.Drawing.Point(323, 30);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 5;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(323, 59);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 6;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Signo:";
            // 
            // lb_Zonas
            // 
            this.lb_Zonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Zonas.FormattingEnabled = true;
            this.lb_Zonas.Location = new System.Drawing.Point(30, 30);
            this.lb_Zonas.Name = "lb_Zonas";
            this.lb_Zonas.Size = new System.Drawing.Size(272, 95);
            this.lb_Zonas.TabIndex = 7;
            this.lb_Zonas.TabStop = false;
            this.lb_Zonas.SelectedIndexChanged += new System.EventHandler(this.lb_Zonas_SelectedIndexChanged);
            // 
            // ct_Signo
            // 
            this.ct_Signo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_Signo.Location = new System.Drawing.Point(298, 159);
            this.ct_Signo.Name = "ct_Signo";
            this.ct_Signo.ReadOnly = true;
            this.ct_Signo.Size = new System.Drawing.Size(100, 20);
            this.ct_Signo.TabIndex = 8;
            this.ct_Signo.TabStop = false;
            // 
            // ct_DiffHora
            // 
            this.ct_DiffHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ct_DiffHora.BeepOnError = true;
            this.ct_DiffHora.Hora = new System.DateTime(((long)(0)));
            this.ct_DiffHora.Location = new System.Drawing.Point(126, 159);
            this.ct_DiffHora.Mask = "90:00:99";
            this.ct_DiffHora.Name = "ct_DiffHora";
            this.ct_DiffHora.PromptChar = '-';
            this.ct_DiffHora.ReadOnly = true;
            this.ct_DiffHora.Size = new System.Drawing.Size(100, 20);
            this.ct_DiffHora.TabIndex = 2;
            this.ct_DiffHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_DiffHora.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // DlgEliminarZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(411, 197);
            this.Controls.Add(this.ct_Signo);
            this.Controls.Add(this.lb_Zonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.ct_DiffHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEliminarZona";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Eliminar zona horaria";
            this.Load += new System.EventHandler(this.DlgEliminarZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private EditHora ct_DiffHora;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_Zonas;
        private System.Windows.Forms.TextBox ct_Signo;
    }
}