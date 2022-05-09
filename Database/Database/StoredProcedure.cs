using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class StoredProcedure : Form
    {
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        private string _customerChoose;

        public StoredProcedure()
        {
            InitializeComponent();
        }

        private void StoredProcedure_Load(object sender, EventArgs e)
        {
            this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlExpression = "SelectInvestment";
                var dataSale = Convert.ToDateTime(dataSaleDateTimePicker.Text);
                var datePurchase = Convert.ToDateTime(datePurchaseDateTimePicker.Text);
                var transactionSum = Convert.ToDouble(transactionSumTextBox.Text);
                var customerID = Convert.ToInt32(customerIDTextBox.Text);
                var investID = Convert.ToInt32(bankDepositIDTextBox.Text);
                if ((_customerChoose != "bank") && (_customerChoose != "paper"))
                {
                    MessageBox.Show("Choose something ");
                    return;
                }
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DataSale", dataSale);
                        command.Parameters.AddWithValue("@DatePurchase", datePurchase);
                        command.Parameters.AddWithValue("@TransactionSum", transactionSum);
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@InvestID", investID);
                        command.Parameters.AddWithValue("@CustomerChoose", _customerChoose);
                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            da.Fill(this.dataSet1);
                            this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
                            this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                _customerChoose = "bank";
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                _customerChoose = "paper";
            }
        }
    }
}
