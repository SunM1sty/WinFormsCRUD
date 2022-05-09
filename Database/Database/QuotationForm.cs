using System;
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
                quotationBindingSource.EndEdit();
                quotationTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.quotationTableAdapter.Fill(this.dataSet1.Quotation);
            }
        }
    }
}
