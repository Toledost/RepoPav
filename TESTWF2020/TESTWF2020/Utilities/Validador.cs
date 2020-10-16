using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWF2020.Utilities
{
    public static class Validador
    {
        public static bool ValidarTextBox(params TextBox[] listaTxt)
        {
            foreach (var txt in listaTxt)
            {
                if (string.IsNullOrEmpty(txt.Text) || txt.Text == "0")
                {
                    MessageBox.Show($"Falta completar {txt.Tag}", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarComboBox(params ComboBox[] listaCbo)
        {
            foreach (var combo in listaCbo)
            {
                if (combo.SelectedIndex == -1)
                {
                    MessageBox.Show($"Falta completar {combo.Tag}", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarSalir()
        {
            DialogResult dr = MessageBox.Show("¿Seguro que desea salir sin grabar cambios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
