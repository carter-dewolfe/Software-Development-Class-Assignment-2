namespace Assignment02_Project04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.originalPopulationTextBox = new System.Windows.Forms.TextBox();
            this.originalCityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sortNameButton = new System.Windows.Forms.Button();
            this.sortPopAscButton = new System.Windows.Forms.Button();
            this.sortPopDescButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.averagePopButton = new System.Windows.Forms.Button();
            this.minPopButton = new System.Windows.Forms.Button();
            this.totalPopButton = new System.Windows.Forms.Button();
            this.maxPopButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDataSet = new Assignment02_Project04.PopulationDataSet();
            this.cityTableAdapter = new Assignment02_Project04.PopulationDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new Assignment02_Project04.PopulationDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(721, 25);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
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
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.CityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(12, 28);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.Size = new System.Drawing.Size(438, 276);
            this.cityDataGridView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.originalPopulationTextBox);
            this.groupBox2.Controls.Add(this.originalCityTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.populationTextBox);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.insertButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 159);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipulate Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Originals only needed if updating";
            // 
            // originalPopulationTextBox
            // 
            this.originalPopulationTextBox.Location = new System.Drawing.Point(330, 54);
            this.originalPopulationTextBox.Name = "originalPopulationTextBox";
            this.originalPopulationTextBox.Size = new System.Drawing.Size(85, 20);
            this.originalPopulationTextBox.TabIndex = 17;
            // 
            // originalCityTextBox
            // 
            this.originalCityTextBox.Location = new System.Drawing.Point(330, 30);
            this.originalCityTextBox.Name = "originalCityTextBox";
            this.originalCityTextBox.Size = new System.Drawing.Size(85, 20);
            this.originalCityTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Original Population:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Original City:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(278, 83);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 56);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(94, 51);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(95, 20);
            this.populationTextBox.TabIndex = 13;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(94, 27);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(95, 20);
            this.cityTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Population:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "City:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(123, 83);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 56);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(7, 83);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(98, 56);
            this.insertButton.TabIndex = 9;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sortNameButton);
            this.groupBox3.Controls.Add(this.sortPopAscButton);
            this.groupBox3.Controls.Add(this.sortPopDescButton);
            this.groupBox3.Location = new System.Drawing.Point(456, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 231);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort Information";
            // 
            // sortNameButton
            // 
            this.sortNameButton.Location = new System.Drawing.Point(81, 157);
            this.sortNameButton.Name = "sortNameButton";
            this.sortNameButton.Size = new System.Drawing.Size(109, 56);
            this.sortNameButton.TabIndex = 12;
            this.sortNameButton.Text = "Sort By City Name";
            this.sortNameButton.UseVisualStyleBackColor = true;
            this.sortNameButton.Click += new System.EventHandler(this.SortNameButton_Click);
            // 
            // sortPopAscButton
            // 
            this.sortPopAscButton.Location = new System.Drawing.Point(81, 95);
            this.sortPopAscButton.Name = "sortPopAscButton";
            this.sortPopAscButton.Size = new System.Drawing.Size(109, 56);
            this.sortPopAscButton.TabIndex = 11;
            this.sortPopAscButton.Text = "Sort By Population (Ascending Order)";
            this.sortPopAscButton.UseVisualStyleBackColor = true;
            this.sortPopAscButton.Click += new System.EventHandler(this.SortPopAscButton_Click);
            // 
            // sortPopDescButton
            // 
            this.sortPopDescButton.Location = new System.Drawing.Point(81, 33);
            this.sortPopDescButton.Name = "sortPopDescButton";
            this.sortPopDescButton.Size = new System.Drawing.Size(109, 56);
            this.sortPopDescButton.TabIndex = 10;
            this.sortPopDescButton.Text = "Sort By Population (Descending Order)";
            this.sortPopDescButton.UseVisualStyleBackColor = true;
            this.sortPopDescButton.Click += new System.EventHandler(this.SortPopDescButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.averagePopButton);
            this.groupBox1.Controls.Add(this.minPopButton);
            this.groupBox1.Controls.Add(this.totalPopButton);
            this.groupBox1.Controls.Add(this.maxPopButton);
            this.groupBox1.Location = new System.Drawing.Point(456, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 190);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Information";
            // 
            // averagePopButton
            // 
            this.averagePopButton.Location = new System.Drawing.Point(146, 42);
            this.averagePopButton.Name = "averagePopButton";
            this.averagePopButton.Size = new System.Drawing.Size(98, 56);
            this.averagePopButton.TabIndex = 11;
            this.averagePopButton.Text = "Average Population";
            this.averagePopButton.UseVisualStyleBackColor = true;
            this.averagePopButton.Click += new System.EventHandler(this.AveragePopButton_Click);
            // 
            // minPopButton
            // 
            this.minPopButton.Location = new System.Drawing.Point(146, 128);
            this.minPopButton.Name = "minPopButton";
            this.minPopButton.Size = new System.Drawing.Size(98, 56);
            this.minPopButton.TabIndex = 13;
            this.minPopButton.Text = "Min Population";
            this.minPopButton.UseVisualStyleBackColor = true;
            this.minPopButton.Click += new System.EventHandler(this.MinPopButton_Click);
            // 
            // totalPopButton
            // 
            this.totalPopButton.Location = new System.Drawing.Point(8, 42);
            this.totalPopButton.Name = "totalPopButton";
            this.totalPopButton.Size = new System.Drawing.Size(98, 56);
            this.totalPopButton.TabIndex = 10;
            this.totalPopButton.Text = "Total Population";
            this.totalPopButton.UseVisualStyleBackColor = true;
            this.totalPopButton.Click += new System.EventHandler(this.TotalPopButton_Click);
            // 
            // maxPopButton
            // 
            this.maxPopButton.Location = new System.Drawing.Point(8, 128);
            this.maxPopButton.Name = "maxPopButton";
            this.maxPopButton.Size = new System.Drawing.Size(98, 56);
            this.maxPopButton.TabIndex = 12;
            this.maxPopButton.Text = "Max Population";
            this.maxPopButton.UseVisualStyleBackColor = true;
            this.maxPopButton.Click += new System.EventHandler(this.MaxPopButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn1.HeaderText = "City";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.populationDataSet;
            // 
            // populationDataSet
            // 
            this.populationDataSet.DataSetName = "PopulationDataSet";
            this.populationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment02_Project04.PopulationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 480);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PopulationDataSet populationDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PopulationDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private PopulationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sortNameButton;
        private System.Windows.Forms.Button sortPopAscButton;
        private System.Windows.Forms.Button sortPopDescButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button averagePopButton;
        private System.Windows.Forms.Button minPopButton;
        private System.Windows.Forms.Button totalPopButton;
        private System.Windows.Forms.Button maxPopButton;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox originalPopulationTextBox;
        private System.Windows.Forms.TextBox originalCityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

