using System;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
            }
        }

        private void PropertyTypeForm_Load(object sender, EventArgs e)
        {
            this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertyTypeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                propertyTypeBindingSource.EndEdit();
                propertyTypeTableAdapter.Update(dataSet1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.propertyTypeTableAdapter.Fill(this.dataSet1.PropertyType);
            }
        }
    }
}
