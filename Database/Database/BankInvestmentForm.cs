using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class BankInvestmentForm : Form
    {
        #region fields
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        private string _commandText;
        private DateTime _datePurchase;
        private int _bankOriginalID;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private DateTime _dateSell;
        private int _customerID;
        private int _bankDepositID;
        private decimal _transactionSum;
        #endregion

        public BankInvestmentForm()
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

        private void bankInvestmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankInvestmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
            }

        }

        private void BankInvestmentForm_Load(object sender, EventArgs e)
        {
            this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankInvestmentBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _datePurchase = Convert.ToDateTime(datePurchaseDateTimePicker.Text);
                _dateSell = Convert.ToDateTime(dataSaleDateTimePicker.Text);
                _bankDepositID = Convert.ToInt32(comboBox1.SelectedValue);
                _customerID = Convert.ToInt32(comboBox2.SelectedValue);
                _transactionSum = Convert.ToDecimal(transactionSumTextBox.Text);
                this.bankInvestmentTableAdapter.InsertQuery(_datePurchase, _dateSell, _bankDepositID, _transactionSum, _customerID);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _datePurchase = Convert.ToDateTime(datePurchaseDateTimePicker.Text);
                _dateSell = Convert.ToDateTime(dataSaleDateTimePicker.Text);
                _bankDepositID = Convert.ToInt32(comboBox1.SelectedValue);
                _customerID = Convert.ToInt32(comboBox2.SelectedValue);
                _transactionSum = Convert.ToDecimal(transactionSumTextBox.Text);
                _bankOriginalID = Convert.ToInt32(bankInvestmentIDTextBox.Text);
                _commandText = "UPDATE [dbo].[BankInvestment] SET [DatePurchase] = @DatePurchase, [DataSale] = @DataSale, [BankDepositID] = @BankDepositID, [TransactionSum] = @TransactionSum, [CustomerID] = @CustomerID WHERE [BankInvestmentID] = @Original_BankInvestmentID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@DatePurchase", _datePurchase);
                    command.Parameters.AddWithValue("@DataSale", _dateSell);
                    command.Parameters.AddWithValue("@BankDepositID", _bankDepositID);
                    command.Parameters.AddWithValue("@TransactionSum", _transactionSum);
                    command.Parameters.AddWithValue("@CustomerID", _customerID);
                    command.Parameters.AddWithValue("@Original_BankInvestmentID", _bankOriginalID);
                    _adapter.Fill(this.dataSet1);
                    this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
            }
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                _customerID = Convert.ToInt32(customerIDTextBox.Text);
                _bankDepositID = Convert.ToInt32(bankDepositIDTextBox.Text);
                _commandText = "SELECT Description FROM BankDepositsView where BankDepositID = @BankDepositID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@BankDepositID", _bankDepositID);
                    _reader = thisCommand.ExecuteReader();
                    while (_reader.Read())
                    {
                        comboBox1.Text = _reader["Description"].ToString();
                    }
                    _reader.Close();
                }
                _commandText = "SELECT Name FROM CustomerView where CustomerID = @CustomerID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@CustomerID", _customerID);
                    _reader = thisCommand.ExecuteReader();
                    while (_reader.Read())
                    {
                        comboBox2.Text = _reader["Name"].ToString();
                    }
                    _reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
            }
        }
    }
}
