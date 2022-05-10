using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class CustomerForm : Form
    {
        #region fields
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        private string _commandText;
        private int _propertyID;
        private int _customerOriginalID;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private string _name;
        private string _adress;
        private string _phone;
        #endregion
        public CustomerForm()
        {
            InitializeComponent();

            connection.Open();
            _commandText = "SELECT * FROM PropertyTypeView";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                _adapter = new SqlDataAdapter(firstCommand);
                _adapter.Fill(this.dataSet1.PropertyTypeView);
                comboBox1.DataSource = this.dataSet1.PropertyTypeView;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "PropertyID";
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PropertyType' table. You can move, or remove it, as needed.
            this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
            // TODO: This line of code loads data into the 'dataSet1.PropertyTypeView' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _name = nameTextBox.Text;
                _phone = phoneTextBox.Text;
                _adress = adressTextBox.Text;
                _propertyID = Convert.ToInt32(comboBox1.SelectedValue);
                this.customersTableAdapter.InsertQuery(_name,_adress,_phone, _propertyID);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _name = Convert.ToString(nameTextBox.Text);
                _phone = Convert.ToString(phoneTextBox.Text);
                _adress = Convert.ToString(adressTextBox.Text);
                _propertyID = Convert.ToInt32(comboBox1.SelectedValue);
                _customerOriginalID = Convert.ToInt32(customerIDTextBox.Text);
                _commandText = "UPDATE Customers SET Name = @Name, Adress = @Adress, Phone = @Phone, PropertyID = @PropertyID WHERE CustomerID = @Original_CustomerID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@Name", _name);
                    command.Parameters.AddWithValue("@Adress", _adress);
                    command.Parameters.AddWithValue("@Phone", _phone);
                    command.Parameters.AddWithValue("@PropertyID", _propertyID);
                    command.Parameters.AddWithValue("@Original_CustomerID", _customerOriginalID);
                    _adapter.Fill(this.dataSet1);
                    this.customersTableAdapter.Fill(this.dataSet1.Customers);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
        }


        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                _propertyID = Convert.ToInt32(propertyIDTextBox.Text);
                _commandText = "SELECT Name FROM PropertyTypeView where PropertyID = @PropertyID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@PropertyID", _propertyID);
                    _reader = thisCommand.ExecuteReader();
                    while (_reader.Read())
                    {
                        comboBox1.Text = _reader["Name"].ToString();
                    }
                    _reader.Close();
                }
                this.Validate();
                customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
        }
    }
}
