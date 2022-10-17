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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime vybrano = new DateTime();
            vybrano = dateTimePicker1.Value;
            string den = vybrano.DayOfWeek.ToString();
            MessageBox.Show(den);
            switch (den)
            {
                case "Monday":
                    {
                        MessageBox.Show("První pracovní den!");
                        break;
                    }

                case "Tuesday":
                    {
                        MessageBox.Show("pracovní den!");
                        break;
                    }
                case "Wednesday":
                    {
                        MessageBox.Show("pracovní den!");
                        break;
                        
                    }
                case "Thursday":
                    {
                        MessageBox.Show("pracovní den!");
                        break;
                    }
                case "Friday":
                    {
                        MessageBox.Show("pracovní den!");
                        break;
                    }
                case "Sunday":
                    {
                        MessageBox.Show("Nedele");
                        break;
                    }
                case "Saturday":
                    {
                        MessageBox.Show("Sobota");
                        break;
                    }

            }
        }
    }
}
