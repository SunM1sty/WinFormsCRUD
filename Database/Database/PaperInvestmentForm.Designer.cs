﻿namespace Database
{
    partial class PaperInvestmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataPurchaseLabel;
            System.Windows.Forms.Label dataSaleLabel;
            System.Windows.Forms.Label securitiesIDLabel;
            System.Windows.Forms.Label transactionSumLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaperInvestmentForm));
            this.paperInvestmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paperInvestmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paperInvestmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.securitiesIDTextBox = new System.Windows.Forms.TextBox();
            this.transactionSumTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paperInvestmentIDTextBox = new System.Windows.Forms.TextBox();
            this.paperInvestmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Database.DataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperInvestmentTableAdapter = new Database.DataSet1TableAdapters.PaperInvestmentTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            dataPurchaseLabel = new System.Windows.Forms.Label();
            dataSaleLabel = new System.Windows.Forms.Label();
            securitiesIDLabel = new System.Windows.Forms.Label();
            transactionSumLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingNavigator)).BeginInit();
            this.paperInvestmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPurchaseLabel
            // 
            dataPurchaseLabel.AutoSize = true;
            dataPurchaseLabel.Location = new System.Drawing.Point(836, 52);
            dataPurchaseLabel.Name = "dataPurchaseLabel";
            dataPurchaseLabel.Size = new System.Drawing.Size(81, 13);
            dataPurchaseLabel.TabIndex = 4;
            dataPurchaseLabel.Text = "Data Purchase:";
            // 
            // dataSaleLabel
            // 
            dataSaleLabel.AutoSize = true;
            dataSaleLabel.Location = new System.Drawing.Point(836, 78);
            dataSaleLabel.Name = "dataSaleLabel";
            dataSaleLabel.Size = new System.Drawing.Size(57, 13);
            dataSaleLabel.TabIndex = 6;
            dataSaleLabel.Text = "Data Sale:";
            // 
            // securitiesIDLabel
            // 
            securitiesIDLabel.AutoSize = true;
            securitiesIDLabel.Location = new System.Drawing.Point(836, 103);
            securitiesIDLabel.Name = "securitiesIDLabel";
            securitiesIDLabel.Size = new System.Drawing.Size(70, 13);
            securitiesIDLabel.TabIndex = 8;
            securitiesIDLabel.Text = "Securities ID:";
            // 
            // transactionSumLabel
            // 
            transactionSumLabel.AutoSize = true;
            transactionSumLabel.Location = new System.Drawing.Point(836, 129);
            transactionSumLabel.Name = "transactionSumLabel";
            transactionSumLabel.Size = new System.Drawing.Size(90, 13);
            transactionSumLabel.TabIndex = 10;
            transactionSumLabel.Text = "Transaction Sum:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(836, 157);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 12;
            customerIDLabel.Text = "Customer ID:";
            // 
            // paperInvestmentBindingNavigator
            // 
            this.paperInvestmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paperInvestmentBindingNavigator.BindingSource = this.paperInvestmentBindingSource;
            this.paperInvestmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paperInvestmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paperInvestmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.paperInvestmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paperInvestmentBindingNavigatorSaveItem});
            this.paperInvestmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paperInvestmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paperInvestmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paperInvestmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paperInvestmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paperInvestmentBindingNavigator.Name = "paperInvestmentBindingNavigator";
            this.paperInvestmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paperInvestmentBindingNavigator.Size = new System.Drawing.Size(1383, 27);
            this.paperInvestmentBindingNavigator.TabIndex = 0;
            this.paperInvestmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigator);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // paperInvestmentBindingNavigatorSaveItem
            // 
            this.paperInvestmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paperInvestmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paperInvestmentBindingNavigatorSaveItem.Image")));
            this.paperInvestmentBindingNavigatorSaveItem.Name = "paperInvestmentBindingNavigatorSaveItem";
            this.paperInvestmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.paperInvestmentBindingNavigatorSaveItem.Text = "Save Data";
            this.paperInvestmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paperInvestmentBindingNavigatorSaveItem_Click);
            // 
            // paperInvestmentDataGridView
            // 
            this.paperInvestmentDataGridView.AutoGenerateColumns = false;
            this.paperInvestmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperInvestmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.paperInvestmentDataGridView.DataSource = this.paperInvestmentBindingSource;
            this.paperInvestmentDataGridView.Location = new System.Drawing.Point(12, 28);
            this.paperInvestmentDataGridView.Name = "paperInvestmentDataGridView";
            this.paperInvestmentDataGridView.RowHeadersWidth = 51;
            this.paperInvestmentDataGridView.Size = new System.Drawing.Size(806, 410);
            this.paperInvestmentDataGridView.TabIndex = 1;
            // 
            // dataPurchaseDateTimePicker
            // 
            this.dataPurchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paperInvestmentBindingSource, "DataPurchase", true));
            this.dataPurchaseDateTimePicker.Location = new System.Drawing.Point(949, 48);
            this.dataPurchaseDateTimePicker.Name = "dataPurchaseDateTimePicker";
            this.dataPurchaseDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.dataPurchaseDateTimePicker.TabIndex = 5;
            // 
            // dataSaleDateTimePicker
            // 
            this.dataSaleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paperInvestmentBindingSource, "DataSale", true));
            this.dataSaleDateTimePicker.Location = new System.Drawing.Point(949, 74);
            this.dataSaleDateTimePicker.Name = "dataSaleDateTimePicker";
            this.dataSaleDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.dataSaleDateTimePicker.TabIndex = 7;
            // 
            // securitiesIDTextBox
            // 
            this.securitiesIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperInvestmentBindingSource, "SecuritiesID", true));
            this.securitiesIDTextBox.Location = new System.Drawing.Point(788, 472);
            this.securitiesIDTextBox.Name = "securitiesIDTextBox";
            this.securitiesIDTextBox.Size = new System.Drawing.Size(28, 20);
            this.securitiesIDTextBox.TabIndex = 9;
            // 
            // transactionSumTextBox
            // 
            this.transactionSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperInvestmentBindingSource, "TransactionSum", true));
            this.transactionSumTextBox.Location = new System.Drawing.Point(949, 126);
            this.transactionSumTextBox.Name = "transactionSumTextBox";
            this.transactionSumTextBox.Size = new System.Drawing.Size(144, 20);
            this.transactionSumTextBox.TabIndex = 11;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperInvestmentBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(750, 472);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(16, 20);
            this.customerIDTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1041, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(937, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(949, 100);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(949, 155);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // paperInvestmentIDTextBox
            // 
            this.paperInvestmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paperInvestmentBindingSource, "PaperInvestmentID", true));
            this.paperInvestmentIDTextBox.Location = new System.Drawing.Point(853, 472);
            this.paperInvestmentIDTextBox.Name = "paperInvestmentIDTextBox";
            this.paperInvestmentIDTextBox.Size = new System.Drawing.Size(44, 20);
            this.paperInvestmentIDTextBox.TabIndex = 19;
            // 
            // paperInvestmentBindingSource
            // 
            this.paperInvestmentBindingSource.DataMember = "PaperInvestment";
            this.paperInvestmentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaperInvestmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaperInvestmentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataPurchase";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataPurchase";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataSale";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataSale";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SecuritiesID";
            this.dataGridViewTextBoxColumn4.HeaderText = "SecuritiesID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TransactionSum";
            this.dataGridViewTextBoxColumn5.HeaderText = "TransactionSum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // paperInvestmentTableAdapter
            // 
            this.paperInvestmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankDepositsTableAdapter = null;
            this.tableAdapterManager.BankInvestmentTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.PaperInvestmentTableAdapter = this.paperInvestmentTableAdapter;
            this.tableAdapterManager.PropertyTypeTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SecuritiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PaperInvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 453);
            this.Controls.Add(this.paperInvestmentIDTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(dataPurchaseLabel);
            this.Controls.Add(this.dataPurchaseDateTimePicker);
            this.Controls.Add(dataSaleLabel);
            this.Controls.Add(this.dataSaleDateTimePicker);
            this.Controls.Add(securitiesIDLabel);
            this.Controls.Add(this.securitiesIDTextBox);
            this.Controls.Add(transactionSumLabel);
            this.Controls.Add(this.transactionSumTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.paperInvestmentDataGridView);
            this.Controls.Add(this.paperInvestmentBindingNavigator);
            this.Name = "PaperInvestmentForm";
            this.Text = "PaperInvestmentForm";
            this.Load += new System.EventHandler(this.PaperInvestmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingNavigator)).EndInit();
            this.paperInvestmentBindingNavigator.ResumeLayout(false);
            this.paperInvestmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paperInvestmentBindingSource;
        private DataSet1TableAdapters.PaperInvestmentTableAdapter paperInvestmentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paperInvestmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton paperInvestmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView paperInvestmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker dataPurchaseDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaleDateTimePicker;
        private System.Windows.Forms.TextBox securitiesIDTextBox;
        private System.Windows.Forms.TextBox transactionSumTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox paperInvestmentIDTextBox;
    }
}