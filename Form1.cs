using System;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int intObergrenze = 201;
            int intUntergrenze = 1;
            int ZufallsZahl;

            Random objZufallsZahl = new Random();

            ZufallsZahl = objZufallsZahl.Next(intUntergrenze, intObergrenze);

            this.textBox2.Text = ZufallsZahl.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strCaption;
            string strEingabeZahl1;
            string strEingabeZahl2;
            int intEingabeZahl1;
            int intEingabeZahl2;
            string strEingabeErgebnis;
            int intEingabeErgebnis;
            bool canConvertZahl2;
            bool canConvertErgebnis;
            //#############################################################################################
            //######1.Überprüfung,ob Zahl_2 und Ergenbis Eingabe auch numerisch sind (Keine Buchstaben)
            //############################################################################################
            strEingabeZahl1 = textBox2.Text;
            intEingabeZahl1 = System.Convert.ToInt32(strEingabeZahl1);

            strEingabeZahl2 = textBox1.Text;
            strEingabeErgebnis = textBox3.Text;

            canConvertZahl2 = int.TryParse(strEingabeZahl2, out intEingabeZahl2);
            canConvertErgebnis = int.TryParse(strEingabeErgebnis, out intEingabeErgebnis);
            if ((canConvertZahl2 == true) && (canConvertErgebnis == true))
            {
                if ((strEingabeZahl2.All(char.IsNumber) == true) && (strEingabeErgebnis.All(char.IsNumber) == true))
                {
                    intEingabeZahl2 = System.Convert.ToInt32(strEingabeZahl2);
                    intEingabeErgebnis = System.Convert.ToInt32(strEingabeErgebnis);
                }
                else
                {
                    MessageBox.Show("Es sind nur Zahlen erlaubt.", "Ungueltige Eingabe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                } 
              
               
                   
               
            }
else
   {
                    MessageBox.Show("Bitte eine Zahl eingeben.", "Ungueltige Eingabe", MessageBoxButtons.OK,
                                      MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                                      MessageBoxOptions.DefaultDesktopOnly);
                    return;
}  
            string strText;
            int intErgebnis;
            //########################################################################
            //######2.Berechnen des tatsächlichen Ergebnis aus der Multiplikation
            //########################################################################
            intErgebnis = intEingabeZahl1 * intEingabeZahl2;

            //##################################################################################
            //######3.Überprüfung,ob tasächliches Ergebnis dem Ergebnis des Users entspricht
            //###################################################################################

            canConvertZahl2 = int.TryParse(strEingabeZahl2, out intEingabeZahl2);
            canConvertErgebnis = int.TryParse(strEingabeErgebnis, out intEingabeErgebnis);

            if ((canConvertZahl2 == true) && (canConvertErgebnis == true))
            { 
                if (intErgebnis == intEingabeErgebnis)
                {
                    strText = "Richtig berechnet.";
                    strCaption = "Ergebnis";
                    MessageBox.Show(strText, strCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);


                }
                else
                {
                    strText = "Nicht korrekt. Das richtige Ergebnis lautet: " + intErgebnis;
                    strCaption = "Ergebnis";
                    MessageBox.Show(strText, strCaption,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                
           
            }
        
            else
            {
                MessageBox.Show("Nur Zahlen erlaubt.", "Ungueltige Eingabe", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                double dblErgebnis;
                string strText;
                string strCaption;
                string strEingabeZahl1;
                string strEingabeZahl2;
                double dblEingabeZahl1;
                double dblEingabeZahl2;
                string strEingabeErgebnis;
                double dblEingabeErgebnis;
                bool canConvertZahl2;
                bool canConvertErgebnis;

                strEingabeZahl1 = textBox2.Text;
                //eigentlich nur dblEingabeZahl1 = System.Convert.ToDouble(strEingabeZahl1); aber weil immer ob schmirt des
                if (canConvertZahl2 = double.TryParse(strEingabeZahl1, out dblEingabeZahl1))
                {
dblEingabeZahl1 = System.Convert.ToDouble(strEingabeZahl1);
                }
                else
                {
                    MessageBox.Show("Bitte eine Zahl eingeben.", "Ungueltige Eingabe", MessageBoxButtons.OK,
                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }

                strEingabeZahl2 = textBox1.Text;
                strEingabeErgebnis = textBox4.Text;

                //TODO: auf eingabe 0 prüfen, und  komma Zahl eingabe ermöglichen
                // strEingabeZahl2.All(char.IsNumber) == true Problem mit z.B.: 3,5 ',' IsNumber = false
                // Lösung: double.TryParse

                canConvertZahl2 = double.TryParse(strEingabeZahl2, out dblEingabeZahl2);
                canConvertErgebnis = double.TryParse(strEingabeErgebnis, out dblEingabeErgebnis);

                if ((canConvertZahl2 == true) && (canConvertErgebnis == true))
                {
                    if (dblEingabeZahl2 != 0)
                    {
                        dblErgebnis = dblEingabeZahl1 / dblEingabeZahl2;
                        //dblErgebnis = Math.Round(dblErgebnis, 2);
                        if (dblErgebnis == dblEingabeErgebnis)
                        {
                            strText = "Richtig";
                            strCaption = "Ergebnis";
                            MessageBox.Show(strText, strCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            strCaption = "Ergebnis";
                            strText = "Falsch, das Ergebnis lautet: " + System.Convert.ToString(dblErgebnis);
                            MessageBox.Show(strText,
                                strCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zahl 2 darf nicht 0 sein. Division durch 0 ist nicht erlaubt.", "Ungueltige Eingabe", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte eine Zahl eingeben.", "Ungueltige Eingabe", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
            }

        }
    }
}

       


            

//##################################################################################
//######3.Überprüfung,ob tasächliches Ergebnis dem Ergebnis des Users entspricht
//###################################################################################


 
