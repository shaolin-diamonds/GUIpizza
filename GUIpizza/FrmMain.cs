using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIpizza
{
    public partial class FrmMain : Form
    {
        string order;
        double total, tax, subtotal;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            order = "";

            order += RadThinCrust.Checked ? "Thin Crust" : "";
            order += RadTraditional.Checked ? "Traditional" : "";
            order += RadDeepDish.Checked ? "Deep Dish" : "";
            order += RadStuffedCrust.Checked ? "Stuffed Crust" : "";

            order += ChkExtraCheese.Checked ? " Extra Cheese" : "";
            order += ChkPepperoni.Checked ? " Pepperoni" : "";
            order += ChkSausage.Checked ? " Sausage" : "";
            order += ChkBlackOlives.Checked ? " Black Olives" : "";
            order += ChkMushrooms.Checked ? " Mushrooms" : "";
            order += ChkJalapenos.Checked ? " Jalapenos" : "";
            order += ChkPineapple.Checked ? " Pineapple" : "";
            order += ChkBacon.Checked ? " Bacon" : "";

            order += ChkPepsi.Checked ? " Pepsi" : "";
            order += ChkDietPepsi.Checked ? " Diet Pepsi" : "";
            order += ChkSierraMist.Checked ? " Sierra Mist" : "";
            order += ChkMountainDew.Checked ? " Mountain Dew" : "";

            order += RadDineIn.Checked ? " Dine In" : "";
            order += RadTakeOut.Checked ? " Take Out" : "";
            order += RadDelivery.Checked ? " Delivery" : "";

            order += " " + MTxtBoxPhoneNumber.Text;

            TxtOrder.Text = order;

            order = "";

            total += RadThinCrust.Checked ? 15.00 : 0;
            total += RadTraditional.Checked ? 15.00 : 0;
            total += RadDeepDish.Checked ? 16.00 : 0;
            total += RadStuffedCrust.Checked ? 17.00 : 0;

            total += ChkExtraCheese.Checked ? 0 : 0;
            total += ChkPepperoni.Checked ? 1.25 : 0;
            total += ChkSausage.Checked ? 1.25 : 0;
            total += ChkBlackOlives.Checked ? 0 : 0;
            total += ChkMushrooms.Checked ? 0 : 0;
            total += ChkJalapenos.Checked ? 0 : 0;
            total += ChkPineapple.Checked ? 0 : 0;
            total += ChkBacon.Checked ? .50 : 0;

            total += ChkPepsi.Checked ? .75 : 0;
            total += ChkDietPepsi.Checked ? .75 : 0;
            total += ChkSierraMist.Checked ? .75 : 0;
            total += ChkMountainDew.Checked ? .75 : 0;

            total += RadDineIn.Checked ? 0 : 0;
            total += RadTakeOut.Checked ? 0 : 0;
            total += RadDelivery.Checked ? 5.75 : 0;

            TxtTotal.Text = String.Format("${0:0.00}", total);

            tax = total * .06875;
            TxtSales.Text = String.Format("${0:0.00}", tax);

            subtotal = total + tax;
            TxtSubTotal.Text = String.Format("${0:0.00}", subtotal);
        }

        private void RadDelivery_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("RadDelivery check changed");
            if (RadDelivery.Checked)
            {
                DialogResult result = MessageBox.Show(
                "We deliver to addresses within the city limits\n" +
                "of St. Cloud, Sauk Rapids, and Sartell.\n" +
                "Are you within city limits?",
                "Delivery Area",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    RadTakeOut.Checked = true;
                }
            }
        }

        private void RadStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (RadStuffedCrust.Checked)
            {
                this.BackColor = System.Drawing.Color.Wheat;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            FrmHelp myFrmHelp = new FrmHelp();
            myFrmHelp.Show();
        }

        private void TmrBlink1_Tick(object sender, EventArgs e)
        {
            // Console.WriteLine("Timer ticked.");
            /*
            if (PicBoxSign.Visible)
            {
                PicBoxSign.Visible = false;
            }
            else
            {
                PicBoxSign.Visible = true;
            }
            */
            // PicBoxSign.Visible = PicBoxSign.Visible ? false : true;
            // PicBoxSign.Visible = false;
            TmrBlink2.Enabled = true;
            TmrBlink1.Enabled = false;
        }

        private void TmrBlink2_Tick(object sender, EventArgs e)
        {
            // PicBoxSign.Visible = true;
            TmrBlink1.Enabled = true;
            TmrBlink2.Enabled = false;
        }

        private void TmrBlinker_Tick(object sender, EventArgs e)
        {
            if (PicBoxSign.Visible)
            {
                PicBoxSign.Visible = false;
                TmrBlinker.Interval = 1000;
            }
            else
            {
                PicBoxSign.Visible = true;
                TmrBlinker.Interval = 3000;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtOrder.Text = "";
            TxtTotal.Text = "";
            total = 0;
        }
    }
}
