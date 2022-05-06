namespace Database
{
    partial class BankInvestmentForm
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
            System.Windows.Forms.Label datePurchaseLabel;
            System.Windows.Forms.Label dataSaleLabel;
            System.Windows.Forms.Label bankDepositIDLabel;
            System.Windows.Forms.Label transactionSumLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankInvestmentForm));
            this.dataSet1 = new Database.DataSet1();
            this.bankInvestmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankInvestmentTableAdapter = new Database.DataSet1TableAdapters.BankInvestmentTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.bankInvestmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bankInvestmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bankInvestmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankDepositIDTextBox = new System.Windows.Forms.TextBox();
            this.transactionSumTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            datePurchaseLabel = new System.Windows.Forms.Label();
            dataSaleLabel = new System.Windows.Forms.Label();
            bankDepositIDLabel = new System.Windows.Forms.Label();
            transactionSumLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingNavigator)).BeginInit();
            this.bankInvestmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // datePurchaseLabel
            // 
            datePurchaseLabel.AutoSize = true;
            datePurchaseLabel.Location = new System.Drawing.Point(675, 55);
            datePurchaseLabel.Name = "datePurchaseLabel";
            datePurchaseLabel.Size = new System.Drawing.Size(81, 13);
            datePurchaseLabel.TabIndex = 4;
            datePurchaseLabel.Text = "Date Purchase:";
            // 
            // dataSaleLabel
            // 
            dataSaleLabel.AutoSize = true;
            dataSaleLabel.Location = new System.Drawing.Point(675, 81);
            dataSaleLabel.Name = "dataSaleLabel";
            dataSaleLabel.Size = new System.Drawing.Size(57, 13);
            dataSaleLabel.TabIndex = 6;
            dataSaleLabel.Text = "Data Sale:";
            // 
            // bankDepositIDLabel
            // 
            bankDepositIDLabel.AutoSize = true;
            bankDepositIDLabel.Location = new System.Drawing.Point(675, 106);
            bankDepositIDLabel.Name = "bankDepositIDLabel";
            bankDepositIDLabel.Size = new System.Drawing.Size(88, 13);
            bankDepositIDLabel.TabIndex = 8;
            bankDepositIDLabel.Text = "Bank Deposit ID:";
            // 
            // transactionSumLabel
            // 
            transactionSumLabel.AutoSize = true;
            transactionSumLabel.Location = new System.Drawing.Point(675, 132);
            transactionSumLabel.Name = "transactionSumLabel";
            transactionSumLabel.Size = new System.Drawing.Size(90, 13);
            transactionSumLabel.TabIndex = 10;
            transactionSumLabel.Text = "Transaction Sum:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(675, 158);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 12;
            customerIDLabel.Text = "Customer ID:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankInvestmentBindingSource
            // 
            this.bankInvestmentBindingSource.DataMember = "BankInvestment";
            this.bankInvestmentBindingSource.DataSource = this.dataSet1;
            // 
            // bankInvestmentTableAdapter
            // 
            this.bankInvestmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankDepositsTableAdapter = null;
            this.tableAdapterManager.BankInvestmentTableAdapter = this.bankInvestmentTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.PaperInvestmentTableAdapter = null;
            this.tableAdapterManager.PropertyTypeTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SecuritiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankInvestmentBindingNavigator
            // 
            this.bankInvestmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankInvestmentBindingNavigator.BindingSource = this.bankInvestmentBindingSource;
            this.bankInvestmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankInvestmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankInvestmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bankInvestmentBindingNavigatorSaveItem});
            this.bankInvestmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bankInvestmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankInvestmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankInvestmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankInvestmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankInvestmentBindingNavigator.Name = "bankInvestmentBindingNavigator";
            this.bankInvestmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankInvestmentBindingNavigator.Size = new System.Drawing.Size(1026, 25);
            this.bankInvestmentBindingNavigator.TabIndex = 0;
            this.bankInvestmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bankInvestmentBindingNavigatorSaveItem
            // 
            this.bankInvestmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankInvestmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankInvestmentBindingNavigatorSaveItem.Image")));
            this.bankInvestmentBindingNavigatorSaveItem.Name = "bankInvestmentBindingNavigatorSaveItem";
            this.bankInvestmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bankInvestmentBindingNavigatorSaveItem.Text = "Save Data";
            this.bankInvestmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankInvestmentBindingNavigatorSaveItem_Click);
            // 
            // bankInvestmentDataGridView
            // 
            this.bankInvestmentDataGridView.AutoGenerateColumns = false;
            this.bankInvestmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankInvestmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bankInvestmentDataGridView.DataSource = this.bankInvestmentBindingSource;
            this.bankInvestmentDataGridView.Location = new System.Drawing.Point(12, 28);
            this.bankInvestmentDataGridView.Name = "bankInvestmentDataGridView";
            this.bankInvestmentDataGridView.Size = new System.Drawing.Size(646, 399);
            this.bankInvestmentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BankInvestmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BankInvestmentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DatePurchase";
            this.dataGridViewTextBoxColumn2.HeaderText = "DatePurchase";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataSale";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataSale";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BankDepositID";
            this.dataGridViewTextBoxColumn4.HeaderText = "BankDepositID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TransactionSum";
            this.dataGridViewTextBoxColumn5.HeaderText = "TransactionSum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // datePurchaseDateTimePicker
            // 
            this.datePurchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bankInvestmentBindingSource, "DatePurchase", true));
            this.datePurchaseDateTimePicker.Location = new System.Drawing.Point(785, 51);
            this.datePurchaseDateTimePicker.Name = "datePurchaseDateTimePicker";
            this.datePurchaseDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.datePurchaseDateTimePicker.TabIndex = 5;
            // 
            // dataSaleDateTimePicker
            // 
            this.dataSaleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bankInvestmentBindingSource, "DataSale", true));
            this.dataSaleDateTimePicker.Location = new System.Drawing.Point(785, 77);
            this.dataSaleDateTimePicker.Name = "dataSaleDateTimePicker";
            this.dataSaleDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.dataSaleDateTimePicker.TabIndex = 7;
            // 
            // bankDepositIDTextBox
            // 
            this.bankDepositIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankInvestmentBindingSource, "BankDepositID", true));
            this.bankDepositIDTextBox.Location = new System.Drawing.Point(785, 103);
            this.bankDepositIDTextBox.Name = "bankDepositIDTextBox";
            this.bankDepositIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.bankDepositIDTextBox.TabIndex = 9;
            // 
            // transactionSumTextBox
            // 
            this.transactionSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankInvestmentBindingSource, "TransactionSum", true));
            this.transactionSumTextBox.Location = new System.Drawing.Point(785, 129);
            this.transactionSumTextBox.Name = "transactionSumTextBox";
            this.transactionSumTextBox.Size = new System.Drawing.Size(140, 20);
            this.transactionSumTextBox.TabIndex = 11;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankInvestmentBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(785, 155);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.customerIDTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BankInvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(datePurchaseLabel);
            this.Controls.Add(this.datePurchaseDateTimePicker);
            this.Controls.Add(dataSaleLabel);
            this.Controls.Add(this.dataSaleDateTimePicker);
            this.Controls.Add(bankDepositIDLabel);
            this.Controls.Add(this.bankDepositIDTextBox);
            this.Controls.Add(transactionSumLabel);
            this.Controls.Add(this.transactionSumTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.bankInvestmentDataGridView);
            this.Controls.Add(this.bankInvestmentBindingNavigator);
            this.Name = "BankInvestmentForm";
            this.Text = "BankInvestmentForm";
            this.Load += new System.EventHandler(this.BankInvestmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingNavigator)).EndInit();
            this.bankInvestmentBindingNavigator.ResumeLayout(false);
            this.bankInvestmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bankInvestmentBindingSource;
        private DataSet1TableAdapters.BankInvestmentTableAdapter bankInvestmentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankInvestmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bankInvestmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bankInvestmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker datePurchaseDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaleDateTimePicker;
        private System.Windows.Forms.TextBox bankDepositIDTextBox;
        private System.Windows.Forms.TextBox transactionSumTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}