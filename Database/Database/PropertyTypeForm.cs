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
    public partial class PropertyTypeForm : Form
    {
        public PropertyTypeForm()
        {
            InitializeComponent();
        }

        private void propertyTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.propertyTypeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
            }
        }

        private void PropertyTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PropertyType' table. You can move, or remove it, as needed.
            this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertyTypeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            propertyTypeBindingSource.EndEdit();
            propertyTypeTableAdapter.Update(dataSet1);
        }
    }
}
