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
    public partial class Form_Manuf_Product : Form
    {
        public Form1 ParentForm;
        public Form_Manuf_Product()
        {
            InitializeComponent();
        }
        private void manufacturer_ProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturer_ProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Manuf_Product_Load(object sender, EventArgs e)
        {
            this.manufacturer_ProductTableAdapter.Fill(this.kursovayaDataSet.Manufacturer_Product);

            if(ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                manufacturer_ProductBindingNavigatorSaveItem.Enabled = false;
                manufacturer_ProductDataGridView.ReadOnly = true;

                man_Prod_IDTextBox.Enabled = false;
                iD_ProductTextBox.Enabled = false;
                iD_ManufacturerTextBox.Enabled = false;
                isDeletedCheckBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            manufacturer_ProductBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            manufacturer_ProductBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            manufacturer_ProductBindingSource.EndEdit();
            manufacturer_ProductTableAdapter.Update(kursovayaDataSet);
        }
        private void Button_EXIT_Click(object sender, EventArgs e)
        {

            ParentForm.Show();
            this.Close();
        }
    }
}
