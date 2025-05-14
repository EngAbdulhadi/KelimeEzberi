using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2.odevi.Resources;
using static _2.odevi.Resources.BackEnd;

namespace _2.odevi.models
{
    public partial class Form2 : Form
    {
        private List<Word> kelimeler;
        private KelimeYonetici yonetici;
        private Soru aktifSoru;
        private int kelimeSayaci = 1;
        private int click;
        private int sonuc;

        public Form2(List<Word> kelimeler)
        {
            InitializeComponent();
            this.kelimeler = kelimeler;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            yonetici = new KelimeYonetici(kelimeler);
            GosterYeniSoru();
            Sonuc.Text = "sonuc : 0";
            SoruSirasi.Text = $"Soru: {kelimeSayaci} / 1000";
        }

        private void GosterYeniSoru()
        {
            if (yonetici.BittiMi())
            {
                MessageBox.Show("Tebrikler! Tüm kelimeleri bitirdiniz.");
                this.Close();
                return;
            }

            aktifSoru = yonetici.YeniSoru();
            ing.Text = aktifSoru.English;

            List<Button> buttons = new List<Button> { cevap1, cevap2, cevap3, cevap4 };
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = aktifSoru.Options[i];
                buttons[i].BackColor = SystemColors.Control;
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
            {
                Application.Exit();
            }

        private void cevap_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == aktifSoru.CorrectTurkish)
            {
                kelimeSayaci++;
                SoruSirasi.Text = $"Soru: {kelimeSayaci} / 1000";
                click++;

                if (click == 1)
                {
                    sonuc += 10;
                    Sonuc.Text = "sonuc :" + sonuc;
                    click = 0;
                }

                GosterYeniSoru();
            }
            else
            {
                click = -1;
                btn.BackColor = Color.Red;
            }
           
        }
    }
}
