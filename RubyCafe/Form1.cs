using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubyCafe
{
    public partial class RubyCafe : Form
    {


        /* KULLANILMIYOR*/
        #region
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void totalpriceLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion




        /* Error Delegate */
        #region Error Delegate
        public delegate void Overload();
        public event Overload OverloadEvent;
        public static void OverloadMethod()
        {
            MessageBox.Show("Yetersiz Bakiye,\n\nDaha Fazla Ekleme Yapamazsınız.", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        #endregion

        /* MONEY */
        int money = 1000;
        /* TOTAL PRICE */
        int totalprice = 0;



        /* FOOD PRICE */

        int cheese = 150;
        int cupcake = 50;
        int hamburger = 120;
        int pizza = 150;
        int hotdog = 30;
        int pancake = 60;

        

        public RubyCafe()
        {
            InitializeComponent();
            OverloadEvent += OverloadMethod;
        }

        private void RubyCafe_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + " TL";
            totalpriceLabel.Text = totalprice.ToString() + " TL";
            cartListbox.Items.Add("Sepet Boş");
        }
        

        private void cheesePicbox_Click(object sender, EventArgs e)
        {

            if(cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }

            if (money >= 150)
            {
                totalprice += cheese;
                cartListbox.Items.Add("Cheese Cake - " + cheese + " TL") ;
                money = money - cheese;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }
        }

        private void cupcakePicbox_Click(object sender, EventArgs e)
        {
            if (cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }
            if (money >= 50)
            {
                totalprice += cupcake;
                cartListbox.Items.Add("Cupcake - " + cupcake + " TL");
                money = money - cupcake;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }
        }

        private void hamburgerPicbox_Click(object sender, EventArgs e)
        {
            if (cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }
            if (money >= 120)
            {
                totalprice += hamburger;
                cartListbox.Items.Add("Hamburger - " + hamburger + " TL");
                money = money - hamburger;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }
        }
        

        private void hotdogPicbox_Click(object sender, EventArgs e)
        {
            if (cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }
            if (money >= 30)
            {
                totalprice += hotdog;
                cartListbox.Items.Add("Hotdog - " + hotdog + " TL");
                money = money - hotdog;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }
        }

        private void panackePicbox_Click(object sender, EventArgs e)
        {
            if (cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }
            if (money >= 60)
            {
                totalprice += pancake;
                cartListbox.Items.Add("Pancake - " + pancake + " TL");
                money = money - pancake;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }

        }

        private void pizzaPicbox_Click(object sender, EventArgs e)
        {
            if (cartListbox.Items.Contains("Sepet Boş"))
            {
                cartListbox.Items.Clear();
            }
            if (money >= 150)
            {
                totalprice += pizza;
                cartListbox.Items.Add("Pizza - " + pizza + " TL");
                money = money - pizza;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
            }
            else
            {
                OverloadEvent();
            }

        }

        private void payButton_Click(object sender, EventArgs e)
        {

            if(cartListbox.Items.Count == 0)
            {
                MessageBox.Show("Ödeme Yapmadan önce sepete bir ürün ekleyin!", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ödeme tamamlanmıştır.\n\n" +
                    "RubyCafe.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartListbox.Items.Clear();
                money = 1000;
                totalprice = 0;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";


            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if(cartListbox.Items.Count == 0 )
            {
                MessageBox.Show("Sepette ürün yok. Ürün ekleyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                cartListbox.Items.Clear();
                money = 1000;
                totalprice = 0;
                moneyLabel.Text = money.ToString() + " TL";
                totalpriceLabel.Text = totalprice.ToString() + " TL";
                cartListbox.Items.Add("Sepet Boş");
            }
        }

		private void rubycafelabel_Click(object sender, EventArgs e)
		{

		}

		private void cartLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
