using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database
{
    public partial class SecuritiesForm : Form
    {
        public SecuritiesForm()
        {
            InitializeComponent();
        }

        private void securitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.securitiesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
            }
        }

        private void SecuritiesForm_Load(object sender, EventArgs e)
        {
            this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            securitiesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                securitiesBindingSource.EndEdit();
                securitiesTableAdapter.Update(dataSet1);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("CheckMinimumDepositSum"))
                {
                    MessageBox.Show("Минимальная сумма депозита не менее 10тыс. и не более 1 млрд.");
                    this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
                }
            }
        }
    }
}
