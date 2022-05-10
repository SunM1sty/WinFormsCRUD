using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class PaperInvestmentForm : Form
    {
        #region fields
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        private string _commandText;
        private DateTime _datePurchase;
        private int _paperOriginalID;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private DateTime _dateSell;
        private int _customerID;
        private int _securitiesID;
        private decimal _transactionSum;
        #endregion

        public PaperInvestmentForm()
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

        private void PaperInvestmentForm_Load(object sender, EventArgs e)
        {
            this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paperInvestmentBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _datePurchase = Convert.ToDateTime(dataPurchaseDateTimePicker.Text);
                _dateSell = Convert.ToDateTime(dataSaleDateTimePicker.Text);
                _securitiesID = Convert.ToInt32(comboBox1.SelectedValue);
                _customerID = Convert.ToInt32(comboBox2.SelectedValue);
                _transactionSum = Convert.ToDecimal(transactionSumTextBox.Text);
                this.paperInvestmentTableAdapter.InsertQuery(_datePurchase,_dateSell,_securitiesID,_transactionSum,_customerID);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _datePurchase = Convert.ToDateTime(dataPurchaseDateTimePicker.Text);
                _dateSell = Convert.ToDateTime(dataSaleDateTimePicker.Text);
                _securitiesID = Convert.ToInt32(comboBox1.SelectedValue);
                _customerID = Convert.ToInt32(comboBox2.SelectedValue);
                _transactionSum = Convert.ToDecimal(transactionSumTextBox.Text);
                _paperOriginalID = Convert.ToInt32(paperInvestmentIDTextBox.Text);
                _commandText = "UPDATE [dbo].[PaperInvestment] SET [DataPurchase] = @DataPurchase, [DataSale] = @DataSale, [SecuritiesID] = @SecuritiesID, [TransactionSum] = @TransactionSum, [CustomerID] = @CustomerID WHERE [PaperInvestmentID] = @Original_PaperInvestmentID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@DataPurchase", _datePurchase);
                    command.Parameters.AddWithValue("@DataSale", _dateSell);
                    command.Parameters.AddWithValue("@SecuritiesID", _securitiesID);
                    command.Parameters.AddWithValue("@TransactionSum", _transactionSum);
                    command.Parameters.AddWithValue("@CustomerID", _customerID);
                    command.Parameters.AddWithValue("@Original_PaperInvestmentID", _paperOriginalID);
                    _adapter.Fill(this.dataSet1);
                    this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                _customerID = Convert.ToInt32(customerIDTextBox.Text);
                _securitiesID = Convert.ToInt32(securitiesIDTextBox.Text);
                _commandText = "SELECT Description FROM SecuritiesView where SecuritiesID = @SecuritiesID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@SecuritiesID", _securitiesID);
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
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }

        private void paperInvestmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paperInvestmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }
    } 
}
