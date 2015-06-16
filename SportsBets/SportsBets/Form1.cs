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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listTimovi.Items.Add(new Team("Барселона","Шпанија"));
            listTimovi.Items.Add(new Team("Реал Мадрид", "Шпанија"));
            listTimovi.Items.Add(new Team("Манчестер Ј", "Англија"));
            listTimovi.Items.Add(new Team("Арсенал", "Англија"));
            listTimovi.Items.Add(new Team("Милан", "Италија"));
            listTimovi.Items.Add(new Team("Бенфика", "Португалија"));

        }

        private void btnDodadiTim_Click(object sender, EventArgs e)
        {
            FormaNovTim f = new FormaNovTim();
            f.ShowDialog();

            if (!f.ime.Equals("") && !f.drzava.Equals(""))
            {
                listTimovi.Items.Add(new Team(f.ime,f.drzava));
            }
        }

        private void btnDodadiVoBilten_Click(object sender, EventArgs e)
        {
            if (tbSifra.Text.Length <= 0)
            {
                MessageBox.Show("Внеси шифра");
                return;
            }
            if (listTimovi.SelectedItems.Count != 2)
            {
                MessageBox.Show("Внеси точно два тимa");
                return;
            }
            int kod = 0;
            int.TryParse(tbSifra.Text,out kod);
            foreach (Game g in listBilten.Items)
            {
                if (g.kod == kod)
                {
                    MessageBox.Show("Веќе постои натправар со таков код");
                    return;
                }
            }
            listBilten.Items.Add(new Game(kod,(Team)listTimovi.SelectedItems[0],(Team)listTimovi.SelectedItems[1],(float)num1.Value,(float)numX.Value,(float)num2.Value));
        }

        private void btnDodadiNatprevar_Click(object sender, EventArgs e)
        {
            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Одбери тип");
                return;
            }
            Game natprevar = null;

            if (listBilten.SelectedIndex == -1)
            {
                if (tbSifra1.Text.Length <= 0)
                {
                    MessageBox.Show("Одбери тим од билтенот или внеси шифра");
                    return;
                }
                int sifra = 0;
                int.TryParse(tbSifra1.Text, out sifra);
                foreach (Game g in listBilten.Items)
                {
                    if (sifra == g.kod)
                    {
                        natprevar = new Game(g.kod,g.domasen,g.gostin,g.koef[0],g.koef[1],g.koef[2]);
                        
                        break;
                    }
                }
                if (sifra == 0 || natprevar == null)
                {
                    MessageBox.Show("Не постои натпревар со таа шифра");
                    return;
                }
            }
            else natprevar = (Game)listBilten.SelectedItem;
            int tip = -1;
            tip = cmbTip.SelectedIndex;
            listTiket.Items.Add(new Ticket(natprevar,(tip)));

            int uplata = (int)numUplata.Value;
            float vkupenKoef = 0;
            float.TryParse(tbVkupenKoef.Text,out vkupenKoef);
            if (vkupenKoef == 0)
                vkupenKoef = 1;
            vkupenKoef *= natprevar.koef[tip];
            listBilten.SelectedIndex = -1;
            tbVkupenKoef.Text = string.Format("{0:0.00}", vkupenKoef);
            tbDobivka.Text = string.Format("{0:0.00}", vkupenKoef * uplata);
        }
        
        private void numUplata_ValueChanged(object sender, EventArgs e)
        {
            int uplata = (int)numUplata.Value;
            float vkupenKoef = 0;
            float.TryParse(tbVkupenKoef.Text,out vkupenKoef);
            tbDobivka.Text = string.Format("{0:0.00}",uplata * vkupenKoef);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDobivka.Text.Length <= 0)
            {
                MessageBox.Show("Немате внесено ништо во тикетот");
            }
            else
                MessageBox.Show("Ливчето е уплатено\nУплата: " + numUplata.Value + "\nДобивка: " + tbDobivka.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
