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
    public partial class Form_Provider : Form
    {
        public Form1 ParentForm;
        public Form_Provider()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Provider_Load(object sender, EventArgs e)
        {
            this.providerTableAdapter.Fill(this.kursovayaDataSet.Provider);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                providerBindingNavigatorSaveItem.Enabled = false;
                providerDataGridView.ReadOnly = true;

                iD_ProviderTextBox.Enabled = false;
                name_ProviderTextBox.Enabled = false;
                contactPerson_ProviderTextBox.Enabled = false;
                contactPhone_ProviderTextBox.Enabled = false;
                index_ProviderTextBox.Enabled = false;
                country_ProviderTextBox.Enabled = false;
                region_ProviderTextBox.Enabled = false;
                locality_ProviderTextBox.Enabled = false;
                street_ProviderTextBox.Enabled = false;
                house_ProviderTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            providerBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            providerBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            providerBindingSource.EndEdit();
            providerTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
