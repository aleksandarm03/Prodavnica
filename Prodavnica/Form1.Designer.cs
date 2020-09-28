namespace WindowsFormsApplication1
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
            this.tbProizvod = new System.Windows.Forms.TextBox();
            this.tbNovaCena = new System.Windows.Forms.TextBox();
            this.tbNaziv2 = new System.Windows.Forms.TextBox();
            this.tbProizvodjac2 = new System.Windows.Forms.TextBox();
            this.tbCena2 = new System.Windows.Forms.TextBox();
            this.tbPoruka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProizvod
            // 
            this.tbProizvod.Location = new System.Drawing.Point(12, 12);
            this.tbProizvod.Name = "tbProizvod";
            this.tbProizvod.Size = new System.Drawing.Size(207, 20);
            this.tbProizvod.TabIndex = 0;
            // 
            // tbNovaCena
            // 
            this.tbNovaCena.Location = new System.Drawing.Point(6, 19);
            this.tbNovaCena.Name = "tbNovaCena";
            this.tbNovaCena.Size = new System.Drawing.Size(100, 20);
            this.tbNovaCena.TabIndex = 1;
            // 
            // tbNaziv2
            // 
            this.tbNaziv2.Location = new System.Drawing.Point(83, 28);
            this.tbNaziv2.Name = "tbNaziv2";
            this.tbNaziv2.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv2.TabIndex = 2;
            // 
            // tbProizvodjac2
            // 
            this.tbProizvodjac2.Location = new System.Drawing.Point(83, 54);
            this.tbProizvodjac2.Name = "tbProizvodjac2";
            this.tbProizvodjac2.Size = new System.Drawing.Size(100, 20);
            this.tbProizvodjac2.TabIndex = 3;
            // 
            // tbCena2
            // 
            this.tbCena2.Location = new System.Drawing.Point(83, 77);
            this.tbCena2.Name = "tbCena2";
            this.tbCena2.Size = new System.Drawing.Size(100, 20);
            this.tbCena2.TabIndex = 4;
            // 
            // tbPoruka
            // 
            this.tbPoruka.Location = new System.Drawing.Point(12, 229);
            this.tbPoruka.Name = "tbPoruka";
            this.tbPoruka.Size = new System.Drawing.Size(207, 20);
            this.tbPoruka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Promeni cenu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Uporedi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNovaCena);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Cena";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNaziv2);
            this.groupBox2.Controls.Add(this.tbProizvodjac2);
            this.groupBox2.Controls.Add(this.tbCena2);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drugi proizvod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proizvodjac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPoruka);
            this.Controls.Add(this.tbProizvod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProizvod;
        private System.Windows.Forms.TextBox tbNovaCena;
        private System.Windows.Forms.TextBox tbNaziv2;
        private System.Windows.Forms.TextBox tbProizvodjac2;
        private System.Windows.Forms.TextBox tbCena2;
        private System.Windows.Forms.TextBox tbPoruka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

