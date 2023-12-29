namespace Kurs
{
    partial class FORM_Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_Stok));
            System.Windows.Forms.Label iD_StockLabel;
            System.Windows.Forms.Label name_StockLabel;
            System.Windows.Forms.Label region_StockLabel;
            System.Windows.Forms.Label locality_StockLabel;
            System.Windows.Forms.Label street_StockLabel;
            System.Windows.Forms.Label house_StockLabel;
            System.Windows.Forms.Label salePrice_StockLabel;
            System.Windows.Forms.Label countProduct_StockLabel;
            System.Windows.Forms.Label iD_ProductLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataSet1 = new Kurs.DataSet1();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Kurs.DataSet1TableAdapters.StockTableAdapter();
            this.tableAdapterManager = new Kurs.DataSet1TableAdapters.TableAdapterManager();
            this.stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).BeginInit();
            this.stockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "DEL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.dataSet1;
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
            this.tableAdapterManager.UpdateOrder = Kurs.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.stockBindingNavigator.Size = new System.Drawing.Size(1102, 25);
            this.stockBindingNavigator.TabIndex = 26;
            this.stockBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // stockBindingNavigatorSaveItem
            // 
            this.stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBindingNavigatorSaveItem.Image")));
            this.stockBindingNavigatorSaveItem.Name = "stockBindingNavigatorSaveItem";
            this.stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.stockBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stockBindingNavigatorSaveItem.Click += new System.EventHandler(this.stockBindingNavigatorSaveItem_Click_1);
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
            this.stockDataGridView.Location = new System.Drawing.Point(20, 55);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.Size = new System.Drawing.Size(955, 220);
            this.stockDataGridView.TabIndex = 26;
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
            // iD_StockLabel
            // 
            iD_StockLabel.AutoSize = true;
            iD_StockLabel.Location = new System.Drawing.Point(73, 319);
            iD_StockLabel.Name = "iD_StockLabel";
            iD_StockLabel.Size = new System.Drawing.Size(52, 13);
            iD_StockLabel.TabIndex = 26;
            iD_StockLabel.Text = "ID Stock:";
            // 
            // iD_StockTextBox
            // 
            this.iD_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_Stock", true));
            this.iD_StockTextBox.Location = new System.Drawing.Point(188, 316);
            this.iD_StockTextBox.Name = "iD_StockTextBox";
            this.iD_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_StockTextBox.TabIndex = 27;
            // 
            // name_StockLabel
            // 
            name_StockLabel.AutoSize = true;
            name_StockLabel.Location = new System.Drawing.Point(73, 345);
            name_StockLabel.Name = "name_StockLabel";
            name_StockLabel.Size = new System.Drawing.Size(69, 13);
            name_StockLabel.TabIndex = 28;
            name_StockLabel.Text = "Name Stock:";
            // 
            // name_StockTextBox
            // 
            this.name_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Name_Stock", true));
            this.name_StockTextBox.Location = new System.Drawing.Point(188, 342);
            this.name_StockTextBox.Name = "name_StockTextBox";
            this.name_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_StockTextBox.TabIndex = 29;
            // 
            // region_StockLabel
            // 
            region_StockLabel.AutoSize = true;
            region_StockLabel.Location = new System.Drawing.Point(73, 371);
            region_StockLabel.Name = "region_StockLabel";
            region_StockLabel.Size = new System.Drawing.Size(75, 13);
            region_StockLabel.TabIndex = 30;
            region_StockLabel.Text = "Region Stock:";
            // 
            // region_StockTextBox
            // 
            this.region_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Region_Stock", true));
            this.region_StockTextBox.Location = new System.Drawing.Point(188, 368);
            this.region_StockTextBox.Name = "region_StockTextBox";
            this.region_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.region_StockTextBox.TabIndex = 31;
            // 
            // locality_StockLabel
            // 
            locality_StockLabel.AutoSize = true;
            locality_StockLabel.Location = new System.Drawing.Point(73, 397);
            locality_StockLabel.Name = "locality_StockLabel";
            locality_StockLabel.Size = new System.Drawing.Size(77, 13);
            locality_StockLabel.TabIndex = 32;
            locality_StockLabel.Text = "Locality Stock:";
            // 
            // locality_StockTextBox
            // 
            this.locality_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Locality_Stock", true));
            this.locality_StockTextBox.Location = new System.Drawing.Point(188, 394);
            this.locality_StockTextBox.Name = "locality_StockTextBox";
            this.locality_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.locality_StockTextBox.TabIndex = 33;
            // 
            // street_StockLabel
            // 
            street_StockLabel.AutoSize = true;
            street_StockLabel.Location = new System.Drawing.Point(73, 423);
            street_StockLabel.Name = "street_StockLabel";
            street_StockLabel.Size = new System.Drawing.Size(69, 13);
            street_StockLabel.TabIndex = 34;
            street_StockLabel.Text = "Street Stock:";
            // 
            // street_StockTextBox
            // 
            this.street_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Street_Stock", true));
            this.street_StockTextBox.Location = new System.Drawing.Point(188, 420);
            this.street_StockTextBox.Name = "street_StockTextBox";
            this.street_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_StockTextBox.TabIndex = 35;
            // 
            // house_StockLabel
            // 
            house_StockLabel.AutoSize = true;
            house_StockLabel.Location = new System.Drawing.Point(73, 449);
            house_StockLabel.Name = "house_StockLabel";
            house_StockLabel.Size = new System.Drawing.Size(72, 13);
            house_StockLabel.TabIndex = 36;
            house_StockLabel.Text = "House Stock:";
            // 
            // house_StockTextBox
            // 
            this.house_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "House_Stock", true));
            this.house_StockTextBox.Location = new System.Drawing.Point(188, 446);
            this.house_StockTextBox.Name = "house_StockTextBox";
            this.house_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.house_StockTextBox.TabIndex = 37;
            // 
            // salePrice_StockLabel
            // 
            salePrice_StockLabel.AutoSize = true;
            salePrice_StockLabel.Location = new System.Drawing.Point(73, 475);
            salePrice_StockLabel.Name = "salePrice_StockLabel";
            salePrice_StockLabel.Size = new System.Drawing.Size(89, 13);
            salePrice_StockLabel.TabIndex = 38;
            salePrice_StockLabel.Text = "Sale Price Stock:";
            // 
            // salePrice_StockTextBox
            // 
            this.salePrice_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "SalePrice_Stock", true));
            this.salePrice_StockTextBox.Location = new System.Drawing.Point(188, 472);
            this.salePrice_StockTextBox.Name = "salePrice_StockTextBox";
            this.salePrice_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.salePrice_StockTextBox.TabIndex = 39;
            // 
            // countProduct_StockLabel
            // 
            countProduct_StockLabel.AutoSize = true;
            countProduct_StockLabel.Location = new System.Drawing.Point(73, 501);
            countProduct_StockLabel.Name = "countProduct_StockLabel";
            countProduct_StockLabel.Size = new System.Drawing.Size(109, 13);
            countProduct_StockLabel.TabIndex = 40;
            countProduct_StockLabel.Text = "Count Product Stock:";
            // 
            // countProduct_StockTextBox
            // 
            this.countProduct_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "CountProduct_Stock", true));
            this.countProduct_StockTextBox.Location = new System.Drawing.Point(188, 498);
            this.countProduct_StockTextBox.Name = "countProduct_StockTextBox";
            this.countProduct_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.countProduct_StockTextBox.TabIndex = 41;
            // 
            // iD_ProductLabel
            // 
            iD_ProductLabel.AutoSize = true;
            iD_ProductLabel.Location = new System.Drawing.Point(73, 527);
            iD_ProductLabel.Name = "iD_ProductLabel";
            iD_ProductLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProductLabel.TabIndex = 42;
            iD_ProductLabel.Text = "ID Product:";
            // 
            // iD_ProductTextBox
            // 
            this.iD_ProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ID_Product", true));
            this.iD_ProductTextBox.Location = new System.Drawing.Point(188, 524);
            this.iD_ProductTextBox.Name = "iD_ProductTextBox";
            this.iD_ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProductTextBox.TabIndex = 43;
            // 
            // FORM_Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 618);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "FORM_Stok";
            this.Text = "FORM_Manufact";
            this.Load += new System.EventHandler(this.FORM_Manufact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).EndInit();
            this.stockBindingNavigator.ResumeLayout(false);
            this.stockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DataSet1TableAdapters.StockTableAdapter stockTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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