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
    public partial class BankInvestmentForm : Form
    {
        public BankInvestmentForm()
        {
            InitializeComponent();
        }

        private void bankInvestmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankInvestmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.bankInvestmentTableAdapter.Fill(this.dataSet1.BankInvestment);
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
            bankInvestmentBindingSource.EndEdit();
            bankInvestmentTableAdapter.Update(dataSet1);
        }
    }
}
