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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DateTime prvnidatum = new DateTime();
        DateTime druhydatum = new DateTime();
        TimeSpan rozdil;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            prvnidatum = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            druhydatum = DateTime.Now;
            rozdil = druhydatum - prvnidatum;
            MessageBox.Show("Minut: "+ rozdil.Minutes.ToString() +" Sekund "+ rozdil.Seconds.ToString());
        }
    }
}
