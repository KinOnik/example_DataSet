namespace Kurs
{
    partial class Form_Manuf_Product
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
            System.Windows.Forms.Label man_Prod_IDLabel;
            System.Windows.Forms.Label iD_ProductLabel;
            System.Windows.Forms.Label iD_ManufacturerLabel;
            System.Windows.Forms.Label isDeletedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manuf_Product));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.manufacturer_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturer_ProductTableAdapter = new Kurs.KursovayaDataSetTableAdapters.Manufacturer_ProductTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.manufacturer_ProductBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.manufacturer_ProductBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturer_ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.man_Prod_IDTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProductTextBox = new System.Windows.Forms.TextBox();
            this.iD_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            man_Prod_IDLabel = new System.Windows.Forms.Label();
            iD_ProductLabel = new System.Windows.Forms.Label();
            iD_ManufacturerLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductBindingNavigator)).BeginInit();
            this.manufacturer_ProductBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // man_Prod_IDLabel
            // 
            man_Prod_IDLabel.AutoSize = true;
            man_Prod_IDLabel.Location = new System.Drawing.Point(22, 266);
            man_Prod_IDLabel.Name = "man_Prod_IDLabel";
            man_Prod_IDLabel.Size = new System.Drawing.Size(70, 13);
            man_Prod_IDLabel.TabIndex = 33;
            man_Prod_IDLabel.Text = "Man Prod ID:";
            // 
            // iD_ProductLabel
            // 
            iD_ProductLabel.AutoSize = true;
            iD_ProductLabel.Location = new System.Drawing.Point(22, 292);
            iD_ProductLabel.Name = "iD_ProductLabel";
            iD_ProductLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProductLabel.TabIndex = 35;
            iD_ProductLabel.Text = "ID Product:";
            // 
            // iD_ManufacturerLabel
            // 
            iD_ManufacturerLabel.AutoSize = true;
            iD_ManufacturerLabel.Location = new System.Drawing.Point(22, 318);
            iD_ManufacturerLabel.Name = "iD_ManufacturerLabel";
            iD_ManufacturerLabel.Size = new System.Drawing.Size(87, 13);
            iD_ManufacturerLabel.TabIndex = 37;
            iD_ManufacturerLabel.Text = "ID Manufacturer:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(22, 346);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(58, 13);
            isDeletedLabel.TabIndex = 39;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(424, 351);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(249, 292);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(337, 261);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(249, 261);
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
            // manufacturer_ProductBindingSource
            // 
            this.manufacturer_ProductBindingSource.DataMember = "Manufacturer_Product";
            this.manufacturer_ProductBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // manufacturer_ProductTableAdapter
            // 
            this.manufacturer_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = this.manufacturer_ProductTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurshareTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurshareTableAdapter = null;
            this.tableAdapterManager.Sell_ManProdTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manufacturer_ProductBindingNavigator
            // 
            this.manufacturer_ProductBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturer_ProductBindingNavigator.BindingSource = this.manufacturer_ProductBindingSource;
            this.manufacturer_ProductBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturer_ProductBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturer_ProductBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.manufacturer_ProductBindingNavigatorSaveItem});
            this.manufacturer_ProductBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturer_ProductBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturer_ProductBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturer_ProductBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturer_ProductBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturer_ProductBindingNavigator.Name = "manufacturer_ProductBindingNavigator";
            this.manufacturer_ProductBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturer_ProductBindingNavigator.Size = new System.Drawing.Size(518, 25);
            this.manufacturer_ProductBindingNavigator.TabIndex = 33;
            this.manufacturer_ProductBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // manufacturer_ProductBindingNavigatorSaveItem
            // 
            this.manufacturer_ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturer_ProductBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturer_ProductBindingNavigatorSaveItem.Image")));
            this.manufacturer_ProductBindingNavigatorSaveItem.Name = "manufacturer_ProductBindingNavigatorSaveItem";
            this.manufacturer_ProductBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manufacturer_ProductBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.manufacturer_ProductBindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturer_ProductBindingNavigatorSaveItem_Click);
            // 
            // manufacturer_ProductDataGridView
            // 
            this.manufacturer_ProductDataGridView.AutoGenerateColumns = false;
            this.manufacturer_ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturer_ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.manufacturer_ProductDataGridView.DataSource = this.manufacturer_ProductBindingSource;
            this.manufacturer_ProductDataGridView.Location = new System.Drawing.Point(15, 30);
            this.manufacturer_ProductDataGridView.Name = "manufacturer_ProductDataGridView";
            this.manufacturer_ProductDataGridView.Size = new System.Drawing.Size(491, 220);
            this.manufacturer_ProductDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Manufacturer";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Manufacturer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // man_Prod_IDTextBox
            // 
            this.man_Prod_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_ProductBindingSource, "Man_Prod_ID", true));
            this.man_Prod_IDTextBox.Location = new System.Drawing.Point(115, 263);
            this.man_Prod_IDTextBox.Name = "man_Prod_IDTextBox";
            this.man_Prod_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.man_Prod_IDTextBox.TabIndex = 34;
            // 
            // iD_ProductTextBox
            // 
            this.iD_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_ProductBindingSource, "ID_Product", true));
            this.iD_ProductTextBox.Location = new System.Drawing.Point(115, 289);
            this.iD_ProductTextBox.Name = "iD_ProductTextBox";
            this.iD_ProductTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_ProductTextBox.TabIndex = 36;
            // 
            // iD_ManufacturerTextBox
            // 
            this.iD_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_ProductBindingSource, "ID_Manufacturer", true));
            this.iD_ManufacturerTextBox.Location = new System.Drawing.Point(115, 315);
            this.iD_ManufacturerTextBox.Name = "iD_ManufacturerTextBox";
            this.iD_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_ManufacturerTextBox.TabIndex = 38;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.manufacturer_ProductBindingSource, "IsDeleted", true));
            this.isDeletedCheckBox.Location = new System.Drawing.Point(115, 341);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDeletedCheckBox.TabIndex = 40;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form_Manuf_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 386);
            this.ControlBox = false;
            this.Controls.Add(man_Prod_IDLabel);
            this.Controls.Add(this.man_Prod_IDTextBox);
            this.Controls.Add(iD_ProductLabel);
            this.Controls.Add(this.iD_ProductTextBox);
            this.Controls.Add(iD_ManufacturerLabel);
            this.Controls.Add(this.iD_ManufacturerTextBox);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Controls.Add(this.manufacturer_ProductDataGridView);
            this.Controls.Add(this.manufacturer_ProductBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Manuf_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturer_Product";
            this.Load += new System.EventHandler(this.Form_Manuf_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductBindingNavigator)).EndInit();
            this.manufacturer_ProductBindingNavigator.ResumeLayout(false);
            this.manufacturer_ProductBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource manufacturer_ProductBindingSource;
        private KursovayaDataSetTableAdapters.Manufacturer_ProductTableAdapter manufacturer_ProductTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturer_ProductBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton manufacturer_ProductBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manufacturer_ProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox man_Prod_IDTextBox;
        private System.Windows.Forms.TextBox iD_ProductTextBox;
        private System.Windows.Forms.TextBox iD_ManufacturerTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
    }
}