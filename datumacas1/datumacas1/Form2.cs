using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datumacas1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Pocet dni od narozenin 17: " + (PocetDni(dateTimePicker1, 17)).ToString());
            MessageBox.Show("Pocet dni od narozeni: " + (PocetDni(dateTimePicker1, 0)).ToString());
            MessageBox.Show("Pocet dni do duchodu: " + (PocetDni(dateTimePicker1, 65)).ToString());
        }

        private int PocetDni(DateTimePicker datum, int pocet)
        {
            TimeSpan rozdil;
            DateTime jj = new DateTime();
            jj = datum.Value;
            jj = jj.AddYears(pocet);
            rozdil = DateTime.Now - jj;
            pocet = rozdil.Days;
            return pocet;
        }
    }
}
