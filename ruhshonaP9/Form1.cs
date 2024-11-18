using System.Diagnostics.Eventing.Reader;

namespace ruhshonaP9
{
    public partial class Form1 : Form
    {

        const string TAKE_OUT = "Take Out";
        private string DiningOption = TAKE_OUT;
        const string EAT_IN = "Eat In";
        const string DELIVERY = "Delivery";

        private double restaurantTaxRate = .08875;
        private double takeOutFee = 5;
        private double eatInFee = 10;
        private double deliveryFee = 15;
        private double DiningInFee = 0;
        private Form2 settingForm;


        private string RestaurantTrasactionLog = "RestaurantTransLog.txt";
        public string RestaurantConfig = "RestaurantConfig.txt";

        public double RestaurantTaxRate
        {
            get { return restaurantTaxRate; }
            set { restaurantTaxRate = value; }
        }
        public double TakeOutFee
        {
            get { return takeOutFee; }
            set { takeOutFee = value; }
        }
        public double EatInFee
        {
            get { return eatInFee; }
            set { eatInFee = value; }
        }
        public double DeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingForm = new Form2(this);
            // this makes the checked changed procedure run ( it doesn't run if set in designer)
            // rdoEconomy.Checked = true;
            rdoTakeOut.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {
                    reader = File.OpenText(RestaurantConfig);
                    fileBad = false;
                    double tempValue;
                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    RestaurantTaxRate = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    TakeOutFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    EatInFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    DeliveryFee = tempValue;

                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuation flie was not found. Please select a different file \n Error message was:" +

                    ex.Message
                    );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    RestaurantConfig = openFileDialog1.FileName;

                }
            } while (fileBad);
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

            ButtonSelected = MessageBox.Show("Do you really want to Quit?", "Exiting Page...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {


                this.Close();

            }
        }



        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {

            double Foodprice, totalFoodlPrice, RestaurantTaxAmount, DiningOptionFee;
            string RestaurantMenuItem;
            bool PriceValid;

            StreamWriter sw;

            //    double DiningOption = 0;

            // input
            // Parse converts string to double
            // 
            PriceValid = double.TryParse(txtFoodPrice.Text, out Foodprice);


            if (PriceValid)
            {
                switch (DiningOption)
                {
                    case TAKE_OUT:
                        DiningOptionFee = TakeOutFee;
                        break;
                    case EAT_IN:
                        DiningOptionFee = EatInFee;
                        break;
                    case DELIVERY:
                        DiningOptionFee = DeliveryFee;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        break;
                }

                RestaurantMenuItem = txtMenuItem.Text;


                //processing    
                RestaurantTaxAmount = Foodprice * RestaurantTaxRate;
                totalFoodlPrice = Foodprice + RestaurantTaxAmount;
                //output

                lstOut.Items.Add("Menu Item is " + RestaurantMenuItem);
                lstOut.Items.Add("Price is " + Foodprice.ToString("C2"));
                lstOut.Items.Add("Dining Option is " + DiningOption);
                lstOut.Items.Add("Dining in Fee = " + DiningInFee);
                lstOut.Items.Add("Tax Rate is " + RestaurantTaxRate.ToString("P2"));
                lstOut.Items.Add("Tax amount is " + RestaurantTaxAmount.ToString("C2"));
                lstOut.Items.Add("Total Food Price is " + totalFoodlPrice.ToString("C2"));
                sw = File.AppendText(RestaurantTrasactionLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + "**********");
                sw.WriteLine("Menu Item is " + RestaurantMenuItem);
                sw.WriteLine("Price is " + Foodprice.ToString("C2"));
                sw.WriteLine("Dining Option is " + DiningOption);
                sw.WriteLine("Dining in Fee = " + DiningInFee);
                sw.WriteLine("Tax Rate is " + RestaurantTaxRate.ToString("P2"));
                sw.WriteLine("Tax amount is " + RestaurantTaxAmount.ToString("C2"));
                sw.WriteLine("Total Food Price is " + totalFoodlPrice.ToString("C2"));

                sw.Close();

                btnClear.Focus();


                // This chnages the focus to the clear button

            }


        }



        private void txtMenuItem_Enter(object sender, EventArgs e)
        {
            txtMenuItem.BackColor = Color.Bisque;
        }



        private void txtMenuItem_Leave(object sender, EventArgs e)
        {
            txtMenuItem.BackColor = SystemColors.Window;
        }

        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTakeOut.Checked)
            {
                DiningOption = TAKE_OUT;
            }
        }

        private void grpEatingIn_Enter(object sender, EventArgs e)
        {

        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEatIn.Checked)
            {
                DiningOption = EAT_IN;
            }
        }

        private void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelivery.Checked)
            {
                DiningOption = DELIVERY;
            }
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            settingForm.txtTaxRate.Text = RestaurantTaxRate.ToString();
            settingForm.txtTakeOutFee.Text = TakeOutFee.ToString();
            settingForm.txtEatInFee.Text = EatInFee.ToString();
            settingForm.txtDeliveryFee.Text = DeliveryFee.ToString();

            setValueOnSecondForm();
            settingForm.ShowDialog();
        }

        public void setValueOnSecondForm()
        {
            settingForm.txtTaxRate.Text = RestaurantTaxRate.ToString();
            settingForm.txtTakeOutFee.Text = TakeOutFee.ToString();
            settingForm.txtEatInFee.Text = EatInFee.ToString();
            settingForm.txtDeliveryFee.Text = DeliveryFee.ToString();
        }

    }
}
