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
            catch (SqlException ex)
            {        
                MessageBox.Show(ex.Message);
                this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
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

        private void bankDepositsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bankDepositsBindingSource.EndEdit();
                bankDepositsTableAdapter.Update(dataSet1);
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("CK__BankDepos__Minim__59FA5E80"))
                {
                    MessageBox.Show("Ошибка: вы ввели неправильную сумму минимального депозита");
                }
                if (ex.Message.Contains("CK__BankDepos__Perce__5AEE82B9"))
                {
                    MessageBox.Show("Ошибка: вы ввели неправильную процент мин. дпепозита");
                    MessageBox.Show(ex.Message);
                }
                this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.bankDepositsTableAdapter.Fill(this.dataSet1.BankDeposits);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankDepositsBindingSource.AddNew();
        }
    }
}
