using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESERCIZI_FOGLIO_1_2
{
    public partial class Es_Folgio_1_2 : Form
    {
        public Es_Folgio_1_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_x1_Click(object sender, EventArgs e)
        {

        }

        private void calcola_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            a = Convert.ToDouble(txb_a.Text);
            b = Convert.ToDouble(txb_b.Text);
            c = Convert.ToDouble(txb_c.Text);
            delta = Math.Pow(b,2)+(-4*a*c);
            if (delta < 0)
            {
                Risultato_esito.Text = "Nessuna soluzione reale";
                Risultato_esito.ForeColor = Color.DarkRed;
                result_x1.ForeColor = Color.DarkRed;
                result_x2.ForeColor = Color.DarkRed;
            } else if (delta == 0)
            {
                Risultato_esito.ForeColor = Color.Black;
                result_x1.ForeColor = Color.Black;
                result_x2.ForeColor = Color.Black;
                Risultato_esito.Text = "Sue soluzioni reali e coincidenti";
                x1 = ( -b ) / ( 2 * a );
                result_x1.Text = Convert.ToString(x1);
                result_x2.Text = Convert.ToString(x1);
            } else
            {
                Risultato_esito.ForeColor = Color.Black;
                result_x1.ForeColor = Color.Black;
                result_x2.ForeColor = Color.Black;
                Risultato_esito.Text = "Soluzione reali e distinte";
                x1 = ( ( -b ) + delta )/ ( 2 * a );
                x2 = ( ( -b ) - delta )/ ( 2 * a );
                result_x1.Text = Convert.ToString(x1);
                result_x2.Text = Convert.ToString(x2);
            }
        }
    }
}
