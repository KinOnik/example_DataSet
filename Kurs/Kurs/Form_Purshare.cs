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
    public partial class Form_Purshare : Form
    {
        public Form1 ParentForm;
        public Form_Purshare()
        {
            InitializeComponent();
        }

        private void purshareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purshareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovayaDataSet);
        }

        private void Form_Purshare_Load(object sender, EventArgs e)
        {
            this.purshareTableAdapter.Fill(this.kursovayaDataSet.Purshare);

            if (ParentForm.ThisStandartUser())
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                purshareBindingNavigatorSaveItem.Enabled = false;
                purshareDataGridView.ReadOnly = true;

                iD_PurshareTextBox.Enabled = false;
                numberOrder_PurshareTextBox.Enabled = false;
                methodDeliverily_PurshareTextBox.Enabled = false;
                companyDeliverily_PurshareTextBox.Enabled = false;

                Button_ADD.Enabled = false;
                Button_DEL.Enabled = false;
                Button_SAVE.Enabled = false;
            }
        }


        private void Button_ADD_Click(object sender, EventArgs e)
        {
            purshareBindingSource.AddNew();
        }
        private void Button_DEL_Click(object sender, EventArgs e)
        {
            purshareBindingSource.RemoveCurrent();
        }

        private void Button_SAVE_Click(object sender, EventArgs e)
        {
            purshareBindingSource.EndEdit();
            purshareTableAdapter.Update(kursovayaDataSet);
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            ParentForm.Show();
            this.Close();
        }
    }
}
