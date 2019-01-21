using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner

//https://www.youtube.com/watch?v=xf07kYWurzY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            
           //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            //Liest die Zahlen ein
            var Zahl1 = Convert.ToDouble(textBox1.Text);
            /*Theoretisch sind die Eingaben noch ganz normale Zeichenketten, mit der Convert Méthode konvertieren 
             * wir das ganze in eine Zahl mit Kommastellen (normale Zahl wäre Convert.ToInt32)*/
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            //Berechnung:
            var erg = Zahl1 + Zahl2;
            //Ausgabe von Zahl in einen String für die TextBox
            textBoxErg.Text = erg.ToString();

            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " + " + Zahl2+" = "+erg;

          
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 - Zahl2;
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " - " + Zahl2 + " = " + erg;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 / Zahl2;
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " / " + Zahl2 + " = " + erg;
        }

        private void buttonProzentAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 + (Zahl1 / 100 * Zahl2);
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " + " + Zahl2 + "% = " + erg;
        }

        private void buttonProzentSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 - (Zahl1 / 100 * Zahl2);
            textBoxErg.Text = erg.ToString();

            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " - " + Zahl2 + "% = " + erg;

        }

        private void buttonProzentModulo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = true;
            label11.Visible = true;

            int Zahl1 = Convert.ToInt32(textBox1.Text);
            int Zahl2 = Convert.ToInt32(textBox2.Text);
            int erg = Zahl1 % Zahl2;

            //Zur Verdeutlichung Variablen einer normalen Division
            int erg2 = Zahl1 / Zahl2;
            
            label11.Text = erg.ToString(); //Ausgabe des Modolo Wertes
            textBoxErg.Text = erg2.ToString(); //Ausgabe der Division ohne Komma
          //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " / " + Zahl2 + " = " + erg+" Rest "+erg2;
        }

        private void buttonProzent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible=true;
            //% Label Zahl 2
            label8.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl2 * 100 / Zahl1;
            textBoxErg.Text = erg.ToString();
            buttonProzent.Text= ("% Angabe ("+erg+"%) von Zahl 1 ("+Zahl1+")");
            //<Lösungsweg> Label
            //zahl2 von zahl1 ist soviel %
            label14.Visible = true;
            label14.Text = "" + Zahl2 + " von " + Zahl1 + " = " + erg+ " %\n(Zahl2 * 100 / Zahl1)";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 * Zahl2;
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "" + Zahl1 + " * " + Zahl2 + " = " + erg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //schließt jediglich die Form!
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setze die Boxen auf 0
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        //private void Form1_KeyDown_1(object sender, KeyEventArgs e) //Key drücken Event
        //{
            
        //    if (e.KeyCode == Keys.NumPad0) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "0"; //Aktion die gemacht werden soll!
        //        //buttonAdd.PerformClick(); -> Button betätigen
        //    }
        //    if (e.KeyCode == Keys.NumPad1) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "1"; //Aktion die gemacht werden soll!
        //        //buttonAdd.PerformClick(); -> Button betätigen
        //    }
        //    if (e.KeyCode == Keys.NumPad2) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "2"; //Aktion die gemacht werden soll!
        //        //buttonAdd.PerformClick(); -> Button betätigen
        //    }
        //    if (e.KeyCode == Keys.NumPad3) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "3"; //Aktion die gemacht werden soll!
        //        //buttonAdd.PerformClick(); -> Button betätigen
        //    }
        //    if (e.KeyCode == Keys.NumPad4) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "4"; //Aktion die gemacht werden soll!
        //        //buttonAdd.PerformClick(); -> Button betätigen
        //    }
        //    if (e.KeyCode == Keys.NumPad5) //Keys.A definierrt Taste A
        //    {
        //        textBox1.Text = "5"; //Aktion die gemacht werden soll!
        //                             //buttonAdd.PerformClick(); -> Button betätigen
        //        if (e.KeyCode == Keys.NumPad6) //Keys.A definierrt Taste A
        //        {
        //            textBox1.Text = "6"; //Aktion die gemacht werden soll!
        //                                 //buttonAdd.PerformClick(); -> Button betätigen
        //        }
        //        if (e.KeyCode == Keys.NumPad7) //Keys.A definierrt Taste A
        //        {
        //            textBox1.Text = "7"; //Aktion die gemacht werden soll!
        //                                 //buttonAdd.PerformClick(); -> Button betätigen
        //        }
        //        if (e.KeyCode == Keys.NumPad8) //Keys.A definierrt Taste A
        //        {
        //            textBox1.Text = "8"; //Aktion die gemacht werden soll!
        //                                 //buttonAdd.PerformClick(); -> Button betätigen
        //        }
        //        if (e.KeyCode == Keys.NumPad9) //Keys.A definierrt Taste A
        //        {
        //            textBox1.Text = "9"; //Aktion die gemacht werden soll!
        //                                 //buttonAdd.PerformClick(); -> Button betätigen
        //        }
        //        if (e.KeyCode == Keys.Multiply) //Keys.A definierrt Taste A
        //        {
        //            this.buttonMulti_Click(this, null) ; //Aktion die gemacht werden soll!
        //                                 //Button betätigen
        //        }
        //    }
        //}

        private void textBoxErg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
           
           // double erg = 0; //Vorher deklarieren für Schleife!
            
           //for (int i = 1; i < Zahl2; i++)
           // {
           //     erg = Zahl1;
           //     erg = erg * Zahl1; // Berechne die Potenz
           // }
            double erg = Math.Pow(Zahl1, Zahl2); //Alternativ
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "die "+Zahl2+". Potenz von " + Zahl1 + " = " + erg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            if (textBox2.Text == "")
            {
                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 2. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            // % Ergebnis Label
            label12.Visible = false;
            //% Label Zahl 2
            label8.Visible = true;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);
            var erg = Zahl1 / 100 * Zahl2;
            textBoxErg.Text = erg.ToString();
            button3.Text = ("% Zahl(Ziffer) (="+erg+") von Zahl 1 ("+Zahl1+")");

            //<Lösungsweg> Label
            //so und soviel Prozent von Zahl1 ist 
            label14.Visible = true;
            label14.Text = "" + Zahl2 + "% von " + Zahl1 + " = " + erg+ "\n(Zahl1 / 100 * Zahl2)";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Wenn Textboxen leer schmeisse fehler
            {

                System.Media.SystemSounds.Beep.Play(); //Beep
                MessageBox.Show("Bitte gib die 1. Zahl ein!", "Fehler bei Eingabe");
                return;
            }
            
            // % Ergebnis Label
            label12.Visible = false;
            //Die Modulo Labels
            label10.Visible = false;
            label11.Visible = false;

            var Zahl1 = Convert.ToDouble(textBox1.Text);
            var Zahl2 = Convert.ToDouble(textBox2.Text);

           
            double erg = Math.Sqrt(Zahl1); //Alternativ
            textBoxErg.Text = erg.ToString();
            //<Lösungsweg> Label
            label14.Visible = true;
            label14.Text = "die Wurzel aus " + Zahl1 + " = " + erg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //setze die Boxen auf 0
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
