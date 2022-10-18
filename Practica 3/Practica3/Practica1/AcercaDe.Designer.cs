using Practica3.Properties;

namespace Practica1
{
    partial class AcecaDe
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
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.creditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Aceptar.Location = new System.Drawing.Point(105, 169);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(92, 28);
            this.bt_Aceptar.TabIndex = 0;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // creditos
            // 
            this.creditos.Location = new System.Drawing.Point(38, 76);
            this.creditos.Name = "creditos";
            this.creditos.Size = new System.Drawing.Size(226, 90);
            this.creditos.TabIndex = 1;
            this.creditos.Text = "Texto";
            this.creditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcecaDe
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 239);
            this.Controls.Add(this.creditos);
            this.Controls.Add(this.bt_Aceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcecaDe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.AcecaDe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label creditos;
    }
}