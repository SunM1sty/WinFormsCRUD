using System;
using System.Windows.Forms;

namespace Database
{
    public partial class BankDepositsForm : Form
    {
        public BankDepositsForm()
        {
            InitializeComponent();
        }

        private void bankDepositsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankDepositsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
            }

        }

        private void BankDepositsForm_Load(object sender, EventArgs e)
        {
            this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bankDepositsBindingSource.EndEdit();
                bankDepositsTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("MinimumDeposit"))
                {
                    MessageBox.Show("Минимальная сумма депозита не менее 10тыс. и не более 1 млрд.");
                    this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
                }
                else if (ex.Message.Contains("PercentPerYear"))
                {
                    MessageBox.Show("Максимальный процент в год не более 20%");
                    this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankDepositsBindingSource.AddNew();
        }
    }
}
