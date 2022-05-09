using System;
using System.Windows.Forms;

namespace Database
{
    public partial class PaperInvestmentForm : Form
    {
        public PaperInvestmentForm()
        {
            InitializeComponent();
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
                paperInvestmentBindingSource.EndEdit();
                paperInvestmentTableAdapter.Update(dataSet1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }
    }
}
