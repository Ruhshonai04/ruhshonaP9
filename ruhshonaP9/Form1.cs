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
            txtCustomerName.Clear();
            txtFoodPrice.Clear();
            lstOut.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double taxRate = .0875;
            double price, totalPrice, taxAmount;
            string RestaurantCustName;

            // input
            price = double.Parse(txtFoodPrice.Text);
            RestaurantCustName = txtCustomerName.Text;

            //processing    
            taxAmount = price * taxRate;
            totalPrice = price * taxAmount;


            //output
            lstOut.Items.Add("Customer Name is " + RestaurantCustName);
            lstOut.Items.Add("Price is " + price.ToString("C2"));
            lstOut.Items.Add("Tax Rate is " + taxRate.ToString("P2"));
            lstOut.Items.Add("Tax amount is " + taxAmount.ToString("C2"));
            lstOut.Items.Add("Total Price is " + totalPrice.ToString("C2"));



            btnClear.Focus();

            // This chnages the focus to the clear button




        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Bisque;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        private void txtCustomerName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtFoodPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
