using System;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            PaperInvestmentForm paperInvestmentForm = new PaperInvestmentForm();
            paperInvestmentForm.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            BankDepositsForm bankDepositsForm = new BankDepositsForm();
            bankDepositsForm.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            BankInvestmentForm bankInvestmentForm = new BankInvestmentForm();
            bankInvestmentForm.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            QuotationForm quotationForm = new QuotationForm();
            quotationForm.ShowDialog();
            Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            SecuritiesForm securitiesForm = new SecuritiesForm();
            securitiesForm.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            PropertyTypeForm propertyTypeForm = new PropertyTypeForm();
            propertyTypeForm.ShowDialog();
            Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            StoredProcedure storedProcedure = new StoredProcedure();
            storedProcedure.ShowDialog();
            Show();
        }
    }
}
