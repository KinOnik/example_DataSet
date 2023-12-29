using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form_Stock : Form
    {
        public Form1 ParentForm;
        public Form_Stock()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Stock_Load(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(this.kursovayaDataSet.Stock);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                stockBindingNavigatorSaveItem.Enabled = false;
                stockDataGridView.ReadOnly = true;

                iD_StockTextBox.Enabled = false;
                name_StockTextBox.Enabled = false;
                region_StockTextBox.Enabled = false;
                locality_StockTextBox.Enabled = false;
                street_StockTextBox.Enabled = false;
                house_StockTextBox.Enabled = false;
                salePrice_StockTextBox.Enabled = false;
                countProduct_StockTextBox.Enabled = false;
                iD_ProductTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            stockBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            stockBindingSource.EndEdit();
            stockTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
