namespace Kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenManuf = new System.Windows.Forms.Button();
            this.OpenStore = new System.Windows.Forms.Button();
            this.OpenManufProd = new System.Windows.Forms.Button();
            this.OpenProduct = new System.Windows.Forms.Button();
            this.OpenProvider = new System.Windows.Forms.Button();
            this.OpenProvPursh = new System.Windows.Forms.Button();
            this.OpenPurshare = new System.Windows.Forms.Button();
            this.OpenSell = new System.Windows.Forms.Button();
            this.OpenStock = new System.Windows.Forms.Button();
            this.OpenSellManProd = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ChangeLogin = new System.Windows.Forms.Button();
            this.CurrentUser = new System.Windows.Forms.Label();
            this.Text_CurUser = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenManuf
            // 
            this.OpenManuf.Location = new System.Drawing.Point(12, 135);
            this.OpenManuf.Name = "OpenManuf";
            this.OpenManuf.Size = new System.Drawing.Size(123, 34);
            this.OpenManuf.TabIndex = 0;
            this.OpenManuf.Text = "MANUFACTURER";
            this.OpenManuf.UseVisualStyleBackColor = true;
            this.OpenManuf.Click += new System.EventHandler(this.OpenManuf_Click);
            // 
            // OpenStore
            // 
            this.OpenStore.Location = new System.Drawing.Point(141, 135);
            this.OpenStore.Name = "OpenStore";
            this.OpenStore.Size = new System.Drawing.Size(67, 34);
            this.OpenStore.TabIndex = 1;
            this.OpenStore.Text = "STORE";
            this.OpenStore.UseVisualStyleBackColor = true;
            this.OpenStore.Click += new System.EventHandler(this.OpenStore_Click);
            // 
            // OpenManufProd
            // 
            this.OpenManufProd.Location = new System.Drawing.Point(12, 194);
            this.OpenManufProd.Name = "OpenManufProd";
            this.OpenManufProd.Size = new System.Drawing.Size(178, 34);
            this.OpenManufProd.TabIndex = 7;
            this.OpenManufProd.Text = "MANUFACTURER-PRODUCT";
            this.OpenManufProd.UseVisualStyleBackColor = true;
            this.OpenManufProd.Click += new System.EventHandler(this.OpenManufProd_Click);
            // 
            // OpenProduct
            // 
            this.OpenProduct.Location = new System.Drawing.Point(214, 135);
            this.OpenProduct.Name = "OpenProduct";
            this.OpenProduct.Size = new System.Drawing.Size(75, 34);
            this.OpenProduct.TabIndex = 2;
            this.OpenProduct.Text = "Product";
            this.OpenProduct.UseVisualStyleBackColor = true;
            this.OpenProduct.Click += new System.EventHandler(this.OpenProduct_Click);
            // 
            // OpenProvider
            // 
            this.OpenProvider.Location = new System.Drawing.Point(295, 135);
            this.OpenProvider.Name = "OpenProvider";
            this.OpenProvider.Size = new System.Drawing.Size(75, 34);
            this.OpenProvider.TabIndex = 3;
            this.OpenProvider.Text = "Provider";
            this.OpenProvider.UseVisualStyleBackColor = true;
            this.OpenProvider.Click += new System.EventHandler(this.OpenProvider_Click);
            // 
            // OpenProvPursh
            // 
            this.OpenProvPursh.Location = new System.Drawing.Point(196, 194);
            this.OpenProvPursh.Name = "OpenProvPursh";
            this.OpenProvPursh.Size = new System.Drawing.Size(141, 34);
            this.OpenProvPursh.TabIndex = 8;
            this.OpenProvPursh.Text = "PROVIDER-PURSHARE";
            this.OpenProvPursh.UseVisualStyleBackColor = true;
            this.OpenProvPursh.Click += new System.EventHandler(this.OpenProvPursh_Click);
            // 
            // OpenPurshare
            // 
            this.OpenPurshare.Location = new System.Drawing.Point(376, 135);
            this.OpenPurshare.Name = "OpenPurshare";
            this.OpenPurshare.Size = new System.Drawing.Size(84, 34);
            this.OpenPurshare.TabIndex = 4;
            this.OpenPurshare.Text = "PURSHARE";
            this.OpenPurshare.UseVisualStyleBackColor = true;
            this.OpenPurshare.Click += new System.EventHandler(this.OpenPurshare_Click);
            // 
            // OpenSell
            // 
            this.OpenSell.Location = new System.Drawing.Point(466, 135);
            this.OpenSell.Name = "OpenSell";
            this.OpenSell.Size = new System.Drawing.Size(75, 34);
            this.OpenSell.TabIndex = 5;
            this.OpenSell.Text = "SELL";
            this.OpenSell.UseVisualStyleBackColor = true;
            this.OpenSell.Click += new System.EventHandler(this.OpenSell_Click);
            // 
            // OpenStock
            // 
            this.OpenStock.Location = new System.Drawing.Point(547, 135);
            this.OpenStock.Name = "OpenStock";
            this.OpenStock.Size = new System.Drawing.Size(75, 34);
            this.OpenStock.TabIndex = 6;
            this.OpenStock.Text = "STOCK";
            this.OpenStock.UseVisualStyleBackColor = true;
            this.OpenStock.Click += new System.EventHandler(this.OpenStock_Click);
            // 
            // OpenSellManProd
            // 
            this.OpenSellManProd.Location = new System.Drawing.Point(343, 194);
            this.OpenSellManProd.Name = "OpenSellManProd";
            this.OpenSellManProd.Size = new System.Drawing.Size(103, 34);
            this.OpenSellManProd.TabIndex = 9;
            this.OpenSellManProd.Text = "SELL-ManProd";
            this.OpenSellManProd.UseVisualStyleBackColor = true;
            this.OpenSellManProd.Click += new System.EventHandler(this.OpenSellManProd_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(565, 237);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 27);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(277, 116);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = " Курсовая работа \n студента группы ПКсп-119\n Калинина Андрея Алексеевича\n\n Тема: " +
    "\"Охотничий магазин\"";
            // 
            // ChangeLogin
            // 
            this.ChangeLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLogin.Location = new System.Drawing.Point(510, 69);
            this.ChangeLogin.Name = "ChangeLogin";
            this.ChangeLogin.Size = new System.Drawing.Size(112, 42);
            this.ChangeLogin.TabIndex = 10;
            this.ChangeLogin.Text = "Сменить пользователя";
            this.ChangeLogin.UseVisualStyleBackColor = true;
            this.ChangeLogin.Click += new System.EventHandler(this.ChangeLogin_Click);
            // 
            // CurrentUser
            // 
            this.CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentUser.AutoSize = true;
            this.CurrentUser.Location = new System.Drawing.Point(493, 9);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.Size = new System.Drawing.Size(129, 13);
            this.CurrentUser.TabIndex = 12;
            this.CurrentUser.Text = "Текущий пользователь:";
            this.CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Text_CurUser
            // 
            this.Text_CurUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_CurUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_CurUser.Location = new System.Drawing.Point(476, 37);
            this.Text_CurUser.Name = "Text_CurUser";
            this.Text_CurUser.ReadOnly = true;
            this.Text_CurUser.Size = new System.Drawing.Size(146, 26);
            this.Text_CurUser.TabIndex = 11;
            this.Text_CurUser.Text = "UNKNOWN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 276);
            this.ControlBox = false;
            this.Controls.Add(this.CurrentUser);
            this.Controls.Add(this.Text_CurUser);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChangeLogin);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OpenSellManProd);
            this.Controls.Add(this.OpenStock);
            this.Controls.Add(this.OpenSell);
            this.Controls.Add(this.OpenPurshare);
            this.Controls.Add(this.OpenProvPursh);
            this.Controls.Add(this.OpenProvider);
            this.Controls.Add(this.OpenProduct);
            this.Controls.Add(this.OpenManufProd);
            this.Controls.Add(this.OpenStore);
            this.Controls.Add(this.OpenManuf);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа - Охотничий магазин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenManuf;
        private System.Windows.Forms.Button OpenStore;
        private System.Windows.Forms.Button OpenManufProd;
        private System.Windows.Forms.Button OpenProduct;
        private System.Windows.Forms.Button OpenProvider;
        private System.Windows.Forms.Button OpenProvPursh;
        private System.Windows.Forms.Button OpenPurshare;
        private System.Windows.Forms.Button OpenSell;
        private System.Windows.Forms.Button OpenStock;
        private System.Windows.Forms.Button OpenSellManProd;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ChangeLogin;
        private System.Windows.Forms.Label CurrentUser;
        private System.Windows.Forms.RichTextBox Text_CurUser;
    }
}

