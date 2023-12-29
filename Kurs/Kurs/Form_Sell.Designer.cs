namespace Kurs
{
    partial class Form_Sell
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
            System.Windows.Forms.Label iD_SellLabel;
            System.Windows.Forms.Label price_SellLabel;
            System.Windows.Forms.Label countProduct_SellLabel;
            System.Windows.Forms.Label iD_StoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sell));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellTableAdapter = new Kurs.KursovayaDataSetTableAdapters.SellTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.sellBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sellBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sellDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_SellTextBox = new System.Windows.Forms.TextBox();
            this.price_SellTextBox = new System.Windows.Forms.TextBox();
            this.countProduct_SellTextBox = new System.Windows.Forms.TextBox();
            this.iD_StoreTextBox = new System.Windows.Forms.TextBox();
            iD_SellLabel = new System.Windows.Forms.Label();
            price_SellLabel = new System.Windows.Forms.Label();
            countProduct_SellLabel = new System.Windows.Forms.Label();
            iD_StoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingNavigator)).BeginInit();
            this.sellBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_SellLabel
            // 
            iD_SellLabel.AutoSize = true;
            iD_SellLabel.Location = new System.Drawing.Point(30, 262);
            iD_SellLabel.Name = "iD_SellLabel";
            iD_SellLabel.Size = new System.Drawing.Size(41, 13);
            iD_SellLabel.TabIndex = 33;
            iD_SellLabel.Text = "ID Sell:";
            // 
            // price_SellLabel
            // 
            price_SellLabel.AutoSize = true;
            price_SellLabel.Location = new System.Drawing.Point(30, 288);
            price_SellLabel.Name = "price_SellLabel";
            price_SellLabel.Size = new System.Drawing.Size(54, 13);
            price_SellLabel.TabIndex = 35;
            price_SellLabel.Text = "Price Sell:";
            // 
            // countProduct_SellLabel
            // 
            countProduct_SellLabel.AutoSize = true;
            countProduct_SellLabel.Location = new System.Drawing.Point(30, 314);
            countProduct_SellLabel.Name = "countProduct_SellLabel";
            countProduct_SellLabel.Size = new System.Drawing.Size(98, 13);
            countProduct_SellLabel.TabIndex = 37;
            countProduct_SellLabel.Text = "Count Product Sell:";
            // 
            // iD_StoreLabel
            // 
            iD_StoreLabel.AutoSize = true;
            iD_StoreLabel.Location = new System.Drawing.Point(30, 340);
            iD_StoreLabel.Name = "iD_StoreLabel";
            iD_StoreLabel.Size = new System.Drawing.Size(49, 13);
            iD_StoreLabel.TabIndex = 39;
            iD_StoreLabel.Text = "ID Store:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(411, 335);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(279, 288);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(367, 257);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(279, 257);
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
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "Sell";
            this.sellBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurshareTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurshareTableAdapter = null;
            this.tableAdapterManager.Sell_ManProdTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = this.sellTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sellBindingNavigator
            // 
            this.sellBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sellBindingNavigator.BindingSource = this.sellBindingSource;
            this.sellBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sellBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sellBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sellBindingNavigatorSaveItem});
            this.sellBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sellBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sellBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sellBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sellBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sellBindingNavigator.Name = "sellBindingNavigator";
            this.sellBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sellBindingNavigator.Size = new System.Drawing.Size(508, 25);
            this.sellBindingNavigator.TabIndex = 33;
            this.sellBindingNavigator.Text = "bindingNavigator1";
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
            // sellBindingNavigatorSaveItem
            // 
            this.sellBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sellBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sellBindingNavigatorSaveItem.Image")));
            this.sellBindingNavigatorSaveItem.Name = "sellBindingNavigatorSaveItem";
            this.sellBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sellBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sellBindingNavigatorSaveItem.Click += new System.EventHandler(this.sellBindingNavigatorSaveItem_Click);
            // 
            // sellDataGridView
            // 
            this.sellDataGridView.AutoGenerateColumns = false;
            this.sellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sellDataGridView.DataSource = this.sellBindingSource;
            this.sellDataGridView.Location = new System.Drawing.Point(12, 28);
            this.sellDataGridView.Name = "sellDataGridView";
            this.sellDataGridView.Size = new System.Drawing.Size(471, 220);
            this.sellDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Sell";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Sell";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price_Sell";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price_Sell";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CountProduct_Sell";
            this.dataGridViewTextBoxColumn3.HeaderText = "CountProduct_Sell";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Store";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Store";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iD_SellTextBox
            // 
            this.iD_SellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellBindingSource, "ID_Sell", true));
            this.iD_SellTextBox.Location = new System.Drawing.Point(134, 259);
            this.iD_SellTextBox.Name = "iD_SellTextBox";
            this.iD_SellTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_SellTextBox.TabIndex = 34;
            // 
            // price_SellTextBox
            // 
            this.price_SellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellBindingSource, "Price_Sell", true));
            this.price_SellTextBox.Location = new System.Drawing.Point(134, 285);
            this.price_SellTextBox.Name = "price_SellTextBox";
            this.price_SellTextBox.Size = new System.Drawing.Size(100, 20);
            this.price_SellTextBox.TabIndex = 36;
            // 
            // countProduct_SellTextBox
            // 
            this.countProduct_SellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellBindingSource, "CountProduct_Sell", true));
            this.countProduct_SellTextBox.Location = new System.Drawing.Point(134, 311);
            this.countProduct_SellTextBox.Name = "countProduct_SellTextBox";
            this.countProduct_SellTextBox.Size = new System.Drawing.Size(100, 20);
            this.countProduct_SellTextBox.TabIndex = 38;
            // 
            // iD_StoreTextBox
            // 
            this.iD_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellBindingSource, "ID_Store", true));
            this.iD_StoreTextBox.Location = new System.Drawing.Point(134, 337);
            this.iD_StoreTextBox.Name = "iD_StoreTextBox";
            this.iD_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_StoreTextBox.TabIndex = 40;
            // 
            // Form_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 375);
            this.ControlBox = false;
            this.Controls.Add(iD_SellLabel);
            this.Controls.Add(this.iD_SellTextBox);
            this.Controls.Add(price_SellLabel);
            this.Controls.Add(this.price_SellTextBox);
            this.Controls.Add(countProduct_SellLabel);
            this.Controls.Add(this.countProduct_SellTextBox);
            this.Controls.Add(iD_StoreLabel);
            this.Controls.Add(this.iD_StoreTextBox);
            this.Controls.Add(this.sellDataGridView);
            this.Controls.Add(this.sellBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Form_Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingNavigator)).EndInit();
            this.sellBindingNavigator.ResumeLayout(false);
            this.sellBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private KursovayaDataSetTableAdapters.SellTableAdapter sellTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sellBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sellBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sellDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iD_SellTextBox;
        private System.Windows.Forms.TextBox price_SellTextBox;
        private System.Windows.Forms.TextBox countProduct_SellTextBox;
        private System.Windows.Forms.TextBox iD_StoreTextBox;
    }
}