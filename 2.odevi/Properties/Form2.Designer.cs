namespace _2.odevi.models
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ing = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.Label();
            this.SoruSirasi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cevap2 = new System.Windows.Forms.Button();
            this.cevap4 = new System.Windows.Forms.Button();
            this.cevap3 = new System.Windows.Forms.Button();
            this.cevap1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ing
            // 
            this.ing.AutoSize = true;
            this.ing.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ing.Location = new System.Drawing.Point(306, 25);
            this.ing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ing.Name = "ing";
            this.ing.Size = new System.Drawing.Size(379, 135);
            this.ing.TabIndex = 0;
            this.ing.Text = "label1";
            this.ing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sonuc.Location = new System.Drawing.Point(794, 47);
            this.Sonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(95, 36);
            this.Sonuc.TabIndex = 1;
            this.Sonuc.Text = "label2";
            // 
            // SoruSirasi
            // 
            this.SoruSirasi.AutoSize = true;
            this.SoruSirasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoruSirasi.Location = new System.Drawing.Point(54, 47);
            this.SoruSirasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoruSirasi.Name = "SoruSirasi";
            this.SoruSirasi.Size = new System.Drawing.Size(95, 36);
            this.SoruSirasi.TabIndex = 2;
            this.SoruSirasi.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.SoruSirasi);
            this.panel1.Controls.Add(this.Sonuc);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 154);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.ing);
            this.panel2.Location = new System.Drawing.Point(-4, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 180);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.cevap2);
            this.panel3.Controls.Add(this.cevap4);
            this.panel3.Controls.Add(this.cevap3);
            this.panel3.Controls.Add(this.cevap1);
            this.panel3.Location = new System.Drawing.Point(-4, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 384);
            this.panel3.TabIndex = 10;
            // 
            // cevap2
            // 
            this.cevap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap2.Location = new System.Drawing.Point(507, 17);
            this.cevap2.Name = "cevap2";
            this.cevap2.Size = new System.Drawing.Size(382, 138);
            this.cevap2.TabIndex = 14;
            this.cevap2.Text = "button4";
            this.cevap2.UseVisualStyleBackColor = true;
            this.cevap2.Click += new System.EventHandler(this.cevap_Click);
            // 
            // cevap4
            // 
            this.cevap4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap4.Location = new System.Drawing.Point(507, 189);
            this.cevap4.Name = "cevap4";
            this.cevap4.Size = new System.Drawing.Size(382, 138);
            this.cevap4.TabIndex = 13;
            this.cevap4.Text = "button3";
            this.cevap4.UseVisualStyleBackColor = true;
            this.cevap4.Click += new System.EventHandler(this.cevap_Click);
            // 
            // cevap3
            // 
            this.cevap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap3.Location = new System.Drawing.Point(60, 190);
            this.cevap3.Name = "cevap3";
            this.cevap3.Size = new System.Drawing.Size(382, 137);
            this.cevap3.TabIndex = 12;
            this.cevap3.Text = "button2";
            this.cevap3.UseVisualStyleBackColor = true;
            this.cevap3.Click += new System.EventHandler(this.cevap_Click);
            // 
            // cevap1
            // 
            this.cevap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap1.Location = new System.Drawing.Point(60, 17);
            this.cevap1.Name = "cevap1";
            this.cevap1.Size = new System.Drawing.Size(382, 138);
            this.cevap1.TabIndex = 11;
            this.cevap1.Text = "button1";
            this.cevap1.UseVisualStyleBackColor = true;
            this.cevap1.Click += new System.EventHandler(this.cevap_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kelime Oyunu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ing;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Label SoruSirasi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cevap2;
        private System.Windows.Forms.Button cevap4;
        private System.Windows.Forms.Button cevap3;
        private System.Windows.Forms.Button cevap1;
    }
}