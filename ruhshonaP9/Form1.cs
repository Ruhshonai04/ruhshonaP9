using System.Diagnostics.Eventing.Reader;

namespace ruhshonaP9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFoodMenu.Clear();
            txtFoodPrice.Clear();
            lstOut.Items.Clear();
            txtFoodMenu.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     


        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double RestaurantTaxRate = .0875;
            double price, totalPrice, RestaurantTaxAmount;
            string RestaurantFoodMenu;
            bool PriceValid;



            // input
            // Parse converts string to double
            // 
            PriceValid = double.TryParse(txtFoodPrice.Text, out price);

            if (PriceValid)
            {

                RestaurantFoodMenu = txtFoodMenu.Text;


                //processing    
                RestaurantTaxAmount = price * RestaurantTaxRate;
                totalPrice = price * RestaurantTaxAmount;


                //output
                lstOut.Items.Add("Food Menu is " + RestaurantFoodMenu);
                lstOut.Items.Add("Price is " + price.ToString("C2"));
                lstOut.Items.Add("Tax Rate is " + RestaurantTaxRate.ToString("P2"));
                lstOut.Items.Add("Tax amount is " + RestaurantTaxAmount.ToString("C2"));
                lstOut.Items.Add("Total Price is " + totalPrice.ToString("C2"));

                btnClear.Focus();

                // This chnages the focus to the clear button

            }


        }

      
        private void txtFoodMenu_Leave(object sender, EventArgs e)
        {
            txtFoodMenu.BackColor = SystemColors.Window;
        }

        private void txtFoodPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFoodMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoodMenu_Enter(object sender, EventArgs e)
        {
            txtFoodMenu.BackColor = Color.Bisque;
        }
    }
}
