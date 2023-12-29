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
    public partial class LogIn : Form
    {

        public Form1 ParentForm;

        public LogIn()
        {
            InitializeComponent();
            
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (TextLogin.Text == "MyUsers")
            {
                if (TextPass.Text == "PassForUsers")
                {
                    ParentForm.SetLogin("Users");
                    this.Close();
                    ParentForm.Enabled = true;
                }
                else
                {
                    MessageBox.Show(
                       "Неверный пароль.",
                       "Внимание!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button3);
                }
            }
            else
            if (TextLogin.Text == "MyAdmin")
            {
                if (TextPass.Text == "PassForAdmin")
                {
                    ParentForm.SetLogin("Admin");
                    this.Close();
                    ParentForm.Enabled = true;
                }
                else
                {
                    MessageBox.Show(
                       "Неверный пароль.",
                       "Внимание!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button3);
                }
            }
            else
            {
                MessageBox.Show(
                      "Неверный логин.",
                      "Внимание!",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Enabled = true;
        }

        private void AutoAdmin_Click(object sender, EventArgs e)
        {
            TextLogin.Text = "MyAdmin";
            TextPass.Text = "PassForAdmin";
        }

        private void AutoUser_Click(object sender, EventArgs e)
        {
            TextLogin.Text = "MyUsers";
            TextPass.Text = "PassForUsers";
        }
    }
}
