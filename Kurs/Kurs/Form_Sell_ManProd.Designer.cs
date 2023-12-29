namespace Kurs
{
    partial class Form_Sell_ManProd
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
            System.Windows.Forms.Label number_IDLabel;
            System.Windows.Forms.Label iD_SellLabel;
            System.Windows.Forms.Label man_Prod_IDLabel;
            System.Windows.Forms.Label isDeletedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sell_ManProd));
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_SAVE = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.kursovayaDataSet = new Kurs.KursovayaDataSet();
            this.sell_ManProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sell_ManProdTableAdapter = new Kurs.KursovayaDataSetTableAdapters.Sell_ManProdTableAdapter();
            this.tableAdapterManager = new Kurs.KursovayaDataSetTableAdapters.TableAdapterManager();
            this.sell_ManProdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sell_ManProdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sell_ManProdDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.number_IDTextBox = new System.Windows.Forms.TextBox();
            this.iD_SellTextBox = new System.Windows.Forms.TextBox();
            this.man_Prod_IDTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            number_IDLabel = new System.Windows.Forms.Label();
            iD_SellLabel = new System.Windows.Forms.Label();
            man_Prod_IDLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdBindingNavigator)).BeginInit();
            this.sell_ManProdBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // number_IDLabel
            // 
            number_IDLabel.AutoSize = true;
            number_IDLabel.Location = new System.Drawing.Point(34, 270);
            number_IDLabel.Name = "number_IDLabel";
            number_IDLabel.Size = new System.Drawing.Size(61, 13);
            number_IDLabel.TabIndex = 33;
            number_IDLabel.Text = "Number ID:";
            // 
            // iD_SellLabel
            // 
            iD_SellLabel.AutoSize = true;
            iD_SellLabel.Location = new System.Drawing.Point(34, 296);
            iD_SellLabel.Name = "iD_SellLabel";
            iD_SellLabel.Size = new System.Drawing.Size(41, 13);
            iD_SellLabel.TabIndex = 35;
            iD_SellLabel.Text = "ID Sell:";
            // 
            // man_Prod_IDLabel
            // 
            man_Prod_IDLabel.AutoSize = true;
            man_Prod_IDLabel.Location = new System.Drawing.Point(34, 322);
            man_Prod_IDLabel.Name = "man_Prod_IDLabel";
            man_Prod_IDLabel.Size = new System.Drawing.Size(70, 13);
            man_Prod_IDLabel.TabIndex = 37;
            man_Prod_IDLabel.Text = "Man Prod ID:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(34, 350);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(58, 13);
            isDeletedLabel.TabIndex = 39;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(428, 345);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(82, 23);
            this.Button_EXIT.TabIndex = 29;
            this.Button_EXIT.Text = "Выйти";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_SAVE
            // 
            this.Button_SAVE.Location = new System.Drawing.Point(250, 299);
            this.Button_SAVE.Name = "Button_SAVE";
            this.Button_SAVE.Size = new System.Drawing.Size(82, 23);
            this.Button_SAVE.TabIndex = 30;
            this.Button_SAVE.Text = "СОХРАНИТЬ";
            this.Button_SAVE.UseVisualStyleBackColor = true;
            this.Button_SAVE.Click += new System.EventHandler(this.Button_SAVE_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(338, 270);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(82, 23);
            this.Button_DEL.TabIndex = 31;
            this.Button_DEL.Text = "УДАЛИТЬ";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(250, 270);
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
            // sell_ManProdBindingSource
            // 
            this.sell_ManProdBindingSource.DataMember = "Sell_ManProd";
            this.sell_ManProdBindingSource.DataSource = this.kursovayaDataSet;
            // 
            // sell_ManProdTableAdapter
            // 
            this.sell_ManProdTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Sell_ManProdTableAdapter = this.sell_ManProdTableAdapter;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovayaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sell_ManProdBindingNavigator
            // 
            this.sell_ManProdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sell_ManProdBindingNavigator.BindingSource = this.sell_ManProdBindingSource;
            this.sell_ManProdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sell_ManProdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sell_ManProdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sell_ManProdBindingNavigatorSaveItem});
            this.sell_ManProdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sell_ManProdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sell_ManProdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sell_ManProdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sell_ManProdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sell_ManProdBindingNavigator.Name = "sell_ManProdBindingNavigator";
            this.sell_ManProdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sell_ManProdBindingNavigator.Size = new System.Drawing.Size(515, 25);
            this.sell_ManProdBindingNavigator.TabIndex = 33;
            this.sell_ManProdBindingNavigator.Text = "bindingNavigator1";
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
            // sell_ManProdBindingNavigatorSaveItem
            // 
            this.sell_ManProdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sell_ManProdBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sell_ManProdBindingNavigatorSaveItem.Image")));
            this.sell_ManProdBindingNavigatorSaveItem.Name = "sell_ManProdBindingNavigatorSaveItem";
            this.sell_ManProdBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sell_ManProdBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sell_ManProdBindingNavigatorSaveItem.Click += new System.EventHandler(this.sell_ManProdBindingNavigatorSaveItem_Click);
            // 
            // sell_ManProdDataGridView
            // 
            this.sell_ManProdDataGridView.AutoGenerateColumns = false;
            this.sell_ManProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sell_ManProdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.sell_ManProdDataGridView.DataSource = this.sell_ManProdBindingSource;
            this.sell_ManProdDataGridView.Location = new System.Drawing.Point(24, 34);
            this.sell_ManProdDataGridView.Name = "sell_ManProdDataGridView";
            this.sell_ManProdDataGridView.Size = new System.Drawing.Size(479, 220);
            this.sell_ManProdDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Number_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Number_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Sell";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Sell";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Man_Prod_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // number_IDTextBox
            // 
            this.number_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sell_ManProdBindingSource, "Number_ID", true));
            this.number_IDTextBox.Location = new System.Drawing.Point(110, 267);
            this.number_IDTextBox.Name = "number_IDTextBox";
            this.number_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.number_IDTextBox.TabIndex = 34;
            // 
            // iD_SellTextBox
            // 
            this.iD_SellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sell_ManProdBindingSource, "ID_Sell", true));
            this.iD_SellTextBox.Location = new System.Drawing.Point(110, 293);
            this.iD_SellTextBox.Name = "iD_SellTextBox";
            this.iD_SellTextBox.Size = new System.Drawing.Size(104, 20);
            this.iD_SellTextBox.TabIndex = 36;
            // 
            // man_Prod_IDTextBox
            // 
            this.man_Prod_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sell_ManProdBindingSource, "Man_Prod_ID", true));
            this.man_Prod_IDTextBox.Location = new System.Drawing.Point(110, 319);
            this.man_Prod_IDTextBox.Name = "man_Prod_IDTextBox";
            this.man_Prod_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.man_Prod_IDTextBox.TabIndex = 38;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sell_ManProdBindingSource, "IsDeleted", true));
            this.isDeletedCheckBox.Location = new System.Drawing.Point(110, 345);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDeletedCheckBox.TabIndex = 40;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form_Sell_ManProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 381);
            this.ControlBox = false;
            this.Controls.Add(number_IDLabel);
            this.Controls.Add(this.number_IDTextBox);
            this.Controls.Add(iD_SellLabel);
            this.Controls.Add(this.iD_SellTextBox);
            this.Controls.Add(man_Prod_IDLabel);
            this.Controls.Add(this.man_Prod_IDTextBox);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Controls.Add(this.sell_ManProdDataGridView);
            this.Controls.Add(this.sell_ManProdBindingNavigator);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_SAVE);
            this.Controls.Add(this.Button_DEL);
            this.Controls.Add(this.Button_ADD);
            this.Name = "Form_Sell_ManProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell_ManProd";
            this.Load += new System.EventHandler(this.Form_Sell_ManProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdBindingNavigator)).EndInit();
            this.sell_ManProdBindingNavigator.ResumeLayout(false);
            this.sell_ManProdBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sell_ManProdDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_SAVE;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_ADD;
        private KursovayaDataSet kursovayaDataSet;
        private System.Windows.Forms.BindingSource sell_ManProdBindingSource;
        private KursovayaDataSetTableAdapters.Sell_ManProdTableAdapter sell_ManProdTableAdapter;
        private KursovayaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sell_ManProdBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sell_ManProdBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sell_ManProdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox number_IDTextBox;
        private System.Windows.Forms.TextBox iD_SellTextBox;
        private System.Windows.Forms.TextBox man_Prod_IDTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
    }
}