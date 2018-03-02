using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace verschlüsseln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verschlüsseln_Click(object sender, EventArgs e)
        {
           
        }

        private void entschlüsseld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentschl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnentschl_Click_1(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            entschlüsseltlbl.Text = "";
            label2.Text = "";
        }

        private void verzahltrack_Scroll(object sender, EventArgs e)
        {
            string eintext;      // zum verschlüsseln
            int ver = 0;             // zum verschlüsseln
            int verzahl = verzahltrack.Value;         // zum verschlüsseln


            eintext = (entschlüsseltlbl.Text);

            char[] CharEinText = eintext.ToCharArray();
            label2.Text = "";
            for (int i = 0; i < CharEinText.Length; i++)
            {
                ver = CharEinText[i];

                if (verzahl > 26)   //Großzahlen größer 
                {
                    verzahl = verzahl % 26;
                }
                if (ver >= 97 & ver <= 122)         //KLeinbuchstaben bei entschlüsseln
                {
                    if (ver + verzahl > 122)
                    {
                        ver = ver + verzahl - 26;
                    }

                    else
                    {
                        ver = ver + verzahl;
                    }
                }


                if (ver >= 65 & ver <= 90)           // Großbuchstaben bei entschlüsseln
                {
                    if (ver + verzahl > 90)
                    {
                        ver = ver + verzahl - 26;
                    }

                    else
                    {
                        ver = ver + verzahl;
                    }
                }

                Convert.ToByte(ver);
                string s = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(ver) });
                label2.Text += s;
         
           }
        }
       
    }
}


    

