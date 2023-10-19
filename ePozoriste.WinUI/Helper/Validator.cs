using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ePozoriste.WinUI.Helper
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string kljuc)
        {
            var valid = true;
            if (kontrola is TextBox && string.IsNullOrWhiteSpace(kontrola.Text))
                valid = false;
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
                valid = false;
            else if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
                valid = false;

            if (!valid)
            {
                err.SetError(kontrola, Resursi.Get(kljuc));
            }
            else
                err.Clear();
            return valid;
        }

        public static bool ValidirajEmail(Control kontrola, ErrorProvider err, string kljuc)
        {
            if (!Regex.IsMatch(kontrola.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                err.SetError(kontrola, Resursi.Get(kljuc));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidirajBrTelefona(Control kontrola, ErrorProvider err, string kljuc)
        {
            if (!Regex.IsMatch(kontrola.Text, @"^\d{3}-\d{3}-(\d{4}|\d{3})$"))
            {
                err.SetError(kontrola, Resursi.Get(kljuc));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidirajLozinku(Control kontrola, ErrorProvider err, string kljuc)
        {
            if (string.IsNullOrWhiteSpace(kontrola.Text.ToString()) || kontrola.Text.Length < 8)
            {
                err.SetError(kontrola, Resursi.Get(kljuc));
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidirajVrijemeTrajanja(Control kontrola, ErrorProvider err)
        {
            if (string.IsNullOrWhiteSpace(kontrola.Text) || !int.TryParse(kontrola.Text, out int vrijednost) || vrijednost < 10)
            {
                err.SetError(kontrola, "Vrijeme trajanja mora biti broj veći od 10.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidirajBroj(Control kontrola, ErrorProvider err)
        {
            if (string.IsNullOrWhiteSpace(kontrola.Text) || !int.TryParse(kontrola.Text, out int vrijednost) || vrijednost <= 0)
            {
                err.SetError(kontrola, "Morate unijeti broj veći od 0.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
