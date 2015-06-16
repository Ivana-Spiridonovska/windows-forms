namespace SportsBets
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
            this.listTimovi = new System.Windows.Forms.ListBox();
            this.listBilten = new System.Windows.Forms.ListBox();
            this.listTiket = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodadiTim = new System.Windows.Forms.Button();
            this.btnDodadiVoBilten = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodadiNatprevar = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSifra1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDobivka = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numUplata = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.tbVkupenKoef = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // listTimovi
            // 
            this.listTimovi.FormattingEnabled = true;
            this.listTimovi.Location = new System.Drawing.Point(13, 33);
            this.listTimovi.Name = "listTimovi";
            this.listTimovi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listTimovi.Size = new System.Drawing.Size(205, 225);
            this.listTimovi.TabIndex = 0;
            // 
            // listBilten
            // 
            this.listBilten.FormattingEnabled = true;
            this.listBilten.Location = new System.Drawing.Point(238, 33);
            this.listBilten.Name = "listBilten";
            this.listBilten.Size = new System.Drawing.Size(254, 225);
            this.listBilten.TabIndex = 1;
            // 
            // listTiket
            // 
            this.listTiket.FormattingEnabled = true;
            this.listTiket.Location = new System.Drawing.Point(511, 33);
            this.listTiket.Name = "listTiket";
            this.listTiket.Size = new System.Drawing.Size(221, 225);
            this.listTiket.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Листа на тимови";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Билтен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тикет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodadiTim);
            this.groupBox1.Controls.Add(this.btnDodadiVoBilten);
            this.groupBox1.Controls.Add(this.tbSifra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.numX);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Креирај билтен";
            // 
            // btnDodadiTim
            // 
            this.btnDodadiTim.Location = new System.Drawing.Point(10, 190);
            this.btnDodadiTim.Name = "btnDodadiTim";
            this.btnDodadiTim.Size = new System.Drawing.Size(184, 23);
            this.btnDodadiTim.TabIndex = 11;
            this.btnDodadiTim.Text = "Додади нов тим";
            this.btnDodadiTim.UseVisualStyleBackColor = true;
            this.btnDodadiTim.Click += new System.EventHandler(this.btnDodadiTim_Click);
            // 
            // btnDodadiVoBilten
            // 
            this.btnDodadiVoBilten.Location = new System.Drawing.Point(10, 161);
            this.btnDodadiVoBilten.Name = "btnDodadiVoBilten";
            this.btnDodadiVoBilten.Size = new System.Drawing.Size(184, 23);
            this.btnDodadiVoBilten.TabIndex = 10;
            this.btnDodadiVoBilten.Text = "Додади во билтен";
            this.btnDodadiVoBilten.UseVisualStyleBackColor = true;
            this.btnDodadiVoBilten.Click += new System.EventHandler(this.btnDodadiVoBilten_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(55, 130);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(139, 20);
            this.tbSifra.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Шифра";
            // 
            // num2
            // 
            this.num2.DecimalPlaces = 2;
            this.num2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num2.Location = new System.Drawing.Point(44, 104);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 20);
            this.num2.TabIndex = 7;
            this.num2.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numX
            // 
            this.numX.DecimalPlaces = 2;
            this.numX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numX.Location = new System.Drawing.Point(44, 78);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 6;
            this.numX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 2;
            this.num1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num1.Location = new System.Drawing.Point(44, 52);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 20);
            this.num1.TabIndex = 5;
            this.num1.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Постави коефициенти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Избери два тима од иста држава";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodadiNatprevar);
            this.groupBox2.Controls.Add(this.cmbTip);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbSifra1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(238, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади натпревар во тикет";
            // 
            // btnDodadiNatprevar
            // 
            this.btnDodadiNatprevar.Location = new System.Drawing.Point(13, 171);
            this.btnDodadiNatprevar.Name = "btnDodadiNatprevar";
            this.btnDodadiNatprevar.Size = new System.Drawing.Size(110, 23);
            this.btnDodadiNatprevar.TabIndex = 16;
            this.btnDodadiNatprevar.Text = "Додади натпревар";
            this.btnDodadiNatprevar.UseVisualStyleBackColor = true;
            this.btnDodadiNatprevar.Click += new System.EventHandler(this.btnDodadiNatprevar_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cmbTip.Location = new System.Drawing.Point(13, 130);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Избери тип";
            // 
            // tbSifra1
            // 
            this.tbSifra1.Location = new System.Drawing.Point(10, 77);
            this.tbSifra1.Name = "tbSifra1";
            this.tbSifra1.Size = new System.Drawing.Size(106, 20);
            this.tbSifra1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Шифра";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Избери натпревар од билтен или внеси шифра";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tbDobivka);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.numUplata);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbVkupenKoef);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(511, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 219);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уплати тикет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Печати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDobivka
            // 
            this.tbDobivka.Location = new System.Drawing.Point(10, 142);
            this.tbDobivka.Name = "tbDobivka";
            this.tbDobivka.ReadOnly = true;
            this.tbDobivka.Size = new System.Drawing.Size(205, 20);
            this.tbDobivka.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Добивка";
            // 
            // numUplata
            // 
            this.numUplata.Location = new System.Drawing.Point(13, 99);
            this.numUplata.Name = "numUplata";
            this.numUplata.Size = new System.Drawing.Size(202, 20);
            this.numUplata.TabIndex = 17;
            this.numUplata.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUplata.ValueChanged += new System.EventHandler(this.numUplata_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Уплата";
            // 
            // tbVkupenKoef
            // 
            this.tbVkupenKoef.Location = new System.Drawing.Point(10, 45);
            this.tbVkupenKoef.Name = "tbVkupenKoef";
            this.tbVkupenKoef.ReadOnly = true;
            this.tbVkupenKoef.Size = new System.Drawing.Size(205, 20);
            this.tbVkupenKoef.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Вкупен коефициент";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTiket);
            this.Controls.Add(this.listBilten);
            this.Controls.Add(this.listTimovi);
            this.Name = "Form1";
            this.Text = "Спортска обложувалница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTimovi;
        private System.Windows.Forms.ListBox listBilten;
        private System.Windows.Forms.ListBox listTiket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodadiTim;
        private System.Windows.Forms.Button btnDodadiVoBilten;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDodadiNatprevar;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSifra1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDobivka;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numUplata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbVkupenKoef;
        private System.Windows.Forms.Label label13;
    }
}

