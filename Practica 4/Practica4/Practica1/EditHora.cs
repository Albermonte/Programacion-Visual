using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    internal class EditHora : MaskedTextBox
    {
        private DateTime m_Hora;
        public DateTime Hora { get; set; }

        public EditHora()
        {
            this.Mask = "90:00:99";
            this.TextAlign = HorizontalAlignment.Center;
            this.BeepOnError = true;
            this.PromptChar = '-';
            this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
        public bool HoraValida
        {
            get
            {
                if (!this.MaskCompleted)
                    return false;
                string aux = this.Text.Replace(this.PromptChar, '0');
                DateTime hora = new DateTime();
                if (!DateTime.TryParse(aux, out hora))
                    return false; // hora no correcta

                this.Hora = hora;
                return true; // hora correcta
            }
        }
    }
}
