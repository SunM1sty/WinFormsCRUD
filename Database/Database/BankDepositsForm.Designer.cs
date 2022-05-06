namespace Database
{
    partial class BankDepositsForm
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
            System.Windows.Forms.Label minimumDepositSumLabel;
            System.Windows.Forms.Label percentageIncomePerYearLabel;
            System.Windows.Forms.Label termDepositYearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankDepositsForm));
            this.dataSet1 = new Database.DataSet1();
            this.bankDepositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDepositsTableAdapter = new Database.DataSet1TableAdapters.BankDepositsTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.bankDepositsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bankDepositsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bankDepositsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumDepositSumTextBox = new System.Windows.Forms.TextBox();
            this.percentageIncomePerYearTextBox = new System.Windows.Forms.TextBox();
            this.termDepositYearTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            minimumDepositSumLabel = new System.Windows.Forms.Label();
            percentageIncomePerYearLabel = new System.Windows.Forms.Label();
            termDepositYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsBindingNavigator)).BeginInit();
            this.bankDepositsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minimumDepositSumLabel
            // 
            minimumDepositSumLabel.AutoSize = true;
            minimumDepositSumLabel.Location = new System.Drawing.Point(481, 54);
            minimumDepositSumLabel.Name = "minimumDepositSumLabel";
            minimumDepositSumLabel.Size = new System.Drawing.Size(114, 13);
            minimumDepositSumLabel.TabIndex = 4;
            minimumDepositSumLabel.Text = "Minimum Deposit Sum:";
            // 
            // percentageIncomePerYearLabel
            // 
            percentageIncomePerYearLabel.AutoSize = true;
            percentageIncomePerYearLabel.Location = new System.Drawing.Point(481, 80);
            percentageIncomePerYearLabel.Name = "percentageIncomePerYearLabel";
            percentageIncomePerYearLabel.Size = new System.Drawing.Size(147, 13);
            percentageIncomePerYearLabel.TabIndex = 6;
            percentageIncomePerYearLabel.Text = "Percentage Income Per Year:";
            // 
            // termDepositYearLabel
            // 
            termDepositYearLabel.AutoSize = true;
            termDepositYearLabel.Location = new System.Drawing.Point(481, 106);
            termDepositYearLabel.Name = "termDepositYearLabel";
            termDepositYearLabel.Size = new System.Drawing.Size(98, 13);
            termDepositYearLabel.TabIndex = 8;
            termDepositYearLabel.Text = "Term Deposit Year:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDepositsBindingSource
            // 
            this.bankDepositsBindingSource.DataMember = "BankDeposits";
            this.bankDepositsBindingSource.DataSource = this.dataSet1;
            // 
            // bankDepositsTableAdapter
            // 
            this.bankDepositsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankDepositsTableAdapter = this.bankDepositsTableAdapter;
            this.tableAdapterManager.BankInvestmentTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.PaperInvestmentTableAdapter = null;
            this.tableAdapterManager.PropertyTypeTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SecuritiesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankDepositsBindingNavigator
            // 
            this.bankDepositsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankDepositsBindingNavigator.BindingSource = this.bankDepositsBindingSource;
            this.bankDepositsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankDepositsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankDepositsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bankDepositsBindingNavigatorSaveItem});
            this.bankDepositsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bankDepositsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankDepositsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankDepositsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankDepositsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankDepositsBindingNavigator.Name = "bankDepositsBindingNavigator";
            this.bankDepositsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankDepositsBindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.bankDepositsBindingNavigator.TabIndex = 0;
            this.bankDepositsBindingNavigator.Text = "bindingNavigator1";
            this.bankDepositsBindingNavigator.RefreshItems += new System.EventHandler(this.bankDepositsBindingNavigator_RefreshItems);
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
            // bankDepositsBindingNavigatorSaveItem
            // 
            this.bankDepositsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankDepositsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankDepositsBindingNavigatorSaveItem.Image")));
            this.bankDepositsBindingNavigatorSaveItem.Name = "bankDepositsBindingNavigatorSaveItem";
            this.bankDepositsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bankDepositsBindingNavigatorSaveItem.Text = "Save Data";
            this.bankDepositsBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankDepositsBindingNavigatorSaveItem_Click);
            // 
            // bankDepositsDataGridView
            // 
            this.bankDepositsDataGridView.AutoGenerateColumns = false;
            this.bankDepositsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankDepositsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bankDepositsDataGridView.DataSource = this.bankDepositsBindingSource;
            this.bankDepositsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.bankDepositsDataGridView.Name = "bankDepositsDataGridView";
            this.bankDepositsDataGridView.Size = new System.Drawing.Size(451, 400);
            this.bankDepositsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BankDepositID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BankDepositID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MinimumDepositSum";
            this.dataGridViewTextBoxColumn2.HeaderText = "MinimumDepositSum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PercentageIncomePerYear";
            this.dataGridViewTextBoxColumn3.HeaderText = "PercentageIncomePerYear";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TermDepositYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "TermDepositYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // minimumDepositSumTextBox
            // 
            this.minimumDepositSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankDepositsBindingSource, "MinimumDepositSum", true));
            this.minimumDepositSumTextBox.Location = new System.Drawing.Point(634, 51);
            this.minimumDepositSumTextBox.Name = "minimumDepositSumTextBox";
            this.minimumDepositSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.minimumDepositSumTextBox.TabIndex = 5;
            // 
            // percentageIncomePerYearTextBox
            // 
            this.percentageIncomePerYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankDepositsBindingSource, "PercentageIncomePerYear", true));
            this.percentageIncomePerYearTextBox.Location = new System.Drawing.Point(634, 77);
            this.percentageIncomePerYearTextBox.Name = "percentageIncomePerYearTextBox";
            this.percentageIncomePerYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.percentageIncomePerYearTextBox.TabIndex = 7;
            // 
            // termDepositYearTextBox
            // 
            this.termDepositYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankDepositsBindingSource, "TermDepositYear", true));
            this.termDepositYearTextBox.Location = new System.Drawing.Point(634, 103);
            this.termDepositYearTextBox.Name = "termDepositYearTextBox";
            this.termDepositYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.termDepositYearTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BankDepositsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(minimumDepositSumLabel);
            this.Controls.Add(this.minimumDepositSumTextBox);
            this.Controls.Add(percentageIncomePerYearLabel);
            this.Controls.Add(this.percentageIncomePerYearTextBox);
            this.Controls.Add(termDepositYearLabel);
            this.Controls.Add(this.termDepositYearTextBox);
            this.Controls.Add(this.bankDepositsDataGridView);
            this.Controls.Add(this.bankDepositsBindingNavigator);
            this.Name = "BankDepositsForm";
            this.Text = "BankDepositsForm";
            this.Load += new System.EventHandler(this.BankDepositsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsBindingNavigator)).EndInit();
            this.bankDepositsBindingNavigator.ResumeLayout(false);
            this.bankDepositsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDepositsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bankDepositsBindingSource;
        private DataSet1TableAdapters.BankDepositsTableAdapter bankDepositsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankDepositsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bankDepositsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bankDepositsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox minimumDepositSumTextBox;
        private System.Windows.Forms.TextBox percentageIncomePerYearTextBox;
        private System.Windows.Forms.TextBox termDepositYearTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}