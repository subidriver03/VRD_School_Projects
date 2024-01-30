namespace Turner_SalesTaxCalc_Project
{
    public partial class frmBbvstc : Form
    {
        public frmBbvstc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMama_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbWarranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWarranty.SelectedItem == null)
            {
                MessageBox.Show("Please select a warranty option.");
                return;
            }

            string warrantySelection = cmbWarranty.SelectedItem.ToString();
            double warrantyCost = 0;

            switch (warrantySelection)
            {
                case "One Year":
                    warrantyCost = 1000;
                    break;
                case "Two Year":
                    warrantyCost = 2000;
                    break;
                case "Three Year":
                    warrantyCost = 3000;
                    break;
                default:
                    warrantyCost = 0;
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPriceWholeDollar_TextChanged(object sender, EventArgs e)
        {
            string basePriceText = txtPriceWholeDollar.Text;
            basePriceText = basePriceText.Replace("$", "").Replace(",", "");

            if (string.IsNullOrWhiteSpace(basePriceText) || !double.TryParse(basePriceText, out double basePrice))
            {
                MessageBox.Show("Results Have been Cleared .");
                txtPriceWholeDollar.Focus();
                return;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            {
                string basePriceText = txtPriceWholeDollar.Text.Replace("$", "").Replace(",", "");
                if (string.IsNullOrWhiteSpace(basePriceText) || !double.TryParse(basePriceText, out double basePrice))
                {
                    MessageBox.Show("Please enter a valid base price.");
                    txtPriceWholeDollar.Focus();
                    return;
                }

                string warrantySelection = cmbWarranty.SelectedItem?.ToString() ?? "";
                double warrantyCost = 0;
                switch (warrantySelection)
                {
                    case "One Year":
                        warrantyCost = 1000;
                        break;
                    case "Two Year":
                        warrantyCost = 2000;
                        break;
                    case "Three Year":
                        warrantyCost = 3000;
                        break;
                    default:
                        warrantyCost = 0;
                        break;
                }
                string selectedLocation = cmbStateSelect.SelectedItem?.ToString() ?? "";
                double salesTaxRate = selectedLocation == "WA" ? 0.086 : 0;

                double totalCostBeforeTax = basePrice + warrantyCost;
                double taxAmount = totalCostBeforeTax * salesTaxRate;
                double totalCostAfterTax = totalCostBeforeTax + taxAmount;

                lblResult.Font = new Font(lblResult.Font.FontFamily, 20, FontStyle.Bold);

                lblResult.Text = $"Total Vehicle cost is ${totalCostAfterTax:0,0.00}";
            }
        }

        private void lblStateSold_Click(object sender, EventArgs e)
        {

        }

        private void cmbStateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLocation = cmbStateSelect.SelectedItem.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            {
                txtPriceWholeDollar.Text = "";
                cmbWarranty.SelectedIndex = 0;
                cmbStateSelect.SelectedIndex = 0;
                lblResult.Text = "";
                txtPriceWholeDollar.Focus();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTotalResult_Click(object sender, EventArgs e)
        {

        }
    }
}