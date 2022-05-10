namespace Database
{
    partial class StoredProcedure
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
            this.bankInvestmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankInvestmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Database.DataSet1();
            this.paperInvestmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperInvestmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionSumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bankInvestmentTableAdapter = new Database.DataSet1TableAdapters.BankInvestmentTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.paperInvestmentTableAdapter = new Database.DataSet1TableAdapters.PaperInvestmentTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            datePurchaseLabel = new System.Windows.Forms.Label();
            dataSaleLabel = new System.Windows.Forms.Label();
            bankDepositIDLabel = new System.Windows.Forms.Label();
            transactionSumLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datePurchaseLabel
            // 
            datePurchaseLabel.AutoSize = true;
            datePurchaseLabel.Location = new System.Drawing.Point(713, 116);
            datePurchaseLabel.Name = "datePurchaseLabel";
            datePurchaseLabel.Size = new System.Drawing.Size(81, 13);
            datePurchaseLabel.TabIndex = 4;
            datePurchaseLabel.Text = "Date Purchase:";
            // 
            // dataSaleLabel
            // 
            dataSaleLabel.AutoSize = true;
            dataSaleLabel.Location = new System.Drawing.Point(713, 142);
            dataSaleLabel.Name = "dataSaleLabel";
            dataSaleLabel.Size = new System.Drawing.Size(57, 13);
            dataSaleLabel.TabIndex = 6;
            dataSaleLabel.Text = "Data Sale:";
            // 
            // bankDepositIDLabel
            // 
            bankDepositIDLabel.AutoSize = true;
            bankDepositIDLabel.Location = new System.Drawing.Point(713, 172);
            bankDepositIDLabel.Name = "bankDepositIDLabel";
            bankDepositIDLabel.Size = new System.Drawing.Size(53, 13);
            bankDepositIDLabel.TabIndex = 8;
            bankDepositIDLabel.Text = "Invest ID:";
            // 
            // transactionSumLabel
            // 
            transactionSumLabel.AutoSize = true;
            transactionSumLabel.Location = new System.Drawing.Point(712, 89);
            transactionSumLabel.Name = "transactionSumLabel";
            transactionSumLabel.Size = new System.Drawing.Size(90, 13);
            transactionSumLabel.TabIndex = 10;
            transactionSumLabel.Text = "Transaction Sum:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(712, 194);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 12;
            customerIDLabel.Text = "Customer ID:";
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
            this.bankInvestmentDataGridView.Location = new System.Drawing.Point(34, 31);
            this.bankInvestmentDataGridView.Name = "bankInvestmentDataGridView";
            this.bankInvestmentDataGridView.Size = new System.Drawing.Size(644, 210);
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
            // bankInvestmentBindingSource
            // 
            this.bankInvestmentBindingSource.DataMember = "BankInvestment";
            this.bankInvestmentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paperInvestmentDataGridView
            // 
            this.paperInvestmentDataGridView.AutoGenerateColumns = false;
            this.paperInvestmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperInvestmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.paperInvestmentDataGridView.DataSource = this.paperInvestmentBindingSource;
            this.paperInvestmentDataGridView.Location = new System.Drawing.Point(34, 288);
            this.paperInvestmentDataGridView.Name = "paperInvestmentDataGridView";
            this.paperInvestmentDataGridView.Size = new System.Drawing.Size(644, 220);
            this.paperInvestmentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PaperInvestmentID";
            this.dataGridViewTextBoxColumn7.HeaderText = "PaperInvestmentID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataPurchase";
            this.dataGridViewTextBoxColumn8.HeaderText = "DataPurchase";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DataSale";
            this.dataGridViewTextBoxColumn9.HeaderText = "DataSale";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SecuritiesID";
            this.dataGridViewTextBoxColumn10.HeaderText = "SecuritiesID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TransactionSum";
            this.dataGridViewTextBoxColumn11.HeaderText = "TransactionSum";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn12.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // paperInvestmentBindingSource
            // 
            this.paperInvestmentBindingSource.DataMember = "PaperInvestment";
            this.paperInvestmentBindingSource.DataSource = this.dataSet1;
            // 
            // datePurchaseDateTimePicker
            // 
            this.datePurchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bankInvestmentBindingSource, "DatePurchase", true));
            this.datePurchaseDateTimePicker.Location = new System.Drawing.Point(823, 112);
            this.datePurchaseDateTimePicker.Name = "datePurchaseDateTimePicker";
            this.datePurchaseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datePurchaseDateTimePicker.TabIndex = 5;
            // 
            // dataSaleDateTimePicker
            // 
            this.dataSaleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bankInvestmentBindingSource, "DataSale", true));
            this.dataSaleDateTimePicker.Location = new System.Drawing.Point(823, 138);
            this.dataSaleDateTimePicker.Name = "dataSaleDateTimePicker";
            this.dataSaleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataSaleDateTimePicker.TabIndex = 7;
            // 
            // transactionSumTextBox
            // 
            this.transactionSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankInvestmentBindingSource, "TransactionSum", true));
            this.transactionSumTextBox.Location = new System.Drawing.Point(823, 86);
            this.transactionSumTextBox.Name = "transactionSumTextBox";
            this.transactionSumTextBox.Size = new System.Drawing.Size(200, 20);
            this.transactionSumTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(716, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "bank";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(716, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "paper";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.tableAdapterManager.PaperInvestmentTableAdapter = this.paperInvestmentTableAdapter;
            this.tableAdapterManager.PropertyTypeTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SecuritiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paperInvestmentTableAdapter
            // 
            this.paperInvestmentTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(823, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(823, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(262, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // StoredProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 590);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(datePurchaseLabel);
            this.Controls.Add(this.datePurchaseDateTimePicker);
            this.Controls.Add(dataSaleLabel);
            this.Controls.Add(this.dataSaleDateTimePicker);
            this.Controls.Add(bankDepositIDLabel);
            this.Controls.Add(transactionSumLabel);
            this.Controls.Add(this.transactionSumTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.paperInvestmentDataGridView);
            this.Controls.Add(this.bankInvestmentDataGridView);
            this.Name = "StoredProcedure";
            this.Text = "StoredProcedure";
            this.Load += new System.EventHandler(this.StoredProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInvestmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperInvestmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bankInvestmentBindingSource;
        private DataSet1TableAdapters.BankInvestmentTableAdapter bankInvestmentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bankInvestmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataSet1TableAdapters.PaperInvestmentTableAdapter paperInvestmentTableAdapter;
        private System.Windows.Forms.BindingSource paperInvestmentBindingSource;
        private System.Windows.Forms.DataGridView paperInvestmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DateTimePicker datePurchaseDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaleDateTimePicker;
        private System.Windows.Forms.TextBox transactionSumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}