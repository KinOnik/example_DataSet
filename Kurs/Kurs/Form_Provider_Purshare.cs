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
    public partial class Form_Provider_Purshare : Form
    {
        public Form1 ParentForm;
        public Form_Provider_Purshare()
        {
            InitializeComponent();
        }

        private void provider_PurshareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provider_PurshareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Provider_Purshare_Load(object sender, EventArgs e)
        {
            this.provider_PurshareTableAdapter.Fill(this.kursovayaDataSet.Provider_Purshare);

            if(ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                provider_PurshareBindingNavigatorSaveItem.Enabled = false;
                provider_PurshareDataGridView.ReadOnly = true;

                position_IDTextBox.Enabled = false;
                iD_ProviderTextBox.Enabled = false;
                iD_PurshareTextBox.Enabled = false;
                man_Prod_IDTextBox.Enabled = false;
                isDeletedCheckBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            provider_PurshareBindingSource.AddNew();
        }
        private void Button_DEL_Click(object sender, EventArgs e)
        {
            provider_PurshareBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            provider_PurshareBindingSource.EndEdit();
            provider_PurshareTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {

            ParentForm.Show();
            this.Close();
        }
    }
}
