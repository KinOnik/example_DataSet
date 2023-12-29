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
    public partial class Form_Sell_ManProd : Form
    {
        public Form1 ParentForm;
        public Form_Sell_ManProd()
        {
            InitializeComponent();
        }

        private void sell_ManProdBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sell_ManProdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Sell_ManProd_Load(object sender, EventArgs e)
        {
            this.sell_ManProdTableAdapter.Fill(this.kursovayaDataSet.Sell_ManProd);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                sell_ManProdBindingNavigatorSaveItem.Enabled = false;
                sell_ManProdDataGridView.ReadOnly = true;

                number_IDTextBox.Enabled = false;
                iD_SellTextBox.Enabled = false;
                man_Prod_IDTextBox.Enabled = false;
                isDeletedCheckBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            sell_ManProdBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            sell_ManProdBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            sell_ManProdBindingSource.EndEdit();
            sell_ManProdTableAdapter.Update(kursovayaDataSet);
        }
        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
