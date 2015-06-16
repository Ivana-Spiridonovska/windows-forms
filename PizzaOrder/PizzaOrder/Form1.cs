using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotal()
        {
            float total = 0;
            float price = 0;
            if (rbSmall.Checked)
            {
                if (float.TryParse(tbSmallPrice.Text, out price))
                {
                    total += price;
                }
            }
            if (rbMedium.Checked)
            {
                if (float.TryParse(tbMediumPrice.Text, out price))
                {
                    total += price;
                }
            }
            if (rbLarge.Checked)
            {
                if (float.TryParse(tbLargePrice.Text, out price))
                {
                    total += price;
                }
            }
            if (cbPeperoni.Checked)
            {
                if (float.TryParse(tbPeperoniPrice.Text, out price))
                {
                    total += price;
                }
            }
            if (cbPeperoni.Checked)
            {
                if (float.TryParse(tbPeperoniPrice.Text, out price))
                {
                    total += price;
                }
            }
            if (cbExtraCheese.Checked)
            {
                if (float.TryParse(tbExtraCheesePrice.Text, out price))
                {
                    total += price;
                }
            }
            if (cbKatchup.Checked)
            {
                if (float.TryParse(tbKatchupPrice.Text, out price))
                {
                    total += price;
                }
            }
            float.TryParse(tbKKTotal.Text, out price);
            total += price;
            float.TryParse(tbJuiceTotal.Text, out price);
            total += price;
            float.TryParse(tbBeerTotal.Text, out price);
            total += price;
            float.TryParse(tbDesertPrice.Text, out price);
            total += price;
            tbTotal.Text = total.ToString();
        }

        private void stateChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
        private void calculateKK()
        {
            float price = 0;
            float.TryParse(tbKKPrice.Text, out price);
            int amount = 0;
            int.TryParse(tbKKAmount.Text, out amount);
            float total = amount * price;
            tbKKTotal.Text = total.ToString();
        }
        private void tbKKAmount_TextChanged(object sender, EventArgs e)
        {
            calculateKK();
            calculateTotal();
        }
        private void calculateJuice()
        {
            float price = 0;
            float.TryParse(tbJuicePrice.Text, out price);
            int amount = 0;
            int.TryParse(tbJuiceAmount.Text, out amount);
            float total = amount * price;
            tbJuiceTotal.Text = total.ToString();
        }
        private void tbJuiceAmount_TextChanged(object sender, EventArgs e)
        {
            calculateJuice();
            calculateTotal();
        }
        private void calculateBeer()
        {
            float price = 0;
            float.TryParse(tbBeerPrice.Text, out price);
            int amount = 0;
            int.TryParse(tbBeerAmount.Text, out amount);
            float total = amount * price;
            tbBeerTotal.Text = total.ToString();
        }
        private void tbBeerAmount_TextChanged(object sender, EventArgs e)
        {
            calculateBeer();
            calculateTotal();
        }

        private void lbDesert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDesert.SelectedIndex == 0)
            {
                tbDesertPrice.Text = "80";
            }
            if (lbDesert.SelectedIndex == 1)
            {
                tbDesertPrice.Text = "120";
            }
            if (lbDesert.SelectedIndex == 2)
            {
                tbDesertPrice.Text = "160";
            }
            calculateTotal();
        }

        private void tbKKPrice_TextChanged(object sender, EventArgs e)
        {
            calculateKK();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", 
                "Откажи нарачка?", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            StringBuilder order = new StringBuilder();
            if (rbSmall.Checked)
            {
                order.Append("Мала пица\n");
            }
            if (rbMedium.Checked)
            {
                order.Append("Средна пица\n");
            }
            if (rbLarge.Checked)
            {
                order.Append("Голема пица\n");
            }
            if (cbPeperoni.Checked || cbExtraCheese.Checked || cbKatchup.Checked)
            {
                order.Append("Додатоци:\n");
            }
            if (cbPeperoni.Checked)
            {
                order.Append("Феферонки\n");
            }
            if (cbExtraCheese.Checked)
            {
                order.Append("Екстра сирење\n");
            }
            if (cbKatchup.Checked)
            {
                order.Append("Кечап\n");
            }
            StringBuilder drink = new StringBuilder();
            int kk = 0;
            int.TryParse(tbKKAmount.Text, out kk);
            if (kk != 0)
            {
                drink.Append(string.Format("{0} кока кола / фанта / спрајт\n", kk));
            }
            kk = 0;
            int.TryParse(tbJuiceAmount.Text, out kk);
            if (kk != 0)
            {
                drink.Append(string.Format("{0} сок од портокал / јаболко\n", kk));
            }
            kk = 0;
            int.TryParse(tbBeerAmount.Text, out kk);
            if (kk != 0)
            {
                drink.Append(string.Format("{0} пиво\n", kk));
            }
            if (drink.Length > 0)
            {
                order.Append("Пијалок:\n");
                order.Append(drink);
            }
            if (lbDesert.SelectedIndex != -1)
            {
                order.Append("Десерт:\n");
                order.Append(lbDesert.SelectedItem.ToString());
            }
            MessageBox.Show(order.ToString(),"Вашата нарачка");
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            float amount = 0;
            float.TryParse(tbAmount.Text, out amount);
            float total = 0;
            float.TryParse(tbTotal.Text, out total);
            amount -= total;
            tbReturn.Text = amount.ToString();
        }


    }
}
