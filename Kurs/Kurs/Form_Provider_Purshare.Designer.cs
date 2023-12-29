namespace Kurs
{
    partial class Form_Provider_Purshare
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
            System.Windows.Forms.Label position_IDLabel;
            System.Windows.Forms.Label iD_ProviderLabel;
            System.Windows.Forms.Label iD_PurshareLabel;
            System.Windows.Forms.Label man_Prod_IDLabel;
            System.Windows.Forms.Label isDeletedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Provider_Purshare));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.provider_PurshareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provider_PurshareTableAdapter = new Kurs.KursovayaDataSetTableAdapters.Provider_PurshareTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.provider_PurshareBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.provider_PurshareBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.position_IDTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProviderTextBox = new System.Windows.Forms.TextBox();
            this.iD_PurshareTextBox = new System.Windows.Forms.TextBox();
            this.man_Prod_IDTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            this.provider_PurshareDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            position_IDLabel = new System.Windows.Forms.Label();
            iD_ProviderLabel = new System.Windows.Forms.Label();
            iD_PurshareLabel = new System.Windows.Forms.Label();
            man_Prod_IDLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareBindingNavigator)).BeginInit();
            this.provider_PurshareBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // position_IDLabel
            // 
            position_IDLabel.AutoSize = true;
            position_IDLabel.Location = new System.Drawing.Point(29, 273);
            position_IDLabel.Name = "position_IDLabel";
            position_IDLabel.Size = new System.Drawing.Size(61, 13);
            position_IDLabel.TabIndex = 33;
            position_IDLabel.Text = "Position ID:";
            // 
            // iD_ProviderLabel
            // 
            iD_ProviderLabel.AutoSize = true;
            iD_ProviderLabel.Location = new System.Drawing.Point(29, 299);
            iD_ProviderLabel.Name = "iD_ProviderLabel";
            iD_ProviderLabel.Size = new System.Drawing.Size(63, 13);
            iD_ProviderLabel.TabIndex = 35;
            iD_ProviderLabel.Text = "ID Provider:";
            // 
            // iD_PurshareLabel
            // 
            iD_PurshareLabel.AutoSize = true;
            iD_PurshareLabel.Location = new System.Drawing.Point(29, 325);
            iD_PurshareLabel.Name = "iD_PurshareLabel";
            iD_PurshareLabel.Size = new System.Drawing.Size(66, 13);
            iD_PurshareLabel.TabIndex = 37;
            iD_PurshareLabel.Text = "ID Purshare:";
            // 
            // man_Prod_IDLabel
            // 
            man_Prod_IDLabel.AutoSize = true;
            man_Prod_IDLabel.Location = new System.Drawing.Point(29, 351);
            man_Prod_IDLabel.Name = "man_Prod_IDLabel";
            man_Prod_IDLabel.Size = new System.Drawing.Size(70, 13);
            man_Prod_IDLabel.TabIndex = 39;
            man_Prod_IDLabel.Text = "Man Prod ID:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(29, 379);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(58, 13);
            isDeletedLabel.TabIndex = 41;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(525, 369);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(262, 294);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(350, 263);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(262, 263);
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
            // provider_PurshareBindingSource
            // 
            this.provider_PurshareBindingSource.DataMember = "Provider_Purshare";
            this.provider_PurshareBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // provider_PurshareTableAdapter
            // 
            this.provider_PurshareTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_ProductTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Provider_PurshareTableAdapter = this.provider_PurshareTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.PurshareTableAdapter = null;
            this.tableAdapterManager.Sell_ManProdTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // provider_PurshareBindingNavigator
            // 
            this.provider_PurshareBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.provider_PurshareBindingNavigator.BindingSource = this.provider_PurshareBindingSource;
            this.provider_PurshareBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.provider_PurshareBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.provider_PurshareBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.provider_PurshareBindingNavigatorSaveItem});
            this.provider_PurshareBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.provider_PurshareBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.provider_PurshareBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.provider_PurshareBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.provider_PurshareBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.provider_PurshareBindingNavigator.Name = "provider_PurshareBindingNavigator";
            this.provider_PurshareBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.provider_PurshareBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.provider_PurshareBindingNavigator.TabIndex = 33;
            this.provider_PurshareBindingNavigator.Text = "bindingNavigator1";
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
            // provider_PurshareBindingNavigatorSaveItem
            // 
            this.provider_PurshareBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.provider_PurshareBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("provider_PurshareBindingNavigatorSaveItem.Image")));
            this.provider_PurshareBindingNavigatorSaveItem.Name = "provider_PurshareBindingNavigatorSaveItem";
            this.provider_PurshareBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.provider_PurshareBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.provider_PurshareBindingNavigatorSaveItem.Click += new System.EventHandler(this.provider_PurshareBindingNavigatorSaveItem_Click);
            // 
            // position_IDTextBox
            // 
            this.position_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurshareBindingSource, "Position_ID", true));
            this.position_IDTextBox.Location = new System.Drawing.Point(105, 270);
            this.position_IDTextBox.Name = "position_IDTextBox";
            this.position_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.position_IDTextBox.TabIndex = 34;
            // 
            // iD_ProviderTextBox
            // 
            this.iD_ProviderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurshareBindingSource, "ID_Provider", true));
            this.iD_ProviderTextBox.Location = new System.Drawing.Point(105, 296);
            this.iD_ProviderTextBox.Name = "iD_ProviderTextBox";
            this.iD_ProviderTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_ProviderTextBox.TabIndex = 36;
            // 
            // iD_PurshareTextBox
            // 
            this.iD_PurshareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurshareBindingSource, "ID_Purshare", true));
            this.iD_PurshareTextBox.Location = new System.Drawing.Point(105, 322);
            this.iD_PurshareTextBox.Name = "iD_PurshareTextBox";
            this.iD_PurshareTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_PurshareTextBox.TabIndex = 38;
            // 
            // man_Prod_IDTextBox
            // 
            this.man_Prod_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provider_PurshareBindingSource, "Man_Prod_ID", true));
            this.man_Prod_IDTextBox.Location = new System.Drawing.Point(105, 348);
            this.man_Prod_IDTextBox.Name = "man_Prod_IDTextBox";
            this.man_Prod_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.man_Prod_IDTextBox.TabIndex = 40;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.provider_PurshareBindingSource, "IsDeleted", true));
            this.isDeletedCheckBox.Location = new System.Drawing.Point(105, 374);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDeletedCheckBox.TabIndex = 42;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // provider_PurshareDataGridView
            // 
            this.provider_PurshareDataGridView.AutoGenerateColumns = false;
            this.provider_PurshareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_PurshareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.provider_PurshareDataGridView.DataSource = this.provider_PurshareBindingSource;
            this.provider_PurshareDataGridView.Location = new System.Drawing.Point(12, 28);
            this.provider_PurshareDataGridView.Name = "provider_PurshareDataGridView";
            this.provider_PurshareDataGridView.Size = new System.Drawing.Size(588, 220);
            this.provider_PurshareDataGridView.TabIndex = 42;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Purshare";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Purshare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Provider";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Provider";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Position_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Position_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form_Provider_Purshare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 416);
            this.ControlBox = false;
            this.Controls.Add(this.provider_PurshareDataGridView);
            this.Controls.Add(position_IDLabel);
            this.Controls.Add(this.position_IDTextBox);
            this.Controls.Add(iD_ProviderLabel);
            this.Controls.Add(this.iD_ProviderTextBox);
            this.Controls.Add(iD_PurshareLabel);
            this.Controls.Add(this.iD_PurshareTextBox);
            this.Controls.Add(man_Prod_IDLabel);
            this.Controls.Add(this.man_Prod_IDTextBox);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Controls.Add(this.provider_PurshareBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Provider_Purshare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider_Purshare";
            this.Load += new System.EventHandler(this.Form_Provider_Purshare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareBindingNavigator)).EndInit();
            this.provider_PurshareBindingNavigator.ResumeLayout(false);
            this.provider_PurshareBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_PurshareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource provider_PurshareBindingSource;
        private KursovayaDataSetTableAdapters.Provider_PurshareTableAdapter provider_PurshareTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator provider_PurshareBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton provider_PurshareBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox position_IDTextBox;
        private System.Windows.Forms.TextBox iD_ProviderTextBox;
        private System.Windows.Forms.TextBox iD_PurshareTextBox;
        private System.Windows.Forms.TextBox man_Prod_IDTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
        private System.Windows.Forms.DataGridView provider_PurshareDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}