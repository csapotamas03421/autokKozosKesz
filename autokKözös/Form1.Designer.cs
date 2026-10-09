namespace autokKözös
{
    partial class Autók
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
            this.dGAutok = new System.Windows.Forms.DataGridView();
            this.dGWkoltsegek = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.autokoltsegek = new System.Windows.Forms.Label();
            this.panelUjAuto = new System.Windows.Forms.Panel();
            this.btnUjMentes = new System.Windows.Forms.Button();
            this.btnUjMegsem = new System.Windows.Forms.Button();
            this.txbKm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbUzemanyag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEvjarat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRendszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKoltseg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kKm = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.kOsszeg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Kategória = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kRendszam = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.kDatum = new System.Windows.Forms.DateTimePicker();
            this.kKategoria = new System.Windows.Forms.ComboBox();
            this.ghj = new System.Windows.Forms.Label();
            this.kMegnevezes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGAutok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWkoltsegek)).BeginInit();
            this.panelUjAuto.SuspendLayout();
            this.panelKoltseg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGAutok
            // 
            this.dGAutok.AllowUserToAddRows = false;
            this.dGAutok.AllowUserToDeleteRows = false;
            this.dGAutok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAutok.Location = new System.Drawing.Point(12, 30);
            this.dGAutok.Name = "dGAutok";
            this.dGAutok.ReadOnly = true;
            this.dGAutok.RowHeadersVisible = false;
            this.dGAutok.Size = new System.Drawing.Size(703, 265);
            this.dGAutok.TabIndex = 0;
            this.dGAutok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGAutok_CellClick);
            this.dGAutok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGAutok_CellDoubleClick);
            this.dGAutok.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGAutok_HeaderClick);
            // 
            // dGWkoltsegek
            // 
            this.dGWkoltsegek.AllowUserToAddRows = false;
            this.dGWkoltsegek.AllowUserToDeleteRows = false;
            this.dGWkoltsegek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWkoltsegek.Location = new System.Drawing.Point(12, 336);
            this.dGWkoltsegek.Name = "dGWkoltsegek";
            this.dGWkoltsegek.ReadOnly = true;
            this.dGWkoltsegek.Size = new System.Drawing.Size(617, 165);
            this.dGWkoltsegek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autók adatai:";
            // 
            // autokoltsegek
            // 
            this.autokoltsegek.AutoSize = true;
            this.autokoltsegek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autokoltsegek.Location = new System.Drawing.Point(12, 315);
            this.autokoltsegek.Name = "autokoltsegek";
            this.autokoltsegek.Size = new System.Drawing.Size(0, 18);
            this.autokoltsegek.TabIndex = 4;
            this.autokoltsegek.UseMnemonic = false;
            // 
            // panelUjAuto
            // 
            this.panelUjAuto.Controls.Add(this.btnUjMentes);
            this.panelUjAuto.Controls.Add(this.btnUjMegsem);
            this.panelUjAuto.Controls.Add(this.txbKm);
            this.panelUjAuto.Controls.Add(this.label7);
            this.panelUjAuto.Controls.Add(this.txbUzemanyag);
            this.panelUjAuto.Controls.Add(this.label6);
            this.panelUjAuto.Controls.Add(this.txbEvjarat);
            this.panelUjAuto.Controls.Add(this.label5);
            this.panelUjAuto.Controls.Add(this.txbModel);
            this.panelUjAuto.Controls.Add(this.label4);
            this.panelUjAuto.Controls.Add(this.txbMarka);
            this.panelUjAuto.Controls.Add(this.label3);
            this.panelUjAuto.Controls.Add(this.txbRendszam);
            this.panelUjAuto.Controls.Add(this.label1);
            this.panelUjAuto.Location = new System.Drawing.Point(757, 40);
            this.panelUjAuto.Name = "panelUjAuto";
            this.panelUjAuto.Size = new System.Drawing.Size(382, 227);
            this.panelUjAuto.TabIndex = 5;
            // 
            // btnUjMentes
            // 
            this.btnUjMentes.Location = new System.Drawing.Point(179, 196);
            this.btnUjMentes.Name = "btnUjMentes";
            this.btnUjMentes.Size = new System.Drawing.Size(75, 23);
            this.btnUjMentes.TabIndex = 13;
            this.btnUjMentes.Text = "Mentés";
            this.btnUjMentes.UseVisualStyleBackColor = true;
            this.btnUjMentes.Click += new System.EventHandler(this.btnUjMentes_Click);
            // 
            // btnUjMegsem
            // 
            this.btnUjMegsem.Location = new System.Drawing.Point(17, 196);
            this.btnUjMegsem.Name = "btnUjMegsem";
            this.btnUjMegsem.Size = new System.Drawing.Size(75, 23);
            this.btnUjMegsem.TabIndex = 12;
            this.btnUjMegsem.Text = "Mégsem";
            this.btnUjMegsem.UseVisualStyleBackColor = true;
            this.btnUjMegsem.Click += new System.EventHandler(this.btnUjMegsem_Click);
            // 
            // txbKm
            // 
            this.txbKm.Location = new System.Drawing.Point(105, 151);
            this.txbKm.Name = "txbKm";
            this.txbKm.Size = new System.Drawing.Size(100, 20);
            this.txbKm.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "km";
            // 
            // txbUzemanyag
            // 
            this.txbUzemanyag.Location = new System.Drawing.Point(105, 124);
            this.txbUzemanyag.Name = "txbUzemanyag";
            this.txbUzemanyag.Size = new System.Drawing.Size(100, 20);
            this.txbUzemanyag.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Üzemanyag";
            // 
            // txbEvjarat
            // 
            this.txbEvjarat.Location = new System.Drawing.Point(105, 99);
            this.txbEvjarat.Name = "txbEvjarat";
            this.txbEvjarat.Size = new System.Drawing.Size(100, 20);
            this.txbEvjarat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Évjárat";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(105, 70);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(100, 20);
            this.txbModel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // txbMarka
            // 
            this.txbMarka.Location = new System.Drawing.Point(105, 44);
            this.txbMarka.Name = "txbMarka";
            this.txbMarka.Size = new System.Drawing.Size(100, 20);
            this.txbMarka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Márka:";
            // 
            // txbRendszam
            // 
            this.txbRendszam.Location = new System.Drawing.Point(105, 20);
            this.txbRendszam.Name = "txbRendszam";
            this.txbRendszam.Size = new System.Drawing.Size(100, 20);
            this.txbRendszam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // panelKoltseg
            // 
            this.panelKoltseg.Controls.Add(this.kMegnevezes);
            this.panelKoltseg.Controls.Add(this.ghj);
            this.panelKoltseg.Controls.Add(this.kKategoria);
            this.panelKoltseg.Controls.Add(this.kDatum);
            this.panelKoltseg.Controls.Add(this.button1);
            this.panelKoltseg.Controls.Add(this.button2);
            this.panelKoltseg.Controls.Add(this.kKm);
            this.panelKoltseg.Controls.Add(this.label);
            this.panelKoltseg.Controls.Add(this.kOsszeg);
            this.panelKoltseg.Controls.Add(this.label10);
            this.panelKoltseg.Controls.Add(this.Kategória);
            this.panelKoltseg.Controls.Add(this.label12);
            this.panelKoltseg.Controls.Add(this.kRendszam);
            this.panelKoltseg.Controls.Add(this.label13);
            this.panelKoltseg.Location = new System.Drawing.Point(731, 300);
            this.panelKoltseg.Name = "panelKoltseg";
            this.panelKoltseg.Size = new System.Drawing.Size(382, 227);
            this.panelKoltseg.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mégsem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kKm
            // 
            this.kKm.Location = new System.Drawing.Point(105, 127);
            this.kKm.Name = "kKm";
            this.kKm.Size = new System.Drawing.Size(100, 20);
            this.kKm.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 127);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Km";
            // 
            // kOsszeg
            // 
            this.kOsszeg.Location = new System.Drawing.Point(105, 99);
            this.kOsszeg.Name = "kOsszeg";
            this.kOsszeg.Size = new System.Drawing.Size(100, 20);
            this.kOsszeg.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Összeg";
            // 
            // Kategória
            // 
            this.Kategória.AutoSize = true;
            this.Kategória.Location = new System.Drawing.Point(14, 73);
            this.Kategória.Name = "Kategória";
            this.Kategória.Size = new System.Drawing.Size(51, 13);
            this.Kategória.TabIndex = 4;
            this.Kategória.Text = "kategória";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Dátum";
            // 
            // kRendszam
            // 
            this.kRendszam.Location = new System.Drawing.Point(105, 20);
            this.kRendszam.Name = "kRendszam";
            this.kRendszam.Size = new System.Drawing.Size(100, 20);
            this.kRendszam.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Rendszám:";
            // 
            // kDatum
            // 
            this.kDatum.Location = new System.Drawing.Point(105, 47);
            this.kDatum.Name = "kDatum";
            this.kDatum.Size = new System.Drawing.Size(100, 20);
            this.kDatum.TabIndex = 15;
            // 
            // kKategoria
            // 
            this.kKategoria.FormattingEnabled = true;
            this.kKategoria.Items.AddRange(new object[] {
            "Üzemanyag",
            "Szervíz",
            "Biztosítás",
            "Gumiabroncs",
            "Javítás",
            "Műszaki vizsga"});
            this.kKategoria.Location = new System.Drawing.Point(105, 70);
            this.kKategoria.Name = "kKategoria";
            this.kKategoria.Size = new System.Drawing.Size(100, 21);
            this.kKategoria.TabIndex = 16;
            // 
            // ghj
            // 
            this.ghj.AutoSize = true;
            this.ghj.Location = new System.Drawing.Point(17, 159);
            this.ghj.Name = "ghj";
            this.ghj.Size = new System.Drawing.Size(63, 13);
            this.ghj.TabIndex = 17;
            this.ghj.Text = "Megneveés";
            // 
            // kMegnevezes
            // 
            this.kMegnevezes.Location = new System.Drawing.Point(105, 159);
            this.kMegnevezes.Name = "kMegnevezes";
            this.kMegnevezes.Size = new System.Drawing.Size(100, 20);
            this.kMegnevezes.TabIndex = 18;
            // 
            // Autók
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 558);
            this.Controls.Add(this.panelKoltseg);
            this.Controls.Add(this.panelUjAuto);
            this.Controls.Add(this.autokoltsegek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWkoltsegek);
            this.Controls.Add(this.dGAutok);
            this.Name = "Autók";
            this.Text = "Autók";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGAutok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWkoltsegek)).EndInit();
            this.panelUjAuto.ResumeLayout(false);
            this.panelUjAuto.PerformLayout();
            this.panelKoltseg.ResumeLayout(false);
            this.panelKoltseg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGAutok;
        private System.Windows.Forms.DataGridView dGWkoltsegek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label autokoltsegek;
        private System.Windows.Forms.Panel panelUjAuto;
        private System.Windows.Forms.TextBox txbRendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUzemanyag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEvjarat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUjMegsem;
        private System.Windows.Forms.Button btnUjMentes;
        private System.Windows.Forms.Panel panelKoltseg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kKm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox kOsszeg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Kategória;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox kRendszam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker kDatum;
        private System.Windows.Forms.ComboBox kKategoria;
        private System.Windows.Forms.TextBox kMegnevezes;
        private System.Windows.Forms.Label ghj;
    }
}

