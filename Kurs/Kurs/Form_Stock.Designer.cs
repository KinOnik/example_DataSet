namespace Kurs
{
    partial class Form_Stock
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
            System.Windows.Forms.Label iD_StockLabel;
            System.Windows.Forms.Label name_StockLabel;
            System.Windows.Forms.Label region_StockLabel;
            System.Windows.Forms.Label locality_StockLabel;
            System.Windows.Forms.Label street_StockLabel;
            System.Windows.Forms.Label house_StockLabel;
            System.Windows.Forms.Label salePrice_StockLabel;
            System.Windows.Forms.Label countProduct_StockLabel;
            System.Windows.Forms.Label iD_ProductLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Stock));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Kurs.KursovayaDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_StockTextBox = new System.Windows.Forms.TextBox();
            this.name_StockTextBox = new System.Windows.Forms.TextBox();
            this.region_StockTextBox = new System.Windows.Forms.TextBox();
            this.locality_StockTextBox = new System.Windows.Forms.TextBox();
            this.street_StockTextBox = new System.Windows.Forms.TextBox();
            this.house_StockTextBox = new System.Windows.Forms.TextBox();
            this.salePrice_StockTextBox = new System.Windows.Forms.TextBox();
            this.countProduct_StockTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProductTextBox = new System.Windows.Forms.TextBox();
            iD_StockLabel = new System.Windows.Forms.Label();
            name_StockLabel = new System.Windows.Forms.Label();
            region_StockLabel = new System.Windows.Forms.Label();
            locality_StockLabel = new System.Windows.Forms.Label();
            street_StockLabel = new System.Windows.Forms.Label();
            house_StockLabel = new System.Windows.Forms.Label();
            salePrice_StockLabel = new System.Windows.Forms.Label();
            countProduct_StockLabel = new System.Windows.Forms.Label();
            iD_ProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).BeginInit();
            this.stockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_StockLabel
            // 
            iD_StockLabel.AutoSize = true;
            iD_StockLabel.Location = new System.Drawing.Point(25, 274);
            iD_StockLabel.Name = "iD_StockLabel";
            iD_StockLabel.Size = new System.Drawing.Size(52, 13);
            iD_StockLabel.TabIndex = 33;
            iD_StockLabel.Text = "ID Stock:";
            // 
            // name_StockLabel
            // 
            name_StockLabel.AutoSize = true;
            name_StockLabel.Location = new System.Drawing.Point(25, 300);
            name_StockLabel.Name = "name_StockLabel";
            name_StockLabel.Size = new System.Drawing.Size(69, 13);
            name_StockLabel.TabIndex = 35;
            name_StockLabel.Text = "Name Stock:";
            // 
            // region_StockLabel
            // 
            region_StockLabel.AutoSize = true;
            region_StockLabel.Location = new System.Drawing.Point(25, 326);
            region_StockLabel.Name = "region_StockLabel";
            region_StockLabel.Size = new System.Drawing.Size(75, 13);
            region_StockLabel.TabIndex = 37;
            region_StockLabel.Text = "Region Stock:";
            // 
            // locality_StockLabel
            // 
            locality_StockLabel.AutoSize = true;
            locality_StockLabel.Location = new System.Drawing.Point(25, 352);
            locality_StockLabel.Name = "locality_StockLabel";
            locality_StockLabel.Size = new System.Drawing.Size(77, 13);
            locality_StockLabel.TabIndex = 39;
            locality_StockLabel.Text = "Locality Stock:";
            // 
            // street_StockLabel
            // 
            street_StockLabel.AutoSize = true;
            street_StockLabel.Location = new System.Drawing.Point(25, 378);
            street_StockLabel.Name = "street_StockLabel";
            street_StockLabel.Size = new System.Drawing.Size(69, 13);
            street_StockLabel.TabIndex = 41;
            street_StockLabel.Text = "Street Stock:";
            // 
            // house_StockLabel
            // 
            house_StockLabel.AutoSize = true;
            house_StockLabel.Location = new System.Drawing.Point(25, 404);
            house_StockLabel.Name = "house_StockLabel";
            house_StockLabel.Size = new System.Drawing.Size(72, 13);
            house_StockLabel.TabIndex = 43;
            house_StockLabel.Text = "House Stock:";
            // 
            // salePrice_StockLabel
            // 
            salePrice_StockLabel.AutoSize = true;
            salePrice_StockLabel.Location = new System.Drawing.Point(25, 430);
            salePrice_StockLabel.Name = "salePrice_StockLabel";
            salePrice_StockLabel.Size = new System.Drawing.Size(89, 13);
            salePrice_StockLabel.TabIndex = 45;
            salePrice_StockLabel.Text = "Sale Price Stock:";
            // 
            // countProduct_StockLabel
            // 
            countProduct_StockLabel.AutoSize = true;
            countProduct_StockLabel.Location = new System.Drawing.Point(25, 456);
            countProduct_StockLabel.Name = "countProduct_StockLabel";
            countProduct_StockLabel.Size = new System.Drawing.Size(109, 13);
            countProduct_StockLabel.TabIndex = 47;
            countProduct_StockLabel.Text = "Count Product Stock:";
            // 
            // iD_ProductLabel
            // 
            iD_ProductLabel.AutoSize = true;
            iD_ProductLabel.Location = new System.Drawing.Point(25, 482);
            iD_ProductLabel.Name = "iD_ProductLabel";
            iD_ProductLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProductLabel.TabIndex = 49;
            iD_ProductLabel.Text = "ID Product:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(932, 482);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(284, 303);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(394, 271);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(284, 271);
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockBindingNavigator
            // 
            this.stockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stockBindingNavigator.BindingSource = this.stockBindingSource;
            this.stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stockBindingNavigatorSaveItem});
            this.stockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stockBindingNavigator.Name = "stockBindingNavigator";
            this.stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stockBindingNavigator.Size = new System.Drawing.Size(1019, 25);
            this.stockBindingNavigator.TabIndex = 33;
            this.stockBindingNavigator.Text = "bindingNavigator1";
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
            // stockBindingNavigatorSaveItem
            // 
            this.stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBindingNavigatorSaveItem.Image")));
            this.stockBindingNavigatorSaveItem.Name = "stockBindingNavigatorSaveItem";
            this.stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stockBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stockBindingNavigatorSaveItem.Click += new System.EventHandler(this.stockBindingNavigatorSaveItem_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.stockDataGridView.DataSource = this.stockBindingSource;
            this.stockDataGridView.Location = new System.Drawing.Point(11, 32);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.Size = new System.Drawing.Size(996, 220);
            this.stockDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Stock";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Stock";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Stock";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Stock";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Region_Stock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Region_Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Locality_Stock";
            this.dataGridViewTextBoxColumn4.HeaderText = "Locality_Stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street_Stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street_Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "House_Stock";
            this.dataGridViewTextBoxColumn6.HeaderText = "House_Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SalePrice_Stock";
            this.dataGridViewTextBoxColumn7.HeaderText = "SalePrice_Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CountProduct_Stock";
            this.dataGridViewTextBoxColumn8.HeaderText = "CountProduct_Stock";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_Product";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID_Product";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // iD_StockTextBox
            // 
            this.iD_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_Stock", true));
            this.iD_StockTextBox.Location = new System.Drawing.Point(140, 271);
            this.iD_StockTextBox.Name = "iD_StockTextBox";
            this.iD_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_StockTextBox.TabIndex = 34;
            // 
            // name_StockTextBox
            // 
            this.name_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Name_Stock", true));
            this.name_StockTextBox.Location = new System.Drawing.Point(140, 297);
            this.name_StockTextBox.Name = "name_StockTextBox";
            this.name_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_StockTextBox.TabIndex = 36;
            // 
            // region_StockTextBox
            // 
            this.region_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Region_Stock", true));
            this.region_StockTextBox.Location = new System.Drawing.Point(140, 323);
            this.region_StockTextBox.Name = "region_StockTextBox";
            this.region_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.region_StockTextBox.TabIndex = 38;
            // 
            // locality_StockTextBox
            // 
            this.locality_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Locality_Stock", true));
            this.locality_StockTextBox.Location = new System.Drawing.Point(140, 349);
            this.locality_StockTextBox.Name = "locality_StockTextBox";
            this.locality_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.locality_StockTextBox.TabIndex = 40;
            // 
            // street_StockTextBox
            // 
            this.street_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Street_Stock", true));
            this.street_StockTextBox.Location = new System.Drawing.Point(140, 375);
            this.street_StockTextBox.Name = "street_StockTextBox";
            this.street_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_StockTextBox.TabIndex = 42;
            // 
            // house_StockTextBox
            // 
            this.house_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "House_Stock", true));
            this.house_StockTextBox.Location = new System.Drawing.Point(140, 401);
            this.house_StockTextBox.Name = "house_StockTextBox";
            this.house_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.house_StockTextBox.TabIndex = 44;
            // 
            // salePrice_StockTextBox
            // 
            this.salePrice_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "SalePrice_Stock", true));
            this.salePrice_StockTextBox.Location = new System.Drawing.Point(140, 427);
            this.salePrice_StockTextBox.Name = "salePrice_StockTextBox";
            this.salePrice_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.salePrice_StockTextBox.TabIndex = 46;
            // 
            // countProduct_StockTextBox
            // 
            this.countProduct_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "CountProduct_Stock", true));
            this.countProduct_StockTextBox.Location = new System.Drawing.Point(140, 453);
            this.countProduct_StockTextBox.Name = "countProduct_StockTextBox";
            this.countProduct_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.countProduct_StockTextBox.TabIndex = 48;
            // 
            // iD_ProductTextBox
            // 
            this.iD_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_Product", true));
            this.iD_ProductTextBox.Location = new System.Drawing.Point(140, 479);
            this.iD_ProductTextBox.Name = "iD_ProductTextBox";
            this.iD_ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProductTextBox.TabIndex = 50;
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 525);
            this.ControlBox = false;
            this.Controls.Add(iD_StockLabel);
            this.Controls.Add(this.iD_StockTextBox);
            this.Controls.Add(name_StockLabel);
            this.Controls.Add(this.name_StockTextBox);
            this.Controls.Add(region_StockLabel);
            this.Controls.Add(this.region_StockTextBox);
            this.Controls.Add(locality_StockLabel);
            this.Controls.Add(this.locality_StockTextBox);
            this.Controls.Add(street_StockLabel);
            this.Controls.Add(this.street_StockTextBox);
            this.Controls.Add(house_StockLabel);
            this.Controls.Add(this.house_StockTextBox);
            this.Controls.Add(salePrice_StockLabel);
            this.Controls.Add(this.salePrice_StockTextBox);
            this.Controls.Add(countProduct_StockLabel);
            this.Controls.Add(this.countProduct_StockTextBox);
            this.Controls.Add(iD_ProductLabel);
            this.Controls.Add(this.iD_ProductTextBox);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.stockBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Form_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).EndInit();
            this.stockBindingNavigator.ResumeLayout(false);
            this.stockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private KursovayaDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stockBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox iD_StockTextBox;
        private System.Windows.Forms.TextBox name_StockTextBox;
        private System.Windows.Forms.TextBox region_StockTextBox;
        private System.Windows.Forms.TextBox locality_StockTextBox;
        private System.Windows.Forms.TextBox street_StockTextBox;
        private System.Windows.Forms.TextBox house_StockTextBox;
        private System.Windows.Forms.TextBox salePrice_StockTextBox;
        private System.Windows.Forms.TextBox countProduct_StockTextBox;
        private System.Windows.Forms.TextBox iD_ProductTextBox;
    }
}