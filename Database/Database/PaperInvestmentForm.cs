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
        private double _transactionSum;
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
                comboBox1.DataSource = this.dataSet1.CustomerView;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "CustomerID";
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
                _transactionSum = Convert.ToDouble(transactionSumTextBox.Text);
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
                _transactionSum = Convert.ToDouble(transactionSumTextBox.Text);

                _commandText = "UPDATE Customers SET Name = @Name, Adress = @Adress, Phone = @Phone, PropertyID = @PropertyID WHERE CustomerID = @Original_CustomerID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    //_adapter = new SqlDataAdapter(command);
                    //command.Parameters.AddWithValue("@Name", _name);
                    //command.Parameters.AddWithValue("@Adress", _adress);
                    //command.Parameters.AddWithValue("@Phone", _phone);
                    //command.Parameters.AddWithValue("@PropertyID", _propertyID);
                    //command.Parameters.AddWithValue("@Original_CustomerID", _customerOriginalID);
                    //_adapter.Fill(this.dataSet1);
                    //this.customersTableAdapter.Fill(this.dataSet1.Customers);
                    //this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
        }
    }
}
