namespace Kurs
{
    partial class Form_Purshare
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
            System.Windows.Forms.Label iD_PurshareLabel;
            System.Windows.Forms.Label numberOrder_PurshareLabel;
            System.Windows.Forms.Label methodDeliverily_PurshareLabel;
            System.Windows.Forms.Label companyDeliverily_PurshareLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Purshare));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.purshareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purshareTableAdapter = new Kurs.KursovayaDataSetTableAdapters.PurshareTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.purshareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purshareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purshareDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_PurshareTextBox = new System.Windows.Forms.TextBox();
            this.numberOrder_PurshareTextBox = new System.Windows.Forms.TextBox();
            this.methodDeliverily_PurshareTextBox = new System.Windows.Forms.TextBox();
            this.companyDeliverily_PurshareTextBox = new System.Windows.Forms.TextBox();
            iD_PurshareLabel = new System.Windows.Forms.Label();
            numberOrder_PurshareLabel = new System.Windows.Forms.Label();
            methodDeliverily_PurshareLabel = new System.Windows.Forms.Label();
            companyDeliverily_PurshareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshareBindingNavigator)).BeginInit();
            this.purshareBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purshareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PurshareLabel
            // 
            iD_PurshareLabel.AutoSize = true;
            iD_PurshareLabel.Location = new System.Drawing.Point(25, 266);
            iD_PurshareLabel.Name = "iD_PurshareLabel";
            iD_PurshareLabel.Size = new System.Drawing.Size(66, 13);
            iD_PurshareLabel.TabIndex = 33;
            iD_PurshareLabel.Text = "ID Purshare:";
            // 
            // numberOrder_PurshareLabel
            // 
            numberOrder_PurshareLabel.AutoSize = true;
            numberOrder_PurshareLabel.Location = new System.Drawing.Point(25, 292);
            numberOrder_PurshareLabel.Name = "numberOrder_PurshareLabel";
            numberOrder_PurshareLabel.Size = new System.Drawing.Size(121, 13);
            numberOrder_PurshareLabel.TabIndex = 35;
            numberOrder_PurshareLabel.Text = "Number Order Purshare:";
            // 
            // methodDeliverily_PurshareLabel
            // 
            methodDeliverily_PurshareLabel.AutoSize = true;
            methodDeliverily_PurshareLabel.Location = new System.Drawing.Point(25, 318);
            methodDeliverily_PurshareLabel.Name = "methodDeliverily_PurshareLabel";
            methodDeliverily_PurshareLabel.Size = new System.Drawing.Size(136, 13);
            methodDeliverily_PurshareLabel.TabIndex = 37;
            methodDeliverily_PurshareLabel.Text = "Method Deliverily Purshare:";
            // 
            // companyDeliverily_PurshareLabel
            // 
            companyDeliverily_PurshareLabel.AutoSize = true;
            companyDeliverily_PurshareLabel.Location = new System.Drawing.Point(25, 344);
            companyDeliverily_PurshareLabel.Name = "companyDeliverily_PurshareLabel";
            companyDeliverily_PurshareLabel.Size = new System.Drawing.Size(144, 13);
            companyDeliverily_PurshareLabel.TabIndex = 39;
            companyDeliverily_PurshareLabel.Text = "Company Deliverily Purshare:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(416, 344);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(303, 293);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(391, 261);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(303, 261);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(82, 23);
            this.Button_ADD.TabIndex = 32;
            this.Button_ADD.Text = "ДОБАВИТЬ";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // kursovayaDataSet
            // 
            this.kursovayaDataSet.DataSetName = "KursovayaDataSet";
            this.kursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purshareBindingSource
            // 
            this.purshareBindingSource.DataMember = "Purshare";
            this.purshareBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // purshareTableAdapter
            // 
            this.purshareTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurshareTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurshareTableAdapter = this.purshareTableAdapter;
            this.tableAdapterManager.Sell_ManProdTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purshareBindingNavigator
            // 
            this.purshareBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purshareBindingNavigator.BindingSource = this.purshareBindingSource;
            this.purshareBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purshareBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purshareBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purshareBindingNavigatorSaveItem});
            this.purshareBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purshareBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purshareBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purshareBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purshareBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purshareBindingNavigator.Name = "purshareBindingNavigator";
            this.purshareBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purshareBindingNavigator.Size = new System.Drawing.Size(506, 25);
            this.purshareBindingNavigator.TabIndex = 33;
            this.purshareBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // purshareBindingNavigatorSaveItem
            // 
            this.purshareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purshareBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purshareBindingNavigatorSaveItem.Image")));
            this.purshareBindingNavigatorSaveItem.Name = "purshareBindingNavigatorSaveItem";
            this.purshareBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purshareBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purshareBindingNavigatorSaveItem.Click += new System.EventHandler(this.purshareBindingNavigatorSaveItem_Click);
            // 
            // purshareDataGridView
            // 
            this.purshareDataGridView.AutoGenerateColumns = false;
            this.purshareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purshareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.purshareDataGridView.DataSource = this.purshareBindingSource;
            this.purshareDataGridView.Location = new System.Drawing.Point(12, 28);
            this.purshareDataGridView.Name = "purshareDataGridView";
            this.purshareDataGridView.Size = new System.Drawing.Size(477, 220);
            this.purshareDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Purshare";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Purshare";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumberOrder_Purshare";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumberOrder_Purshare";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MethodDeliverily_Purshare";
            this.dataGridViewTextBoxColumn3.HeaderText = "MethodDeliverily_Purshare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CompanyDeliverily_Purshare";
            this.dataGridViewTextBoxColumn4.HeaderText = "CompanyDeliverily_Purshare";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iD_PurshareTextBox
            // 
            this.iD_PurshareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purshareBindingSource, "ID_Purshare", true));
            this.iD_PurshareTextBox.Location = new System.Drawing.Point(175, 263);
            this.iD_PurshareTextBox.Name = "iD_PurshareTextBox";
            this.iD_PurshareTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PurshareTextBox.TabIndex = 34;
            // 
            // numberOrder_PurshareTextBox
            // 
            this.numberOrder_PurshareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purshareBindingSource, "NumberOrder_Purshare", true));
            this.numberOrder_PurshareTextBox.Location = new System.Drawing.Point(175, 289);
            this.numberOrder_PurshareTextBox.Name = "numberOrder_PurshareTextBox";
            this.numberOrder_PurshareTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOrder_PurshareTextBox.TabIndex = 36;
            // 
            // methodDeliverily_PurshareTextBox
            // 
            this.methodDeliverily_PurshareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purshareBindingSource, "MethodDeliverily_Purshare", true));
            this.methodDeliverily_PurshareTextBox.Location = new System.Drawing.Point(175, 315);
            this.methodDeliverily_PurshareTextBox.Name = "methodDeliverily_PurshareTextBox";
            this.methodDeliverily_PurshareTextBox.Size = new System.Drawing.Size(100, 20);
            this.methodDeliverily_PurshareTextBox.TabIndex = 38;
            // 
            // companyDeliverily_PurshareTextBox
            // 
            this.companyDeliverily_PurshareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purshareBindingSource, "CompanyDeliverily_Purshare", true));
            this.companyDeliverily_PurshareTextBox.Location = new System.Drawing.Point(175, 341);
            this.companyDeliverily_PurshareTextBox.Name = "companyDeliverily_PurshareTextBox";
            this.companyDeliverily_PurshareTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyDeliverily_PurshareTextBox.TabIndex = 40;
            // 
            // Form_Purshare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 381);
            this.ControlBox = false;
            this.Controls.Add(iD_PurshareLabel);
            this.Controls.Add(this.iD_PurshareTextBox);
            this.Controls.Add(numberOrder_PurshareLabel);
            this.Controls.Add(this.numberOrder_PurshareTextBox);
            this.Controls.Add(methodDeliverily_PurshareLabel);
            this.Controls.Add(this.methodDeliverily_PurshareTextBox);
            this.Controls.Add(companyDeliverily_PurshareLabel);
            this.Controls.Add(this.companyDeliverily_PurshareTextBox);
            this.Controls.Add(this.purshareDataGridView);
            this.Controls.Add(this.purshareBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Purshare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purshare";
            this.Load += new System.EventHandler(this.Form_Purshare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshareBindingNavigator)).EndInit();
            this.purshareBindingNavigator.ResumeLayout(false);
            this.purshareBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purshareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource purshareBindingSource;
        private KursovayaDataSetTableAdapters.PurshareTableAdapter purshareTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purshareBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purshareBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView purshareDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iD_PurshareTextBox;
        private System.Windows.Forms.TextBox numberOrder_PurshareTextBox;
        private System.Windows.Forms.TextBox methodDeliverily_PurshareTextBox;
        private System.Windows.Forms.TextBox companyDeliverily_PurshareTextBox;
    }
}