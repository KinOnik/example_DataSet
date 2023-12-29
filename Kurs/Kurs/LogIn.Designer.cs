namespace Kurs
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.AutoAdmin = new System.Windows.Forms.Button();
            this.AutoUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextPass = new System.Windows.Forms.TextBox();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(114, 119);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(81, 23);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Продолжить";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(35, 119);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AutoAdmin
            // 
            this.AutoAdmin.Location = new System.Drawing.Point(270, 25);
            this.AutoAdmin.Name = "AutoAdmin";
            this.AutoAdmin.Size = new System.Drawing.Size(96, 23);
            this.AutoAdmin.TabIndex = 4;
            this.AutoAdmin.Text = "Администратор";
            this.AutoAdmin.UseVisualStyleBackColor = true;
            this.AutoAdmin.Click += new System.EventHandler(this.AutoAdmin_Click);
            // 
            // AutoUser
            // 
            this.AutoUser.Location = new System.Drawing.Point(270, 54);
            this.AutoUser.Name = "AutoUser";
            this.AutoUser.Size = new System.Drawing.Size(96, 23);
            this.AutoUser.TabIndex = 4;
            this.AutoUser.Text = "Пользователь";
            this.AutoUser.UseVisualStyleBackColor = true;
            this.AutoUser.Click += new System.EventHandler(this.AutoUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автозаполнение:";
            // 
            // TextPass
            // 
            this.TextPass.Location = new System.Drawing.Point(43, 82);
            this.TextPass.Name = "TextPass";
            this.TextPass.PasswordChar = '*';
            this.TextPass.Size = new System.Drawing.Size(139, 20);
            this.TextPass.TabIndex = 6;
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(43, 25);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(139, 20);
            this.TextLogin.TabIndex = 6;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 156);
            this.ControlBox = false;
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.TextPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutoUser);
            this.Controls.Add(this.AutoAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.MaximumSize = new System.Drawing.Size(389, 195);
            this.MinimumSize = new System.Drawing.Size(389, 195);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AutoAdmin;
        private System.Windows.Forms.Button AutoUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextPass;
        private System.Windows.Forms.TextBox TextLogin;
    }
}