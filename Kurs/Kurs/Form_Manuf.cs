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
    public partial class Form_Manuf : Form
    {

        public Form1 ParentForm;
        public Form_Manuf()
        {
            InitializeComponent();
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);

        }

        private void Form_Manuf_Load(object sender, EventArgs e)
        {
            this.manufacturerTableAdapter.Fill(this.kursovayaDataSet.Manufacturer);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                manufacturerBindingNavigatorSaveItem.Enabled = false;
                manufacturerDataGridView.ReadOnly = true;

                iD_ManufacturerTextBox.Enabled = false;
                name_ManufacturerTextBox.Enabled = false;
                contactPerson_ManufacturerTextBox.Enabled = false;
                contactPhone_ManufacturerTextBox.Enabled = false;
                index_ManufacturerTextBox.Enabled = false;
                country_ManufacturerTextBox.Enabled = false;
                region_ManufacturerTextBox.Enabled = false;
                locality_ManufacturerTextBox.Enabled = false;
                street_ManufacturerTextBox.Enabled = false;
                house_ManufacturerTextBox.Enabled = false;
                isDeletedCheckBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            manufacturerBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            manufacturerBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            manufacturerBindingSource.EndEdit();
            manufacturerTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
