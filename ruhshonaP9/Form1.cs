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
            txtMenuItem.Clear();
            txtFoodPrice.Clear();
            lstOut.Items.Clear();
            txtMenuItem.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;

            ButtonSelected = MessageBox.Show("Do you really want to Quit", "Exiting Page...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {


                this.Close();

            }
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double RestaurantTaxRate = .0875;
            double Foodprice, totalFoodlPrice, RestaurantTaxAmount;
            string RestaurantMenuItem;
            bool PriceValid;



            // input
            // Parse converts string to double
            // 
            PriceValid = double.TryParse(txtFoodPrice.Text, out Foodprice);

            if (PriceValid)
            {

                RestaurantMenuItem = txtMenuItem.Text;


                //processing    
                RestaurantTaxAmount = Foodprice * RestaurantTaxRate;
                totalFoodlPrice = Foodprice * RestaurantTaxAmount;
                //output
                
                lstOut.Items.Add("Menu Item is " + RestaurantMenuItem);
                lstOut.Items.Add("Price is " + Foodprice.ToString("C2"));
                lstOut.Items.Add("Tax Rate is " + RestaurantTaxRate.ToString("P2"));
                lstOut.Items.Add("Tax amount is " + RestaurantTaxAmount.ToString("C2"));
                lstOut.Items.Add("Total Food Price is " + totalFoodlPrice.ToString("C2"));

                btnClear.Focus();
                

                // This chnages the focus to the clear button

            }


        }


        private void txtFoodPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtMenuItem_Enter(object sender, EventArgs e)
        {
            txtMenuItem.BackColor = Color.Bisque;
        }

        private void txtMenuItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMenuItem_Leave(object sender, EventArgs e)
        {
            txtMenuItem.BackColor = SystemColors.Window;
        }
    }
}
