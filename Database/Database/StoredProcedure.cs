using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class StoredProcedure : Form
    {
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=dbomark;Integrated Security=True";
        public string customerChoose;
        public StoredProcedure()
        {
            InitializeComponent();
        }

        private void bankInvestmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bankInvestmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void StoredProcedure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PaperInvestment' table. You can move, or remove it, as needed.
            this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            // TODO: This line of code loads data into the 'dataSet1.BankInvestment' table. You can move, or remove it, as needed.
            this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlExpression = "AddInvestment";
            var dataSale = Convert.ToDateTime(dataSaleDateTimePicker.Text);
            var datePurchase = Convert.ToDateTime(datePurchaseDateTimePicker.Text);
            var transactionSum = Convert.ToDouble(transactionSumTextBox.Text);
            var customerID = Convert.ToInt32(customerIDTextBox.Text);
            var investID = Convert.ToInt32(bankDepositIDTextBox.Text);
            if ((customerChoose != "bank") && (customerChoose != "paper"))
            {
                MessageBox.Show("Choose something ");
                return;
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlExpression,connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DataSale", dataSale);
                    command.Parameters.AddWithValue("@DatePurchase", datePurchase);
                    command.Parameters.AddWithValue("@TransactionSum", transactionSum);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@InvestID", investID);
                    command.Parameters.AddWithValue("@CustomerChoose", customerChoose);
                    this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
                    this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(this.dataSet1);
                        this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
                        this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
                    }
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                customerChoose = "bank";
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                customerChoose = "paper";
            }
        }
    }
}
