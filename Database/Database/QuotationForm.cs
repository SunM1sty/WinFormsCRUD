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
    public partial class QuotationForm : Form
    {
        public QuotationForm()
        {
            InitializeComponent();
        }

        private void quotationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.quotationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }

        private void QuotationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Quotation' table. You can move, or remove it, as needed.
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
                quotationBindingSource.EndEdit();
                quotationTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PaperInvestmentID"))
                {
                    MessageBox.Show("Вы не указали PaperInvestmentID!");
                    this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
                }
            }
        }
    }
}
