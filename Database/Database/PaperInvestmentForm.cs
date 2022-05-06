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
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Quotation__Paper"))
                {
                    MessageBox.Show("Ошибка: вы пытаетесь удалить запись связанную с записью в таблице Quotation");
                }
                if (ex.Message.Contains("Securities"))
                {
                    MessageBox.Show("Ошибка: вы пытаетесь удалить запись связанную с записью в таблице Securities");
                }
                if (ex.Message.Contains("Customers"))
                {
                    MessageBox.Show("Ошибка: вы пытаетесь удалить запись связанную с записью в таблице Customers");
                }
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
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
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.paperInvestmentTableAdapter.Fill(this.dataSet1.PaperInvestment);
            }
        }
    }
}
