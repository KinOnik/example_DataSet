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
    public partial class Form_Product : Form
    {
        public Form1 ParentForm;
        public Form_Product()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.kursovayaDataSet.Product);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                productBindingNavigatorSaveItem.Enabled = false;
                productDataGridView.ReadOnly = true;

                iD_ProductTextBox.Enabled = false;
                name_ProductTextBox.Enabled = false;
                mainColor_ProductTextBox.Enabled = false;
                secondColor_ProductTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            productTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
