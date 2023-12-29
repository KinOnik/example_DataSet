namespace Kurs
{
    partial class Form_Provider
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
            System.Windows.Forms.Label iD_ProviderLabel;
            System.Windows.Forms.Label name_ProviderLabel;
            System.Windows.Forms.Label contactPerson_ProviderLabel;
            System.Windows.Forms.Label contactPhone_ProviderLabel;
            System.Windows.Forms.Label index_ProviderLabel;
            System.Windows.Forms.Label country_ProviderLabel;
            System.Windows.Forms.Label region_ProviderLabel;
            System.Windows.Forms.Label locality_ProviderLabel;
            System.Windows.Forms.Label street_ProviderLabel;
            System.Windows.Forms.Label house_ProviderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Provider));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new Kurs.KursovayaDataSetTableAdapters.ProviderTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.providerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.providerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.providerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.name_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.contactPerson_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.contactPhone_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.index_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.country_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.region_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.locality_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.street_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.house_ProviderTextBox = new System.Windows.Forms.TextBox();
            iD_ProviderLabel = new System.Windows.Forms.Label();
            name_ProviderLabel = new System.Windows.Forms.Label();
            contactPerson_ProviderLabel = new System.Windows.Forms.Label();
            contactPhone_ProviderLabel = new System.Windows.Forms.Label();
            index_ProviderLabel = new System.Windows.Forms.Label();
            country_ProviderLabel = new System.Windows.Forms.Label();
            region_ProviderLabel = new System.Windows.Forms.Label();
            locality_ProviderLabel = new System.Windows.Forms.Label();
            street_ProviderLabel = new System.Windows.Forms.Label();
            house_ProviderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingNavigator)).BeginInit();
            this.providerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ProviderLabel
            // 
            iD_ProviderLabel.AutoSize = true;
            iD_ProviderLabel.Location = new System.Drawing.Point(29, 266);
            iD_ProviderLabel.Name = "iD_ProviderLabel";
            iD_ProviderLabel.Size = new System.Drawing.Size(63, 13);
            iD_ProviderLabel.TabIndex = 33;
            iD_ProviderLabel.Text = "ID Provider:";
            // 
            // name_ProviderLabel
            // 
            name_ProviderLabel.AutoSize = true;
            name_ProviderLabel.Location = new System.Drawing.Point(29, 292);
            name_ProviderLabel.Name = "name_ProviderLabel";
            name_ProviderLabel.Size = new System.Drawing.Size(80, 13);
            name_ProviderLabel.TabIndex = 35;
            name_ProviderLabel.Text = "Name Provider:";
            // 
            // contactPerson_ProviderLabel
            // 
            contactPerson_ProviderLabel.AutoSize = true;
            contactPerson_ProviderLabel.Location = new System.Drawing.Point(29, 318);
            contactPerson_ProviderLabel.Name = "contactPerson_ProviderLabel";
            contactPerson_ProviderLabel.Size = new System.Drawing.Size(125, 13);
            contactPerson_ProviderLabel.TabIndex = 37;
            contactPerson_ProviderLabel.Text = "Contact Person Provider:";
            // 
            // contactPhone_ProviderLabel
            // 
            contactPhone_ProviderLabel.AutoSize = true;
            contactPhone_ProviderLabel.Location = new System.Drawing.Point(29, 344);
            contactPhone_ProviderLabel.Name = "contactPhone_ProviderLabel";
            contactPhone_ProviderLabel.Size = new System.Drawing.Size(123, 13);
            contactPhone_ProviderLabel.TabIndex = 39;
            contactPhone_ProviderLabel.Text = "Contact Phone Provider:";
            // 
            // index_ProviderLabel
            // 
            index_ProviderLabel.AutoSize = true;
            index_ProviderLabel.Location = new System.Drawing.Point(29, 370);
            index_ProviderLabel.Name = "index_ProviderLabel";
            index_ProviderLabel.Size = new System.Drawing.Size(78, 13);
            index_ProviderLabel.TabIndex = 41;
            index_ProviderLabel.Text = "Index Provider:";
            // 
            // country_ProviderLabel
            // 
            country_ProviderLabel.AutoSize = true;
            country_ProviderLabel.Location = new System.Drawing.Point(29, 396);
            country_ProviderLabel.Name = "country_ProviderLabel";
            country_ProviderLabel.Size = new System.Drawing.Size(88, 13);
            country_ProviderLabel.TabIndex = 43;
            country_ProviderLabel.Text = "Country Provider:";
            // 
            // region_ProviderLabel
            // 
            region_ProviderLabel.AutoSize = true;
            region_ProviderLabel.Location = new System.Drawing.Point(29, 422);
            region_ProviderLabel.Name = "region_ProviderLabel";
            region_ProviderLabel.Size = new System.Drawing.Size(86, 13);
            region_ProviderLabel.TabIndex = 45;
            region_ProviderLabel.Text = "Region Provider:";
            // 
            // locality_ProviderLabel
            // 
            locality_ProviderLabel.AutoSize = true;
            locality_ProviderLabel.Location = new System.Drawing.Point(29, 448);
            locality_ProviderLabel.Name = "locality_ProviderLabel";
            locality_ProviderLabel.Size = new System.Drawing.Size(88, 13);
            locality_ProviderLabel.TabIndex = 47;
            locality_ProviderLabel.Text = "Locality Provider:";
            // 
            // street_ProviderLabel
            // 
            street_ProviderLabel.AutoSize = true;
            street_ProviderLabel.Location = new System.Drawing.Point(29, 474);
            street_ProviderLabel.Name = "street_ProviderLabel";
            street_ProviderLabel.Size = new System.Drawing.Size(80, 13);
            street_ProviderLabel.TabIndex = 49;
            street_ProviderLabel.Text = "Street Provider:";
            // 
            // house_ProviderLabel
            // 
            house_ProviderLabel.AutoSize = true;
            house_ProviderLabel.Location = new System.Drawing.Point(29, 500);
            house_ProviderLabel.Name = "house_ProviderLabel";
            house_ProviderLabel.Size = new System.Drawing.Size(83, 13);
            house_ProviderLabel.TabIndex = 51;
            house_ProviderLabel.Text = "House Provider:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(1009, 503);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(310, 292);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(422, 261);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(310, 261);
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
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurshareTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.PurshareTableAdapter = null;
            this.tableAdapterManager.Sell_ManProdTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // providerBindingNavigator
            // 
            this.providerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.providerBindingNavigator.BindingSource = this.providerBindingSource;
            this.providerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.providerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.providerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.providerBindingNavigatorSaveItem});
            this.providerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.providerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.providerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.providerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.providerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.providerBindingNavigator.Name = "providerBindingNavigator";
            this.providerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.providerBindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.providerBindingNavigator.TabIndex = 33;
            this.providerBindingNavigator.Text = "bindingNavigator1";
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
            // providerBindingNavigatorSaveItem
            // 
            this.providerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.providerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("providerBindingNavigatorSaveItem.Image")));
            this.providerBindingNavigatorSaveItem.Name = "providerBindingNavigatorSaveItem";
            this.providerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.providerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.providerBindingNavigatorSaveItem.Click += new System.EventHandler(this.providerBindingNavigatorSaveItem_Click);
            // 
            // providerDataGridView
            // 
            this.providerDataGridView.AutoGenerateColumns = false;
            this.providerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.providerDataGridView.DataSource = this.providerBindingSource;
            this.providerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.providerDataGridView.Name = "providerDataGridView";
            this.providerDataGridView.Size = new System.Drawing.Size(1079, 220);
            this.providerDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Provider";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Provider";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Provider";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Provider";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson_Provider";
            this.dataGridViewTextBoxColumn3.HeaderText = "ContactPerson_Provider";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactPhone_Provider";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContactPhone_Provider";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Index_Provider";
            this.dataGridViewTextBoxColumn5.HeaderText = "Index_Provider";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Country_Provider";
            this.dataGridViewTextBoxColumn6.HeaderText = "Country_Provider";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Region_Provider";
            this.dataGridViewTextBoxColumn7.HeaderText = "Region_Provider";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Locality_Provider";
            this.dataGridViewTextBoxColumn8.HeaderText = "Locality_Provider";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Street_Provider";
            this.dataGridViewTextBoxColumn9.HeaderText = "Street_Provider";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "House_Provider";
            this.dataGridViewTextBoxColumn10.HeaderText = "House_Provider";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // iD_ProviderTextBox
            // 
            this.iD_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "ID_Provider", true));
            this.iD_ProviderTextBox.Location = new System.Drawing.Point(160, 263);
            this.iD_ProviderTextBox.Name = "iD_ProviderTextBox";
            this.iD_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ProviderTextBox.TabIndex = 34;
            // 
            // name_ProviderTextBox
            // 
            this.name_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Name_Provider", true));
            this.name_ProviderTextBox.Location = new System.Drawing.Point(160, 289);
            this.name_ProviderTextBox.Name = "name_ProviderTextBox";
            this.name_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_ProviderTextBox.TabIndex = 36;
            // 
            // contactPerson_ProviderTextBox
            // 
            this.contactPerson_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "ContactPerson_Provider", true));
            this.contactPerson_ProviderTextBox.Location = new System.Drawing.Point(160, 315);
            this.contactPerson_ProviderTextBox.Name = "contactPerson_ProviderTextBox";
            this.contactPerson_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPerson_ProviderTextBox.TabIndex = 38;
            // 
            // contactPhone_ProviderTextBox
            // 
            this.contactPhone_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "ContactPhone_Provider", true));
            this.contactPhone_ProviderTextBox.Location = new System.Drawing.Point(160, 341);
            this.contactPhone_ProviderTextBox.Name = "contactPhone_ProviderTextBox";
            this.contactPhone_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPhone_ProviderTextBox.TabIndex = 40;
            // 
            // index_ProviderTextBox
            // 
            this.index_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Index_Provider", true));
            this.index_ProviderTextBox.Location = new System.Drawing.Point(160, 367);
            this.index_ProviderTextBox.Name = "index_ProviderTextBox";
            this.index_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.index_ProviderTextBox.TabIndex = 42;
            // 
            // country_ProviderTextBox
            // 
            this.country_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Country_Provider", true));
            this.country_ProviderTextBox.Location = new System.Drawing.Point(160, 393);
            this.country_ProviderTextBox.Name = "country_ProviderTextBox";
            this.country_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.country_ProviderTextBox.TabIndex = 44;
            // 
            // region_ProviderTextBox
            // 
            this.region_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Region_Provider", true));
            this.region_ProviderTextBox.Location = new System.Drawing.Point(160, 419);
            this.region_ProviderTextBox.Name = "region_ProviderTextBox";
            this.region_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.region_ProviderTextBox.TabIndex = 46;
            // 
            // locality_ProviderTextBox
            // 
            this.locality_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Locality_Provider", true));
            this.locality_ProviderTextBox.Location = new System.Drawing.Point(160, 445);
            this.locality_ProviderTextBox.Name = "locality_ProviderTextBox";
            this.locality_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.locality_ProviderTextBox.TabIndex = 48;
            // 
            // street_ProviderTextBox
            // 
            this.street_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "Street_Provider", true));
            this.street_ProviderTextBox.Location = new System.Drawing.Point(160, 471);
            this.street_ProviderTextBox.Name = "street_ProviderTextBox";
            this.street_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_ProviderTextBox.TabIndex = 50;
            // 
            // house_ProviderTextBox
            // 
            this.house_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "House_Provider", true));
            this.house_ProviderTextBox.Location = new System.Drawing.Point(160, 497);
            this.house_ProviderTextBox.Name = "house_ProviderTextBox";
            this.house_ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.house_ProviderTextBox.TabIndex = 52;
            // 
            // Form_Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 538);
            this.ControlBox = false;
            this.Controls.Add(iD_ProviderLabel);
            this.Controls.Add(this.iD_ProviderTextBox);
            this.Controls.Add(name_ProviderLabel);
            this.Controls.Add(this.name_ProviderTextBox);
            this.Controls.Add(contactPerson_ProviderLabel);
            this.Controls.Add(this.contactPerson_ProviderTextBox);
            this.Controls.Add(contactPhone_ProviderLabel);
            this.Controls.Add(this.contactPhone_ProviderTextBox);
            this.Controls.Add(index_ProviderLabel);
            this.Controls.Add(this.index_ProviderTextBox);
            this.Controls.Add(country_ProviderLabel);
            this.Controls.Add(this.country_ProviderTextBox);
            this.Controls.Add(region_ProviderLabel);
            this.Controls.Add(this.region_ProviderTextBox);
            this.Controls.Add(locality_ProviderLabel);
            this.Controls.Add(this.locality_ProviderTextBox);
            this.Controls.Add(street_ProviderLabel);
            this.Controls.Add(this.street_ProviderTextBox);
            this.Controls.Add(house_ProviderLabel);
            this.Controls.Add(this.house_ProviderTextBox);
            this.Controls.Add(this.providerDataGridView);
            this.Controls.Add(this.providerBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Provider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Form_Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingNavigator)).EndInit();
            this.providerBindingNavigator.ResumeLayout(false);
            this.providerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private KursovayaDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator providerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton providerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView providerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox iD_ProviderTextBox;
        private System.Windows.Forms.TextBox name_ProviderTextBox;
        private System.Windows.Forms.TextBox contactPerson_ProviderTextBox;
        private System.Windows.Forms.TextBox contactPhone_ProviderTextBox;
        private System.Windows.Forms.TextBox index_ProviderTextBox;
        private System.Windows.Forms.TextBox country_ProviderTextBox;
        private System.Windows.Forms.TextBox region_ProviderTextBox;
        private System.Windows.Forms.TextBox locality_ProviderTextBox;
        private System.Windows.Forms.TextBox street_ProviderTextBox;
        private System.Windows.Forms.TextBox house_ProviderTextBox;
    }
}