using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class FormaNovTim : Form
    {
        public string ime { get; set; }
        public string drzava { get; set; }

        public FormaNovTim()
        {
            InitializeComponent();
            ime = "";
            drzava = "";
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                ime = textBox1.Text;
                drzava = textBox2.Text;
                this.Close();
            }
            else
                MessageBox.Show("Внеси ги сите податоци","Грешка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
