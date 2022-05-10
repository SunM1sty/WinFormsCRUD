using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class StoredProcedure : Form
    {
   
        #region fields
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        private string _customerChoose;
        private string _commandText;
        private DateTime _datePurchase;
        private SqlDataAdapter _adapter;
        private DateTime _dateSell;
        private int _customerID;
        private int _investmentID;
        private decimal _transactionSum;
        #endregion


        public StoredProcedure()
        {
            InitializeComponent();

            connection.Open();
            _commandText = "SELECT * FROM CustomerView";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                _adapter = new SqlDataAdapter(firstCommand);
                _adapter.Fill(this.dataSet1.CustomerView);
                comboBox2.DataSource = this.dataSet1.CustomerView;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "CustomerID";
            }
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
                var customerID = Convert.ToInt32(comboBox2.SelectedValue);
                var investID = Convert.ToInt32(comboBox1.SelectedValue);
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
                _commandText = "SELECT * FROM BankDepositsView";
                using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(firstCommand);
                    _adapter.Fill(this.dataSet1.BankDepositsView);
                    comboBox1.DataSource = this.dataSet1.BankDepositsView;
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "BankDepositID";
                }
            }

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                _customerChoose = "paper";
                _commandText = "SELECT * FROM SecuritiesView";
                using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(firstCommand);
                    _adapter.Fill(this.dataSet1.SecuritiesView);
                    comboBox1.DataSource = this.dataSet1.SecuritiesView;
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "SecuritiesID";
                }
            }
        }
    }
}
