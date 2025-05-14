namespace _2.odevi
{
    partial class Form1
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
            this.filesecimi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yukle = new System.Windows.Forms.Button();
            this.basla = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesecimi
            // 
            this.filesecimi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.filesecimi.AutoCompleteCustomSource.AddRange(new string[] {
            "YOKDIL Fen Bilimleri",
            "YOKDIL Sosyal Bilimler"});
            this.filesecimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.filesecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filesecimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesecimi.FormattingEnabled = true;
            this.filesecimi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.filesecimi.Location = new System.Drawing.Point(56, 83);
            this.filesecimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filesecimi.Name = "filesecimi";
            this.filesecimi.Size = new System.Drawing.Size(329, 44);
            this.filesecimi.TabIndex = 0;
            this.filesecimi.TabStop = false;
            this.filesecimi.SelectedIndexChanged += new System.EventHandler(this.filesecimi_SelectedIndexChanged);
            this.filesecimi.MouseEnter += new System.EventHandler(this.filesecimi_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filesecimi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(438, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sözlük";
            // 
            // yukle
            // 
            this.yukle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.yukle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yukle.Location = new System.Drawing.Point(68, 38);
            this.yukle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yukle.Name = "yukle";
            this.yukle.Size = new System.Drawing.Size(304, 138);
            this.yukle.TabIndex = 3;
            this.yukle.Text = "Yükle";
            this.yukle.UseVisualStyleBackColor = false;
            this.yukle.Click += new System.EventHandler(this.yukle_Click);
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.basla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.basla.Location = new System.Drawing.Point(68, 186);
            this.basla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(304, 143);
            this.basla.TabIndex = 4;
            this.basla.Text = "Başla";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.White;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(532, 311);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(292, 49);
            this.cikis.TabIndex = 5;
            this.cikis.Text = "çıkıç";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            this.cikis.MouseEnter += new System.EventHandler(this.cikis_MouseEnter);
            this.cikis.MouseLeave += new System.EventHandler(this.cikis_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 412);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.yukle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sözlük Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox filesecimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yukle;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Button cikis;
    }
}

