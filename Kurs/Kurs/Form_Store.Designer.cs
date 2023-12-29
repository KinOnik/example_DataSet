namespace Kurs
{
    partial class Form_Store
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
            System.Windows.Forms.Label iD_StoreLabel;
            System.Windows.Forms.Label name_StoreLabel;
            System.Windows.Forms.Label region_StoreLabel;
            System.Windows.Forms.Label locality_StoreLabel;
            System.Windows.Forms.Label street_StoreLabel;
            System.Windows.Forms.Label house_StoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Store));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Kurs.KursovayaDataSetTableAdapters.StoreTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.storeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.storeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_StoreTextBox = new System.Windows.Forms.TextBox();
            this.name_StoreTextBox = new System.Windows.Forms.TextBox();
            this.region_StoreTextBox = new System.Windows.Forms.TextBox();
            this.locality_StoreTextBox = new System.Windows.Forms.TextBox();
            this.street_StoreTextBox = new System.Windows.Forms.TextBox();
            this.house_StoreTextBox = new System.Windows.Forms.TextBox();
            iD_StoreLabel = new System.Windows.Forms.Label();
            name_StoreLabel = new System.Windows.Forms.Label();
            region_StoreLabel = new System.Windows.Forms.Label();
            locality_StoreLabel = new System.Windows.Forms.Label();
            street_StoreLabel = new System.Windows.Forms.Label();
            house_StoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).BeginInit();
            this.storeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_StoreLabel
            // 
            iD_StoreLabel.AutoSize = true;
            iD_StoreLabel.Location = new System.Drawing.Point(25, 272);
            iD_StoreLabel.Name = "iD_StoreLabel";
            iD_StoreLabel.Size = new System.Drawing.Size(49, 13);
            iD_StoreLabel.TabIndex = 29;
            iD_StoreLabel.Text = "ID Store:";
            // 
            // name_StoreLabel
            // 
            name_StoreLabel.AutoSize = true;
            name_StoreLabel.Location = new System.Drawing.Point(25, 298);
            name_StoreLabel.Name = "name_StoreLabel";
            name_StoreLabel.Size = new System.Drawing.Size(66, 13);
            name_StoreLabel.TabIndex = 31;
            name_StoreLabel.Text = "Name Store:";
            // 
            // region_StoreLabel
            // 
            region_StoreLabel.AutoSize = true;
            region_StoreLabel.Location = new System.Drawing.Point(25, 324);
            region_StoreLabel.Name = "region_StoreLabel";
            region_StoreLabel.Size = new System.Drawing.Size(72, 13);
            region_StoreLabel.TabIndex = 33;
            region_StoreLabel.Text = "Region Store:";
            // 
            // locality_StoreLabel
            // 
            locality_StoreLabel.AutoSize = true;
            locality_StoreLabel.Location = new System.Drawing.Point(25, 350);
            locality_StoreLabel.Name = "locality_StoreLabel";
            locality_StoreLabel.Size = new System.Drawing.Size(74, 13);
            locality_StoreLabel.TabIndex = 35;
            locality_StoreLabel.Text = "Locality Store:";
            // 
            // street_StoreLabel
            // 
            street_StoreLabel.AutoSize = true;
            street_StoreLabel.Location = new System.Drawing.Point(25, 376);
            street_StoreLabel.Name = "street_StoreLabel";
            street_StoreLabel.Size = new System.Drawing.Size(66, 13);
            street_StoreLabel.TabIndex = 37;
            street_StoreLabel.Text = "Street Store:";
            // 
            // house_StoreLabel
            // 
            house_StoreLabel.AutoSize = true;
            house_StoreLabel.Location = new System.Drawing.Point(25, 402);
            house_StoreLabel.Name = "house_StoreLabel";
            house_StoreLabel.Size = new System.Drawing.Size(69, 13);
            house_StoreLabel.TabIndex = 39;
            house_StoreLabel.Text = "House Store:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(611, 421);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 25;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(251, 305);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 26;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(376, 269);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 27;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(251, 269);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(82, 23);
            this.Button_ADD.TabIndex = 28;
            this.Button_ADD.Text = "ДОБАВИТЬ";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // kursovayaDataSet
            // 
            this.kursovayaDataSet.DataSetName = "KursovayaDataSet";
            this.kursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storeBindingNavigator
            // 
            this.storeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storeBindingNavigator.BindingSource = this.storeBindingSource;
            this.storeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.storeBindingNavigatorSaveItem});
            this.storeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storeBindingNavigator.Name = "storeBindingNavigator";
            this.storeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storeBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.storeBindingNavigator.TabIndex = 29;
            this.storeBindingNavigator.Text = "bindingNavigator1";
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
            // storeBindingNavigatorSaveItem
            // 
            this.storeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storeBindingNavigatorSaveItem.Image")));
            this.storeBindingNavigatorSaveItem.Name = "storeBindingNavigatorSaveItem";
            this.storeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.storeBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeBindingNavigatorSaveItem_Click);
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AutoGenerateColumns = false;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.storeDataGridView.DataSource = this.storeBindingSource;
            this.storeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.Size = new System.Drawing.Size(704, 220);
            this.storeDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Store";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Store";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Store";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Store";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Region_Store";
            this.dataGridViewTextBoxColumn3.HeaderText = "Region_Store";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Locality_Store";
            this.dataGridViewTextBoxColumn4.HeaderText = "Locality_Store";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street_Store";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street_Store";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "House_Store";
            this.dataGridViewTextBoxColumn6.HeaderText = "House_Store";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iD_StoreTextBox
            // 
            this.iD_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "ID_Store", true));
            this.iD_StoreTextBox.Location = new System.Drawing.Point(105, 269);
            this.iD_StoreTextBox.Name = "iD_StoreTextBox";
            this.iD_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_StoreTextBox.TabIndex = 30;
            // 
            // name_StoreTextBox
            // 
            this.name_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Name_Store", true));
            this.name_StoreTextBox.Location = new System.Drawing.Point(105, 295);
            this.name_StoreTextBox.Name = "name_StoreTextBox";
            this.name_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_StoreTextBox.TabIndex = 32;
            // 
            // region_StoreTextBox
            // 
            this.region_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Region_Store", true));
            this.region_StoreTextBox.Location = new System.Drawing.Point(105, 321);
            this.region_StoreTextBox.Name = "region_StoreTextBox";
            this.region_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.region_StoreTextBox.TabIndex = 34;
            // 
            // locality_StoreTextBox
            // 
            this.locality_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Locality_Store", true));
            this.locality_StoreTextBox.Location = new System.Drawing.Point(105, 347);
            this.locality_StoreTextBox.Name = "locality_StoreTextBox";
            this.locality_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.locality_StoreTextBox.TabIndex = 36;
            // 
            // street_StoreTextBox
            // 
            this.street_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Street_Store", true));
            this.street_StoreTextBox.Location = new System.Drawing.Point(105, 373);
            this.street_StoreTextBox.Name = "street_StoreTextBox";
            this.street_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_StoreTextBox.TabIndex = 38;
            // 
            // house_StoreTextBox
            // 
            this.house_StoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "House_Store", true));
            this.house_StoreTextBox.Location = new System.Drawing.Point(105, 399);
            this.house_StoreTextBox.Name = "house_StoreTextBox";
            this.house_StoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.house_StoreTextBox.TabIndex = 40;
            // 
            // Form_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 458);
            this.ControlBox = false;
            this.Controls.Add(iD_StoreLabel);
            this.Controls.Add(this.iD_StoreTextBox);
            this.Controls.Add(name_StoreLabel);
            this.Controls.Add(this.name_StoreTextBox);
            this.Controls.Add(region_StoreLabel);
            this.Controls.Add(this.region_StoreTextBox);
            this.Controls.Add(locality_StoreLabel);
            this.Controls.Add(this.locality_StoreTextBox);
            this.Controls.Add(street_StoreLabel);
            this.Controls.Add(this.street_StoreTextBox);
            this.Controls.Add(house_StoreLabel);
            this.Controls.Add(this.house_StoreTextBox);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.storeBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Form_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).EndInit();
            this.storeBindingNavigator.ResumeLayout(false);
            this.storeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private KursovayaDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton storeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iD_StoreTextBox;
        private System.Windows.Forms.TextBox name_StoreTextBox;
        private System.Windows.Forms.TextBox region_StoreTextBox;
        private System.Windows.Forms.TextBox locality_StoreTextBox;
        private System.Windows.Forms.TextBox street_StoreTextBox;
        private System.Windows.Forms.TextBox house_StoreTextBox;
    }
}