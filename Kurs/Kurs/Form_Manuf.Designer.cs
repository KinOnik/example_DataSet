namespace Kurs
{
    partial class Form_Manuf
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
            System.Windows.Forms.Label iD_ManufacturerLabel;
            System.Windows.Forms.Label name_ManufacturerLabel;
            System.Windows.Forms.Label contactPerson_ManufacturerLabel;
            System.Windows.Forms.Label contactPhone_ManufacturerLabel;
            System.Windows.Forms.Label index_ManufacturerLabel;
            System.Windows.Forms.Label country_ManufacturerLabel;
            System.Windows.Forms.Label region_ManufacturerLabel;
            System.Windows.Forms.Label locality_ManufacturerLabel;
            System.Windows.Forms.Label street_ManufacturerLabel;
            System.Windows.Forms.Label house_ManufacturerLabel;
            System.Windows.Forms.Label isDeletedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manuf));
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new Kurs.KursovayaDataSetTableAdapters.ManufacturerTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.manufacturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.manufacturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localityManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iD_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.name_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.contactPerson_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.contactPhone_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.index_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.country_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.region_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.locality_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.street_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.house_ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_EXIT = new System.Windows.Forms.Button();
            iD_ManufacturerLabel = new System.Windows.Forms.Label();
            name_ManufacturerLabel = new System.Windows.Forms.Label();
            contactPerson_ManufacturerLabel = new System.Windows.Forms.Label();
            contactPhone_ManufacturerLabel = new System.Windows.Forms.Label();
            index_ManufacturerLabel = new System.Windows.Forms.Label();
            country_ManufacturerLabel = new System.Windows.Forms.Label();
            region_ManufacturerLabel = new System.Windows.Forms.Label();
            locality_ManufacturerLabel = new System.Windows.Forms.Label();
            street_ManufacturerLabel = new System.Windows.Forms.Label();
            house_ManufacturerLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).BeginInit();
            this.manufacturerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ManufacturerLabel
            // 
            iD_ManufacturerLabel.AutoSize = true;
            iD_ManufacturerLabel.Location = new System.Drawing.Point(21, 261);
            iD_ManufacturerLabel.Name = "iD_ManufacturerLabel";
            iD_ManufacturerLabel.Size = new System.Drawing.Size(87, 13);
            iD_ManufacturerLabel.TabIndex = 2;
            iD_ManufacturerLabel.Text = "ID Manufacturer:";
            // 
            // name_ManufacturerLabel
            // 
            name_ManufacturerLabel.AutoSize = true;
            name_ManufacturerLabel.Location = new System.Drawing.Point(21, 287);
            name_ManufacturerLabel.Name = "name_ManufacturerLabel";
            name_ManufacturerLabel.Size = new System.Drawing.Size(104, 13);
            name_ManufacturerLabel.TabIndex = 4;
            name_ManufacturerLabel.Text = "Name Manufacturer:";
            // 
            // contactPerson_ManufacturerLabel
            // 
            contactPerson_ManufacturerLabel.AutoSize = true;
            contactPerson_ManufacturerLabel.Location = new System.Drawing.Point(21, 313);
            contactPerson_ManufacturerLabel.Name = "contactPerson_ManufacturerLabel";
            contactPerson_ManufacturerLabel.Size = new System.Drawing.Size(149, 13);
            contactPerson_ManufacturerLabel.TabIndex = 6;
            contactPerson_ManufacturerLabel.Text = "Contact Person Manufacturer:";
            // 
            // contactPhone_ManufacturerLabel
            // 
            contactPhone_ManufacturerLabel.AutoSize = true;
            contactPhone_ManufacturerLabel.Location = new System.Drawing.Point(21, 339);
            contactPhone_ManufacturerLabel.Name = "contactPhone_ManufacturerLabel";
            contactPhone_ManufacturerLabel.Size = new System.Drawing.Size(147, 13);
            contactPhone_ManufacturerLabel.TabIndex = 8;
            contactPhone_ManufacturerLabel.Text = "Contact Phone Manufacturer:";
            // 
            // index_ManufacturerLabel
            // 
            index_ManufacturerLabel.AutoSize = true;
            index_ManufacturerLabel.Location = new System.Drawing.Point(21, 365);
            index_ManufacturerLabel.Name = "index_ManufacturerLabel";
            index_ManufacturerLabel.Size = new System.Drawing.Size(102, 13);
            index_ManufacturerLabel.TabIndex = 10;
            index_ManufacturerLabel.Text = "Index Manufacturer:";
            // 
            // country_ManufacturerLabel
            // 
            country_ManufacturerLabel.AutoSize = true;
            country_ManufacturerLabel.Location = new System.Drawing.Point(21, 391);
            country_ManufacturerLabel.Name = "country_ManufacturerLabel";
            country_ManufacturerLabel.Size = new System.Drawing.Size(112, 13);
            country_ManufacturerLabel.TabIndex = 12;
            country_ManufacturerLabel.Text = "Country Manufacturer:";
            // 
            // region_ManufacturerLabel
            // 
            region_ManufacturerLabel.AutoSize = true;
            region_ManufacturerLabel.Location = new System.Drawing.Point(21, 417);
            region_ManufacturerLabel.Name = "region_ManufacturerLabel";
            region_ManufacturerLabel.Size = new System.Drawing.Size(110, 13);
            region_ManufacturerLabel.TabIndex = 14;
            region_ManufacturerLabel.Text = "Region Manufacturer:";
            // 
            // locality_ManufacturerLabel
            // 
            locality_ManufacturerLabel.AutoSize = true;
            locality_ManufacturerLabel.Location = new System.Drawing.Point(21, 443);
            locality_ManufacturerLabel.Name = "locality_ManufacturerLabel";
            locality_ManufacturerLabel.Size = new System.Drawing.Size(112, 13);
            locality_ManufacturerLabel.TabIndex = 16;
            locality_ManufacturerLabel.Text = "Locality Manufacturer:";
            // 
            // street_ManufacturerLabel
            // 
            street_ManufacturerLabel.AutoSize = true;
            street_ManufacturerLabel.Location = new System.Drawing.Point(21, 469);
            street_ManufacturerLabel.Name = "street_ManufacturerLabel";
            street_ManufacturerLabel.Size = new System.Drawing.Size(104, 13);
            street_ManufacturerLabel.TabIndex = 18;
            street_ManufacturerLabel.Text = "Street Manufacturer:";
            // 
            // house_ManufacturerLabel
            // 
            house_ManufacturerLabel.AutoSize = true;
            house_ManufacturerLabel.Location = new System.Drawing.Point(21, 495);
            house_ManufacturerLabel.Name = "house_ManufacturerLabel";
            house_ManufacturerLabel.Size = new System.Drawing.Size(107, 13);
            house_ManufacturerLabel.TabIndex = 20;
            house_ManufacturerLabel.Text = "House Manufacturer:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(21, 523);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(58, 13);
            isDeletedLabel.TabIndex = 22;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // kursovayaDataSet
            // 
            this.kursovayaDataSet.DataSetName = "KursovayaDataSet";
            this.kursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
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
            // manufacturerBindingNavigator
            // 
            this.manufacturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturerBindingNavigator.BindingSource = this.manufacturerBindingSource;
            this.manufacturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.manufacturerBindingNavigatorSaveItem});
            this.manufacturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturerBindingNavigator.Name = "manufacturerBindingNavigator";
            this.manufacturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturerBindingNavigator.Size = new System.Drawing.Size(1202, 25);
            this.manufacturerBindingNavigator.TabIndex = 0;
            this.manufacturerBindingNavigator.Text = "bindingNavigator1";
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
            // manufacturerBindingNavigatorSaveItem
            // 
            this.manufacturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturerBindingNavigatorSaveItem.Image")));
            this.manufacturerBindingNavigatorSaveItem.Name = "manufacturerBindingNavigatorSaveItem";
            this.manufacturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manufacturerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.manufacturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturerBindingNavigatorSaveItem_Click);
            // 
            // manufacturerDataGridView
            // 
            this.manufacturerDataGridView.AutoGenerateColumns = false;
            this.manufacturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDManufacturerDataGridViewTextBoxColumn,
            this.nameManufacturerDataGridViewTextBoxColumn,
            this.contactPersonManufacturerDataGridViewTextBoxColumn,
            this.contactPhoneManufacturerDataGridViewTextBoxColumn,
            this.indexManufacturerDataGridViewTextBoxColumn,
            this.countryManufacturerDataGridViewTextBoxColumn,
            this.regionManufacturerDataGridViewTextBoxColumn,
            this.localityManufacturerDataGridViewTextBoxColumn,
            this.streetManufacturerDataGridViewTextBoxColumn,
            this.houseManufacturerDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn});
            this.manufacturerDataGridView.DataSource = this.manufacturerBindingSource;
            this.manufacturerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.manufacturerDataGridView.Name = "manufacturerDataGridView";
            this.manufacturerDataGridView.Size = new System.Drawing.Size(1178, 220);
            this.manufacturerDataGridView.TabIndex = 1;
            // 
            // iDManufacturerDataGridViewTextBoxColumn
            // 
            this.iDManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.HeaderText = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.Name = "iDManufacturerDataGridViewTextBoxColumn";
            this.iDManufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameManufacturerDataGridViewTextBoxColumn
            // 
            this.nameManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Name_Manufacturer";
            this.nameManufacturerDataGridViewTextBoxColumn.HeaderText = "Name_Manufacturer";
            this.nameManufacturerDataGridViewTextBoxColumn.Name = "nameManufacturerDataGridViewTextBoxColumn";
            // 
            // contactPersonManufacturerDataGridViewTextBoxColumn
            // 
            this.contactPersonManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson_Manufacturer";
            this.contactPersonManufacturerDataGridViewTextBoxColumn.HeaderText = "ContactPerson_Manufacturer";
            this.contactPersonManufacturerDataGridViewTextBoxColumn.Name = "contactPersonManufacturerDataGridViewTextBoxColumn";
            // 
            // contactPhoneManufacturerDataGridViewTextBoxColumn
            // 
            this.contactPhoneManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone_Manufacturer";
            this.contactPhoneManufacturerDataGridViewTextBoxColumn.HeaderText = "ContactPhone_Manufacturer";
            this.contactPhoneManufacturerDataGridViewTextBoxColumn.Name = "contactPhoneManufacturerDataGridViewTextBoxColumn";
            // 
            // indexManufacturerDataGridViewTextBoxColumn
            // 
            this.indexManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Index_Manufacturer";
            this.indexManufacturerDataGridViewTextBoxColumn.HeaderText = "Index_Manufacturer";
            this.indexManufacturerDataGridViewTextBoxColumn.Name = "indexManufacturerDataGridViewTextBoxColumn";
            // 
            // countryManufacturerDataGridViewTextBoxColumn
            // 
            this.countryManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Country_Manufacturer";
            this.countryManufacturerDataGridViewTextBoxColumn.HeaderText = "Country_Manufacturer";
            this.countryManufacturerDataGridViewTextBoxColumn.Name = "countryManufacturerDataGridViewTextBoxColumn";
            // 
            // regionManufacturerDataGridViewTextBoxColumn
            // 
            this.regionManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Region_Manufacturer";
            this.regionManufacturerDataGridViewTextBoxColumn.HeaderText = "Region_Manufacturer";
            this.regionManufacturerDataGridViewTextBoxColumn.Name = "regionManufacturerDataGridViewTextBoxColumn";
            // 
            // localityManufacturerDataGridViewTextBoxColumn
            // 
            this.localityManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Locality_Manufacturer";
            this.localityManufacturerDataGridViewTextBoxColumn.HeaderText = "Locality_Manufacturer";
            this.localityManufacturerDataGridViewTextBoxColumn.Name = "localityManufacturerDataGridViewTextBoxColumn";
            // 
            // streetManufacturerDataGridViewTextBoxColumn
            // 
            this.streetManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Street_Manufacturer";
            this.streetManufacturerDataGridViewTextBoxColumn.HeaderText = "Street_Manufacturer";
            this.streetManufacturerDataGridViewTextBoxColumn.Name = "streetManufacturerDataGridViewTextBoxColumn";
            // 
            // houseManufacturerDataGridViewTextBoxColumn
            // 
            this.houseManufacturerDataGridViewTextBoxColumn.DataPropertyName = "House_Manufacturer";
            this.houseManufacturerDataGridViewTextBoxColumn.HeaderText = "House_Manufacturer";
            this.houseManufacturerDataGridViewTextBoxColumn.Name = "houseManufacturerDataGridViewTextBoxColumn";
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            // 
            // iD_ManufacturerTextBox
            // 
            this.iD_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "ID_Manufacturer", true));
            this.iD_ManufacturerTextBox.Location = new System.Drawing.Point(176, 258);
            this.iD_ManufacturerTextBox.Name = "iD_ManufacturerTextBox";
            this.iD_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_ManufacturerTextBox.TabIndex = 3;
            // 
            // name_ManufacturerTextBox
            // 
            this.name_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Name_Manufacturer", true));
            this.name_ManufacturerTextBox.Location = new System.Drawing.Point(176, 284);
            this.name_ManufacturerTextBox.Name = "name_ManufacturerTextBox";
            this.name_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.name_ManufacturerTextBox.TabIndex = 5;
            // 
            // contactPerson_ManufacturerTextBox
            // 
            this.contactPerson_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "ContactPerson_Manufacturer", true));
            this.contactPerson_ManufacturerTextBox.Location = new System.Drawing.Point(176, 310);
            this.contactPerson_ManufacturerTextBox.Name = "contactPerson_ManufacturerTextBox";
            this.contactPerson_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.contactPerson_ManufacturerTextBox.TabIndex = 7;
            // 
            // contactPhone_ManufacturerTextBox
            // 
            this.contactPhone_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "ContactPhone_Manufacturer", true));
            this.contactPhone_ManufacturerTextBox.Location = new System.Drawing.Point(176, 336);
            this.contactPhone_ManufacturerTextBox.Name = "contactPhone_ManufacturerTextBox";
            this.contactPhone_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.contactPhone_ManufacturerTextBox.TabIndex = 9;
            // 
            // index_ManufacturerTextBox
            // 
            this.index_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Index_Manufacturer", true));
            this.index_ManufacturerTextBox.Location = new System.Drawing.Point(176, 362);
            this.index_ManufacturerTextBox.Name = "index_ManufacturerTextBox";
            this.index_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.index_ManufacturerTextBox.TabIndex = 11;
            // 
            // country_ManufacturerTextBox
            // 
            this.country_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Country_Manufacturer", true));
            this.country_ManufacturerTextBox.Location = new System.Drawing.Point(176, 388);
            this.country_ManufacturerTextBox.Name = "country_ManufacturerTextBox";
            this.country_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.country_ManufacturerTextBox.TabIndex = 13;
            // 
            // region_ManufacturerTextBox
            // 
            this.region_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Region_Manufacturer", true));
            this.region_ManufacturerTextBox.Location = new System.Drawing.Point(176, 414);
            this.region_ManufacturerTextBox.Name = "region_ManufacturerTextBox";
            this.region_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.region_ManufacturerTextBox.TabIndex = 15;
            // 
            // locality_ManufacturerTextBox
            // 
            this.locality_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Locality_Manufacturer", true));
            this.locality_ManufacturerTextBox.Location = new System.Drawing.Point(176, 440);
            this.locality_ManufacturerTextBox.Name = "locality_ManufacturerTextBox";
            this.locality_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.locality_ManufacturerTextBox.TabIndex = 17;
            // 
            // street_ManufacturerTextBox
            // 
            this.street_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Street_Manufacturer", true));
            this.street_ManufacturerTextBox.Location = new System.Drawing.Point(176, 466);
            this.street_ManufacturerTextBox.Name = "street_ManufacturerTextBox";
            this.street_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.street_ManufacturerTextBox.TabIndex = 19;
            // 
            // house_ManufacturerTextBox
            // 
            this.house_ManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "House_Manufacturer", true));
            this.house_ManufacturerTextBox.Location = new System.Drawing.Point(176, 492);
            this.house_ManufacturerTextBox.Name = "house_ManufacturerTextBox";
            this.house_ManufacturerTextBox.Size = new System.Drawing.Size(104, 20);
            this.house_ManufacturerTextBox.TabIndex = 21;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.manufacturerBindingSource, "IsDeleted", true));
            this.isDeletedCheckBox.Location = new System.Drawing.Point(176, 518);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDeletedCheckBox.TabIndex = 23;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(344, 261);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(82, 23);
            this.Button_ADD.TabIndex = 24;
            this.Button_ADD.Text = "ДОБАВИТЬ";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(447, 261);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 24;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(344, 294);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 24;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(1108, 522);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 24;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Form_Manuf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 557);
            this.ControlBox = false;
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Controls.Add(iD_ManufacturerLabel);
            this.Controls.Add(this.iD_ManufacturerTextBox);
            this.Controls.Add(name_ManufacturerLabel);
            this.Controls.Add(this.name_ManufacturerTextBox);
            this.Controls.Add(contactPerson_ManufacturerLabel);
            this.Controls.Add(this.contactPerson_ManufacturerTextBox);
            this.Controls.Add(contactPhone_ManufacturerLabel);
            this.Controls.Add(this.contactPhone_ManufacturerTextBox);
            this.Controls.Add(index_ManufacturerLabel);
            this.Controls.Add(this.index_ManufacturerTextBox);
            this.Controls.Add(country_ManufacturerLabel);
            this.Controls.Add(this.country_ManufacturerTextBox);
            this.Controls.Add(region_ManufacturerLabel);
            this.Controls.Add(this.region_ManufacturerTextBox);
            this.Controls.Add(locality_ManufacturerLabel);
            this.Controls.Add(this.locality_ManufacturerTextBox);
            this.Controls.Add(street_ManufacturerLabel);
            this.Controls.Add(this.street_ManufacturerTextBox);
            this.Controls.Add(house_ManufacturerLabel);
            this.Controls.Add(this.house_ManufacturerTextBox);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Controls.Add(this.manufacturerDataGridView);
            this.Controls.Add(this.manufacturerBindingNavigator);
            this.Name = "Form_Manuf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturer";
            this.Load += new System.EventHandler(this.Form_Manuf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).EndInit();
            this.manufacturerBindingNavigator.ResumeLayout(false);
            this.manufacturerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private KursovayaDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton manufacturerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manufacturerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localityManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox iD_ManufacturerTextBox;
        private System.Windows.Forms.TextBox name_ManufacturerTextBox;
        private System.Windows.Forms.TextBox contactPerson_ManufacturerTextBox;
        private System.Windows.Forms.TextBox contactPhone_ManufacturerTextBox;
        private System.Windows.Forms.TextBox index_ManufacturerTextBox;
        private System.Windows.Forms.TextBox country_ManufacturerTextBox;
        private System.Windows.Forms.TextBox region_ManufacturerTextBox;
        private System.Windows.Forms.TextBox locality_ManufacturerTextBox;
        private System.Windows.Forms.TextBox street_ManufacturerTextBox;
        private System.Windows.Forms.TextBox house_ManufacturerTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
        private System.Windows.Forms.Button Button_ADD;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_EXIT;
    }
}