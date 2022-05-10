using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class QuotationForm : Form
    {
        #region fields
        private const string _connectionString = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=mark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        private string _commandText;
        private DateTime _date;
        private int _quotationOriginalID;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;
        private int _paperID;
        private int _securitiesID;
        private decimal _price;
        private int _paperOriginalID;
        #endregion

        public QuotationForm()
        {
            InitializeComponent();

            connection.Open();
            _commandText = "SELECT * FROM PaperView";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                _adapter = new SqlDataAdapter(firstCommand);
                _adapter.Fill(this.dataSet1.PaperView);
                comboBox1.DataSource = this.dataSet1.PaperView;
                comboBox1.DisplayMember = "Description";
                comboBox1.ValueMember = "PaperInvestmentID";
            }
            _commandText = "SELECT * FROM SecuritiesView";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                _adapter = new SqlDataAdapter(firstCommand);
                _adapter.Fill(this.dataSet1.SecuritiesView);
                comboBox2.DataSource = this.dataSet1.SecuritiesView;
                comboBox2.DisplayMember = "Description";
                comboBox2.ValueMember = "SecuritiesID";
            }
        }

        private void quotationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.quotationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }

        private void QuotationForm_Load(object sender, EventArgs e)
        {
            this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quotationBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _date = Convert.ToDateTime(dateDateTimePicker.Text);
                _securitiesID = Convert.ToInt32(comboBox2.SelectedValue);
                _paperID = Convert.ToInt32(comboBox1.SelectedValue);
                _price = Convert.ToDecimal(priceTextBox.Text);
                this.quotationTableAdapter.InsertQuery(_paperID,_price,_date,_securitiesID);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _date = Convert.ToDateTime(dateDateTimePicker.Text);
                _securitiesID = Convert.ToInt32(comboBox2.SelectedValue);
                _paperID = Convert.ToInt32(comboBox1.SelectedValue);
                _price = Convert.ToDecimal(priceTextBox.Text);
                _quotationOriginalID = Convert.ToInt32(quotationIDTextBox.Text);
                _paperOriginalID = Convert.ToInt32(paperInvestmentIDTextBox.Text);
                _commandText = "UPDATE [dbo].[Quotation] SET [PaperInvestmentID] = @PaperInvestmentID, [Price] = @Price, [Date] = @Date, [SecuritiesID] = @SecuritiesID WHERE [QuotationID] = @Original_QuotationID AND [PaperInvestmentID] = @Original_PaperInvestmentID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@PaperInvestmentID", _paperID);
                    command.Parameters.AddWithValue("@Price", _price);
                    command.Parameters.AddWithValue("@Date", _date);
                    command.Parameters.AddWithValue("@SecuritiesID", _securitiesID);
                    command.Parameters.AddWithValue("@Original_QuotationID", _quotationOriginalID);
                    command.Parameters.AddWithValue("@Original_PaperInvestmentID", _paperOriginalID);
                    _adapter.Fill(this.dataSet1);
                    this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }
        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                _paperID = Convert.ToInt32(paperInvestmentIDTextBox.Text);
                _securitiesID = Convert.ToInt32(securitiesIDTextBox.Text);
                _commandText = "SELECT Description FROM SecuritiesView where SecuritiesID = @SecuritiesID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@SecuritiesID", _securitiesID);
                    _reader = thisCommand.ExecuteReader();
                    while (_reader.Read())
                    {
                        comboBox2.Text = _reader["Description"].ToString();
                    }
                    _reader.Close();
                }
                _commandText = "SELECT Description FROM PaperView where PaperInvestmentID = @PaperInvestmentID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = _commandText;
                    thisCommand.Parameters.AddWithValue("@PaperInvestmentID", _paperID);
                    _reader = thisCommand.ExecuteReader();
                    while (_reader.Read())
                    {
                        comboBox1.Text = _reader["Description"].ToString();
                    }
                    _reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }
    }
}
