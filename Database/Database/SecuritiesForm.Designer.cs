﻿namespace Database
{
    partial class SecuritiesForm
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
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label yieldForLastYearLabel;
            System.Windows.Forms.Label additionalInformationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecuritiesForm));
            this.dataSet1 = new Database.DataSet1();
            this.securitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securitiesTableAdapter = new Database.DataSet1TableAdapters.SecuritiesTableAdapter();
            this.tableAdapterManager = new Database.DataSet1TableAdapters.TableAdapterManager();
            this.securitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.securitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.securitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumDepositSumTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.yieldForLastYearTextBox = new System.Windows.Forms.TextBox();
            this.additionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            minimumDepositSumLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            yieldForLastYearLabel = new System.Windows.Forms.Label();
            additionalInformationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesBindingNavigator)).BeginInit();
            this.securitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minimumDepositSumLabel
            // 
            minimumDepositSumLabel.AutoSize = true;
            minimumDepositSumLabel.Location = new System.Drawing.Point(581, 54);
            minimumDepositSumLabel.Name = "minimumDepositSumLabel";
            minimumDepositSumLabel.Size = new System.Drawing.Size(114, 13);
            minimumDepositSumLabel.TabIndex = 4;
            minimumDepositSumLabel.Text = "Minimum Deposit Sum:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(581, 80);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 6;
            ratingLabel.Text = "Rating:";
            // 
            // yieldForLastYearLabel
            // 
            yieldForLastYearLabel.AutoSize = true;
            yieldForLastYearLabel.Location = new System.Drawing.Point(581, 106);
            yieldForLastYearLabel.Name = "yieldForLastYearLabel";
            yieldForLastYearLabel.Size = new System.Drawing.Size(99, 13);
            yieldForLastYearLabel.TabIndex = 8;
            yieldForLastYearLabel.Text = "Yield For Last Year:";
            // 
            // additionalInformationLabel
            // 
            additionalInformationLabel.AutoSize = true;
            additionalInformationLabel.Location = new System.Drawing.Point(581, 132);
            additionalInformationLabel.Name = "additionalInformationLabel";
            additionalInformationLabel.Size = new System.Drawing.Size(111, 13);
            additionalInformationLabel.TabIndex = 10;
            additionalInformationLabel.Text = "Additional Information:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securitiesBindingSource
            // 
            this.securitiesBindingSource.DataMember = "Securities";
            this.securitiesBindingSource.DataSource = this.dataSet1;
            // 
            // securitiesTableAdapter
            // 
            this.securitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankDepositsTableAdapter = null;
            this.tableAdapterManager.BankInvestmentTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.PaperInvestmentTableAdapter = null;
            this.tableAdapterManager.PropertyTypeTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SecuritiesTableAdapter = this.securitiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Database.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // securitiesBindingNavigator
            // 
            this.securitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.securitiesBindingNavigator.BindingSource = this.securitiesBindingSource;
            this.securitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.securitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.securitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.securitiesBindingNavigatorSaveItem});
            this.securitiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.securitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.securitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.securitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.securitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.securitiesBindingNavigator.Name = "securitiesBindingNavigator";
            this.securitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.securitiesBindingNavigator.Size = new System.Drawing.Size(971, 25);
            this.securitiesBindingNavigator.TabIndex = 0;
            this.securitiesBindingNavigator.Text = "bindingNavigator1";
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
            // securitiesBindingNavigatorSaveItem
            // 
            this.securitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.securitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("securitiesBindingNavigatorSaveItem.Image")));
            this.securitiesBindingNavigatorSaveItem.Name = "securitiesBindingNavigatorSaveItem";
            this.securitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.securitiesBindingNavigatorSaveItem.Text = "Save Data";
            this.securitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.securitiesBindingNavigatorSaveItem_Click);
            // 
            // securitiesDataGridView
            // 
            this.securitiesDataGridView.AutoGenerateColumns = false;
            this.securitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.securitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.securitiesDataGridView.DataSource = this.securitiesBindingSource;
            this.securitiesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.securitiesDataGridView.Name = "securitiesDataGridView";
            this.securitiesDataGridView.Size = new System.Drawing.Size(544, 410);
            this.securitiesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SecuritiesID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SecuritiesID";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "YieldForLastYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "YieldForLastYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AdditionalInformation";
            this.dataGridViewTextBoxColumn5.HeaderText = "AdditionalInformation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // minimumDepositSumTextBox
            // 
            this.minimumDepositSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.securitiesBindingSource, "MinimumDepositSum", true));
            this.minimumDepositSumTextBox.Location = new System.Drawing.Point(701, 51);
            this.minimumDepositSumTextBox.Name = "minimumDepositSumTextBox";
            this.minimumDepositSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.minimumDepositSumTextBox.TabIndex = 5;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.securitiesBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(701, 77);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 7;
            // 
            // yieldForLastYearTextBox
            // 
            this.yieldForLastYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.securitiesBindingSource, "YieldForLastYear", true));
            this.yieldForLastYearTextBox.Location = new System.Drawing.Point(701, 103);
            this.yieldForLastYearTextBox.Name = "yieldForLastYearTextBox";
            this.yieldForLastYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yieldForLastYearTextBox.TabIndex = 9;
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.securitiesBindingSource, "AdditionalInformation", true));
            this.additionalInformationTextBox.Location = new System.Drawing.Point(701, 129);
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(100, 20);
            this.additionalInformationTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(837, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecuritiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(minimumDepositSumLabel);
            this.Controls.Add(this.minimumDepositSumTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(yieldForLastYearLabel);
            this.Controls.Add(this.yieldForLastYearTextBox);
            this.Controls.Add(additionalInformationLabel);
            this.Controls.Add(this.additionalInformationTextBox);
            this.Controls.Add(this.securitiesDataGridView);
            this.Controls.Add(this.securitiesBindingNavigator);
            this.Name = "SecuritiesForm";
            this.Text = "SecuritiesForm";
            this.Load += new System.EventHandler(this.SecuritiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesBindingNavigator)).EndInit();
            this.securitiesBindingNavigator.ResumeLayout(false);
            this.securitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource securitiesBindingSource;
        private DataSet1TableAdapters.SecuritiesTableAdapter securitiesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator securitiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton securitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView securitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox minimumDepositSumTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox yieldForLastYearTextBox;
        private System.Windows.Forms.TextBox additionalInformationTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}