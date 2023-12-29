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
    public partial class Form_Sell : Form
    {
        public Form1 ParentForm;
        public Form_Sell()
        {
            InitializeComponent();
        }

        private void sellBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Sell_Load(object sender, EventArgs e)
        {
            this.sellTableAdapter.Fill(this.kursovayaDataSet.Sell);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                sellBindingNavigatorSaveItem.Enabled = false;
                sellDataGridView.ReadOnly = true;

                iD_SellTextBox.Enabled = false;
                price_SellTextBox.Enabled = false;
                countProduct_SellTextBox.Enabled = false;
                iD_StoreTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            sellBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            sellBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            sellBindingSource.EndEdit();
            sellTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
