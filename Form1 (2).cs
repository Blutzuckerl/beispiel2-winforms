using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beispiel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int intObergrenze = 201;
            int intUntergrenze = 1;
            int ZufallsZahl;

            Random objZufallsZahl = new Random();

            ZufallsZahl = objZufallsZahl.Next(intUntergrenze, intObergrenze);

            this.textBox1.Text = ZufallsZahl.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int intEingegebnis;
            int strText;
            string strEingabeZahl1;
            string strEingabeZahl2;
           // if (Information.IsNumeric(strEingegebeneZahl) == true)
                



    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    }

