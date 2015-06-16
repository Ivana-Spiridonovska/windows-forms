namespace PizzaOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLargePrice = new System.Windows.Forms.TextBox();
            this.tbMediumPrice = new System.Windows.Forms.TextBox();
            this.tbSmallPrice = new System.Windows.Forms.TextBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbKatchupPrice = new System.Windows.Forms.TextBox();
            this.tbExtraCheesePrice = new System.Windows.Forms.TextBox();
            this.tbPeperoniPrice = new System.Windows.Forms.TextBox();
            this.cbKatchup = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbPeperoni = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBeerTotal = new System.Windows.Forms.TextBox();
            this.tbJuiceTotal = new System.Windows.Forms.TextBox();
            this.tbKKTotal = new System.Windows.Forms.TextBox();
            this.tbBeerPrice = new System.Windows.Forms.TextBox();
            this.tbJuicePrice = new System.Windows.Forms.TextBox();
            this.tbKKPrice = new System.Windows.Forms.TextBox();
            this.tbBeerAmount = new System.Windows.Forms.TextBox();
            this.tbJuiceAmount = new System.Windows.Forms.TextBox();
            this.tbKKAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbDesertPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDesert = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLargePrice);
            this.groupBox1.Controls.Add(this.tbMediumPrice);
            this.groupBox1.Controls.Add(this.tbSmallPrice);
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // tbLargePrice
            // 
            this.tbLargePrice.Location = new System.Drawing.Point(167, 84);
            this.tbLargePrice.Name = "tbLargePrice";
            this.tbLargePrice.Size = new System.Drawing.Size(75, 20);
            this.tbLargePrice.TabIndex = 5;
            this.tbLargePrice.Text = "500";
            this.tbLargePrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // tbMediumPrice
            // 
            this.tbMediumPrice.Location = new System.Drawing.Point(167, 49);
            this.tbMediumPrice.Name = "tbMediumPrice";
            this.tbMediumPrice.Size = new System.Drawing.Size(75, 20);
            this.tbMediumPrice.TabIndex = 4;
            this.tbMediumPrice.Text = "300";
            this.tbMediumPrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // tbSmallPrice
            // 
            this.tbSmallPrice.Location = new System.Drawing.Point(167, 15);
            this.tbSmallPrice.Name = "tbSmallPrice";
            this.tbSmallPrice.Size = new System.Drawing.Size(75, 20);
            this.tbSmallPrice.TabIndex = 3;
            this.tbSmallPrice.Text = "200";
            this.tbSmallPrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(11, 84);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Голема";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(11, 50);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Средна";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(11, 16);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(52, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Мала";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbKatchupPrice);
            this.groupBox2.Controls.Add(this.tbExtraCheesePrice);
            this.groupBox2.Controls.Add(this.tbPeperoniPrice);
            this.groupBox2.Controls.Add(this.cbKatchup);
            this.groupBox2.Controls.Add(this.cbExtraCheese);
            this.groupBox2.Controls.Add(this.cbPeperoni);
            this.groupBox2.Location = new System.Drawing.Point(271, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // tbKatchupPrice
            // 
            this.tbKatchupPrice.Location = new System.Drawing.Point(171, 80);
            this.tbKatchupPrice.Name = "tbKatchupPrice";
            this.tbKatchupPrice.Size = new System.Drawing.Size(75, 20);
            this.tbKatchupPrice.TabIndex = 6;
            this.tbKatchupPrice.Text = "20";
            this.tbKatchupPrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // tbExtraCheesePrice
            // 
            this.tbExtraCheesePrice.Location = new System.Drawing.Point(171, 49);
            this.tbExtraCheesePrice.Name = "tbExtraCheesePrice";
            this.tbExtraCheesePrice.Size = new System.Drawing.Size(75, 20);
            this.tbExtraCheesePrice.TabIndex = 5;
            this.tbExtraCheesePrice.Text = "30";
            this.tbExtraCheesePrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // tbPeperoniPrice
            // 
            this.tbPeperoniPrice.Location = new System.Drawing.Point(171, 18);
            this.tbPeperoniPrice.Name = "tbPeperoniPrice";
            this.tbPeperoniPrice.Size = new System.Drawing.Size(75, 20);
            this.tbPeperoniPrice.TabIndex = 4;
            this.tbPeperoniPrice.Text = "40";
            this.tbPeperoniPrice.TextChanged += new System.EventHandler(this.stateChanged);
            // 
            // cbKatchup
            // 
            this.cbKatchup.AutoSize = true;
            this.cbKatchup.Location = new System.Drawing.Point(11, 82);
            this.cbKatchup.Name = "cbKatchup";
            this.cbKatchup.Size = new System.Drawing.Size(56, 17);
            this.cbKatchup.TabIndex = 3;
            this.cbKatchup.Text = "Кечап";
            this.cbKatchup.UseVisualStyleBackColor = true;
            this.cbKatchup.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(11, 51);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(105, 17);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Екстра сирење";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // cbPeperoni
            // 
            this.cbPeperoni.AutoSize = true;
            this.cbPeperoni.Location = new System.Drawing.Point(11, 20);
            this.cbPeperoni.Name = "cbPeperoni";
            this.cbPeperoni.Size = new System.Drawing.Size(87, 17);
            this.cbPeperoni.TabIndex = 0;
            this.cbPeperoni.Text = "Феферонки";
            this.cbPeperoni.UseVisualStyleBackColor = true;
            this.cbPeperoni.CheckedChanged += new System.EventHandler(this.stateChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbBeerTotal);
            this.groupBox3.Controls.Add(this.tbJuiceTotal);
            this.groupBox3.Controls.Add(this.tbKKTotal);
            this.groupBox3.Controls.Add(this.tbBeerPrice);
            this.groupBox3.Controls.Add(this.tbJuicePrice);
            this.groupBox3.Controls.Add(this.tbKKPrice);
            this.groupBox3.Controls.Add(this.tbBeerAmount);
            this.groupBox3.Controls.Add(this.tbJuiceAmount);
            this.groupBox3.Controls.Add(this.tbKKAmount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количина";
            // 
            // tbBeerTotal
            // 
            this.tbBeerTotal.Location = new System.Drawing.Point(407, 98);
            this.tbBeerTotal.Name = "tbBeerTotal";
            this.tbBeerTotal.ReadOnly = true;
            this.tbBeerTotal.Size = new System.Drawing.Size(75, 20);
            this.tbBeerTotal.TabIndex = 11;
            // 
            // tbJuiceTotal
            // 
            this.tbJuiceTotal.Location = new System.Drawing.Point(407, 65);
            this.tbJuiceTotal.Name = "tbJuiceTotal";
            this.tbJuiceTotal.ReadOnly = true;
            this.tbJuiceTotal.Size = new System.Drawing.Size(75, 20);
            this.tbJuiceTotal.TabIndex = 10;
            // 
            // tbKKTotal
            // 
            this.tbKKTotal.Location = new System.Drawing.Point(407, 35);
            this.tbKKTotal.Name = "tbKKTotal";
            this.tbKKTotal.ReadOnly = true;
            this.tbKKTotal.Size = new System.Drawing.Size(75, 20);
            this.tbKKTotal.TabIndex = 9;
            // 
            // tbBeerPrice
            // 
            this.tbBeerPrice.Location = new System.Drawing.Point(290, 98);
            this.tbBeerPrice.Name = "tbBeerPrice";
            this.tbBeerPrice.Size = new System.Drawing.Size(75, 20);
            this.tbBeerPrice.TabIndex = 8;
            this.tbBeerPrice.Text = "80";
            // 
            // tbJuicePrice
            // 
            this.tbJuicePrice.Location = new System.Drawing.Point(290, 65);
            this.tbJuicePrice.Name = "tbJuicePrice";
            this.tbJuicePrice.Size = new System.Drawing.Size(75, 20);
            this.tbJuicePrice.TabIndex = 7;
            this.tbJuicePrice.Text = "70";
            // 
            // tbKKPrice
            // 
            this.tbKKPrice.Location = new System.Drawing.Point(290, 35);
            this.tbKKPrice.Name = "tbKKPrice";
            this.tbKKPrice.Size = new System.Drawing.Size(75, 20);
            this.tbKKPrice.TabIndex = 6;
            this.tbKKPrice.Text = "60";
            this.tbKKPrice.TextChanged += new System.EventHandler(this.tbKKPrice_TextChanged);
            // 
            // tbBeerAmount
            // 
            this.tbBeerAmount.Location = new System.Drawing.Point(173, 98);
            this.tbBeerAmount.Name = "tbBeerAmount";
            this.tbBeerAmount.Size = new System.Drawing.Size(75, 20);
            this.tbBeerAmount.TabIndex = 5;
            this.tbBeerAmount.Text = "0";
            this.tbBeerAmount.TextChanged += new System.EventHandler(this.tbBeerAmount_TextChanged);
            // 
            // tbJuiceAmount
            // 
            this.tbJuiceAmount.Location = new System.Drawing.Point(173, 65);
            this.tbJuiceAmount.Name = "tbJuiceAmount";
            this.tbJuiceAmount.Size = new System.Drawing.Size(75, 20);
            this.tbJuiceAmount.TabIndex = 4;
            this.tbJuiceAmount.Text = "0";
            this.tbJuiceAmount.TextChanged += new System.EventHandler(this.tbJuiceAmount_TextChanged);
            // 
            // tbKKAmount
            // 
            this.tbKKAmount.Location = new System.Drawing.Point(173, 35);
            this.tbKKAmount.Name = "tbKKAmount";
            this.tbKKAmount.Size = new System.Drawing.Size(75, 20);
            this.tbKKAmount.TabIndex = 3;
            this.tbKKAmount.Text = "0";
            this.tbKKAmount.TextChanged += new System.EventHandler(this.tbKKAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOrder);
            this.groupBox4.Controls.Add(this.tbDesertPrice);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbDesert);
            this.groupBox4.Location = new System.Drawing.Point(13, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(133, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(134, 67);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Нарачај";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbDesertPrice
            // 
            this.tbDesertPrice.Location = new System.Drawing.Point(133, 41);
            this.tbDesertPrice.Name = "tbDesertPrice";
            this.tbDesertPrice.Size = new System.Drawing.Size(115, 20);
            this.tbDesertPrice.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт:";
            // 
            // lbDesert
            // 
            this.lbDesert.FormattingEnabled = true;
            this.lbDesert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDesert.Location = new System.Drawing.Point(7, 20);
            this.lbDesert.Name = "lbDesert";
            this.lbDesert.Size = new System.Drawing.Size(120, 108);
            this.lbDesert.TabIndex = 0;
            this.lbDesert.SelectedIndexChanged += new System.EventHandler(this.lbDesert_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbReturn);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbAmount);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(282, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 139);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // tbReturn
            // 
            this.tbReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReturn.Location = new System.Drawing.Point(121, 96);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.Size = new System.Drawing.Size(114, 26);
            this.tbReturn.TabIndex = 5;
            this.tbReturn.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "За враќање:";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAmount.Location = new System.Drawing.Point(121, 54);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(114, 26);
            this.tbAmount.TabIndex = 3;
            this.tbAmount.Text = "0";
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Наплатено:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotal.Location = new System.Drawing.Point(121, 12);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(114, 26);
            this.tbTotal.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.TextBox tbLargePrice;
        private System.Windows.Forms.TextBox tbMediumPrice;
        private System.Windows.Forms.TextBox tbSmallPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbKatchupPrice;
        private System.Windows.Forms.TextBox tbExtraCheesePrice;
        private System.Windows.Forms.TextBox tbPeperoniPrice;
        private System.Windows.Forms.CheckBox cbKatchup;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbPeperoni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBeerTotal;
        private System.Windows.Forms.TextBox tbJuiceTotal;
        private System.Windows.Forms.TextBox tbKKTotal;
        private System.Windows.Forms.TextBox tbBeerPrice;
        private System.Windows.Forms.TextBox tbJuicePrice;
        private System.Windows.Forms.TextBox tbKKPrice;
        private System.Windows.Forms.TextBox tbBeerAmount;
        private System.Windows.Forms.TextBox tbJuiceAmount;
        private System.Windows.Forms.TextBox tbKKAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbDesertPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDesert;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
    }
}

