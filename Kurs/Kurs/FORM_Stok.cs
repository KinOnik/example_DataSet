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
    public partial class FORM_Stok : Form
    {
        public Form ReturnForm;
        public FORM_Stok()
        {
            InitializeComponent();
        }
        

        private void FORM_Manufact_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.dataSet1.Stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.dataSet1.Stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockBindingSource.EndEdit();
            stockTableAdapter.Update(dataSet1);
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void stockBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
