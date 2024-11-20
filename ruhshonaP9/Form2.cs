using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruhshonaP9
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            bool taxValid, TakeOutValid, EatInValid, DeliveryValid;
            double trTempValue, toTempValue, eiTempValue, dTempValue;
            StreamWriter sw;

            taxValid = double.TryParse(txtTaxRate.Text, out trTempValue);
            TakeOutValid = double.TryParse(txtTakeOutFee.Text, out toTempValue);
            EatInValid = double.TryParse(txtEatInFee.Text, out eiTempValue);
            DeliveryValid = double.TryParse(txtDeliveryFee.Text, out dTempValue);

            if (taxValid && TakeOutValid && EatInValid && DeliveryValid)
            {
                ff.RestaurantTaxRate = trTempValue;
                ff.TakeOutFee = toTempValue;
                ff.EatInFee = eiTempValue;
                ff.DeliveryFee = dTempValue;

                sw = File.CreateText(ff.RestaurantConfig);
                sw.WriteLine(ff.RestaurantTaxRate);
                sw.WriteLine(ff.TakeOutFee);
                sw.WriteLine(ff.EatInFee);
                sw.WriteLine(ff.DeliveryFee);

                sw.Close();

                this.Hide();
            }else
            {
                ff.setValueOnSecondForm();
            }

        }

        private void txtTaxRate_Leave(object sender, EventArgs e)
        {
            bool taxValid = false;
            double trTempValue;
            taxValid = double.TryParse(txtTaxRate.Text, out trTempValue);
            if (!taxValid)
            {
                txtTaxRate.Focus();
                lblErrorMsg.Text = "Tax Rate is not valid";
            }
            else
            {
                lblErrorMsg.Text = "";
            }
            
        }
    }
}
