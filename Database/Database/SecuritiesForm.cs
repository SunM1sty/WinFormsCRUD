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
            catch (SqlException ex)
            {
                if (ex.Message.Contains("dbo.Quotation"))
                {
                    MessageBox.Show("Вы пытаетесь удалить запись, связанную с записью в таблице Quotation");
                }
                this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.securitiesTableAdapter.Fill(this.dataSet1.Securities);
            }
        }

        private void SecuritiesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Securities' table. You can move, or remove it, as needed.
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
                if (ex.Message.Contains("ValidSumm"))
                {
                    MessageBox.Show("Вы указали неправильную сумму!!!!!!!!!!!!!!");
                }
            }
        }
    }
}
