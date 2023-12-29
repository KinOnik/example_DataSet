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
    public partial class Form1 : Form
    {
        public StringBuilder LoginUser = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        public void SetLogin(string CurLogin)
        {
            LoginUser.Clear();
            LoginUser.Append(CurLogin);
            Text_CurUser.Text = CurLogin;
        }

        public bool ThisStandartUser()
        {
            if (LoginUser.ToString() == "Users")
            {
                return true;
            }           
            return false;
        }

        public bool ThisAdministrator()
        {
            if (LoginUser.ToString() == "Admin")
            {
                return true;
            }
            return false;
        }

        private void ChangeLogin_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new LogIn() { ParentForm = this }.ShowDialog();
        }

        private void OpenManuf_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Manuf() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenStore_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Store() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenManufProd_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Manuf_Product() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenProduct_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Product() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenProvider_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Provider() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenPurshare_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Purshare() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenSell_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Sell() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenStock_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Stock() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenProvPursh_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Provider_Purshare() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void OpenSellManProd_Click(object sender, EventArgs e)
        {
            if (ThisStandartUser() || ThisAdministrator())
            {
                this.Hide();
                new Form_Sell_ManProd() { ParentForm = this }.Show();
            }
            else
            {
                MessageBox.Show(
                    "Вы не вошли в учетную запись.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLogin_Click(sender,e);
        }
    }
}
