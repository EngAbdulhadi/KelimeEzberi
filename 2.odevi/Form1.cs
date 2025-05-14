// Form1.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using _2.odevi.models;
using _2.odevi.Resources;

namespace _2.odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basla.Enabled = false;
            basla.BackColor = Color.White;
            yukle.Enabled = false;
            yukle.BackColor = Color.White;
        }

        private void filesecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            yukle.Enabled = true;
            yukle.BackColor = Color.LightBlue;
        }

        private void filesecimi_MouseEnter(object sender, EventArgs e)
        {
            filesecimi.Items.Clear();
            filesecimi.Items.Add("YOKDIL Fen Bilimleri");
            filesecimi.Items.Add("YOKDIL Sosyal Bilimler");
        }

        private void basla_Click(object sender, EventArgs e)
        {

            string secilenDosya = "";

            

            if (filesecimi.SelectedIndex == 0)
            {
                secilenDosya = "YOKDIL Fen Bilimleri.txt";
            }
            else if (filesecimi.SelectedIndex == 1)
            {
                secilenDosya = "YOKDIL Sosyal Bilimler.txt";
            }




            BackEnd backend = new BackEnd();
            var kelimeler = backend.TxtdenOku(secilenDosya);

            Form2 form2 = new Form2(kelimeler);
            form2.Show();
            this.Hide();
        }


        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cikis_MouseEnter(object sender, EventArgs e)
        {
            cikis.BackColor = Color.Red;
        }

        private void cikis_MouseLeave(object sender, EventArgs e)
        {
            cikis.BackColor = Color.White;
        }

        private void yukle_Click(object sender, EventArgs e)
        {



            basla.BackColor = Color.LightGreen;
            basla.Enabled = true;
        }
    }
}