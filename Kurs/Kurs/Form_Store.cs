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
    public partial class Form_Store : Form
    {
        public Form1 ParentForm;
        public Form_Store()
        {
            InitializeComponent();
        }
        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);

        }

        private void Form_Store_Load(object sender, EventArgs e)
        {
            this.storeTableAdapter.Fill(this.kursovayaDataSet.Store);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                storeBindingNavigatorSaveItem.Enabled = false;
                storeDataGridView.ReadOnly = true;

                iD_StoreTextBox.Enabled = false;
                name_StoreTextBox.Enabled = false;
                region_StoreTextBox.Enabled = false;
                locality_StoreTextBox.Enabled = false;
                street_StoreTextBox.Enabled = false;
                house_StoreTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            storeBindingSource.AddNew();
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            storeBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            storeBindingSource.EndEdit();
            storeTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
