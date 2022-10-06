using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampel_System
{
    public partial class Form1 : Form
    {

        public int GeneratedNumber { get; set; }
        public int Versuche { get; set; }

        public bool GameStarted { get; set; }

        public bool Gewonnen { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Los gehts";
            zahlGenerieren();
            textBox4.Text = GeneratedNumber.ToString();
            GameStarted = true;
        }

        private void zahlGenerieren()
        {
            int num = new Random().Next(0, 100);
            this.GeneratedNumber = num;
            Versuche = 3;
            label3.Text = Versuche.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(!GameStarted)
            {
                textBox1.Text = "Klicke bitte auf START";
                return;
            }
            
            
            try
            {

           
            if (Versuche == 0)
            {
                textBox1.Text = "Verloren";
                GameStarted = false;
                return;
            }
                int zahl;
                bool isValidNumber = int.TryParse(textBox2.Text,out zahl);

                if(isValidNumber)
                {

                }
                else
                {
                    textBox1.Text = "Bitte eine gültige Zahl eingeben";
                    return;
                }
                //int zahl = int.Parse(textBox2.Text);

            if (zahl == GeneratedNumber)
            {
                textBox1.Text = "Gewonnen";
                    GameStarted = false;
                    Gewonnen = true;
                }
            else if (zahl > GeneratedNumber)
            {
                textBox1.Text = "Zahl ist zu groß";
            }
            else
            {
                textBox1.Text = "Zahl ist zu klein";
            }

            Versuche = Versuche - 1;
            label3.Text = Versuche.ToString();

            if (Versuche == 0 && !Gewonnen)
            {
                textBox1.Text = "Verloren";
                    GameStarted = false;
                    return;
            }
            }
            catch (Exception)
            {
                textBox1.Text = "Bitte eine gültige Zahl eingeben";
            }


        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
