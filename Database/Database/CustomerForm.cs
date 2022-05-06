﻿using System;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.customersTableAdapter.Fill(this.dataSet1.Customers);
            }

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                customersBindingSource.EndEdit();
                customersTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PropertyID"))
                {
                    MessageBox.Show("Вы не указали PropertyID!");
                    this.customersTableAdapter.Fill(this.dataSet1.Customers);
                }
            }
        }
    }
}