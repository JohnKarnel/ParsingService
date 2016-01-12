namespace ParserClient
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_Parse = new System.Windows.Forms.Button();
            this.dgv_ExchangeRate = new System.Windows.Forms.DataGridView();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eurBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eurSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Parse
            // 
            this.btn_Parse.Location = new System.Drawing.Point(658, 12);
            this.btn_Parse.Name = "btn_Parse";
            this.btn_Parse.Size = new System.Drawing.Size(101, 36);
            this.btn_Parse.TabIndex = 0;
            this.btn_Parse.Text = "Вывести курсы валют";
            this.btn_Parse.UseVisualStyleBackColor = true;
            this.btn_Parse.Click += new System.EventHandler(this.btn_Parse_Click);
            // 
            // dgv_ExchangeRate
            // 
            this.dgv_ExchangeRate.AllowUserToAddRows = false;
            this.dgv_ExchangeRate.AllowUserToDeleteRows = false;
            this.dgv_ExchangeRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExchangeRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankName,
            this.usdBuy,
            this.usdSale,
            this.eurBuy,
            this.eurSale,
            this.rubBuy,
            this.rubSale});
            this.dgv_ExchangeRate.Location = new System.Drawing.Point(12, 12);
            this.dgv_ExchangeRate.Name = "dgv_ExchangeRate";
            this.dgv_ExchangeRate.ReadOnly = true;
            this.dgv_ExchangeRate.RowHeadersVisible = false;
            this.dgv_ExchangeRate.Size = new System.Drawing.Size(623, 322);
            this.dgv_ExchangeRate.TabIndex = 1;
            // 
            // bankName
            // 
            this.bankName.HeaderText = "Банк";
            this.bankName.Name = "bankName";
            this.bankName.ReadOnly = true;
            this.bankName.Width = 200;
            // 
            // usdBuy
            // 
            this.usdBuy.HeaderText = "USD Покупка";
            this.usdBuy.Name = "usdBuy";
            this.usdBuy.ReadOnly = true;
            this.usdBuy.Width = 70;
            // 
            // usdSale
            // 
            this.usdSale.HeaderText = "USD Продажа";
            this.usdSale.Name = "usdSale";
            this.usdSale.ReadOnly = true;
            this.usdSale.Width = 70;
            // 
            // eurBuy
            // 
            this.eurBuy.HeaderText = "EUR Покупка";
            this.eurBuy.Name = "eurBuy";
            this.eurBuy.ReadOnly = true;
            this.eurBuy.Width = 70;
            // 
            // eurSale
            // 
            this.eurSale.HeaderText = "EUR Продажа";
            this.eurSale.Name = "eurSale";
            this.eurSale.ReadOnly = true;
            this.eurSale.Width = 70;
            // 
            // rubBuy
            // 
            this.rubBuy.HeaderText = "RUB Покупка";
            this.rubBuy.Name = "rubBuy";
            this.rubBuy.ReadOnly = true;
            this.rubBuy.Width = 70;
            // 
            // rubSale
            // 
            this.rubSale.HeaderText = "RUB Продажа";
            this.rubSale.Name = "rubSale";
            this.rubSale.ReadOnly = true;
            this.rubSale.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 362);
            this.Controls.Add(this.dgv_ExchangeRate);
            this.Controls.Add(this.btn_Parse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(790, 1000);
            this.MinimumSize = new System.Drawing.Size(790, 400);
            this.Name = "FormMain";
            this.Text = "Курсы валют";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExchangeRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Parse;
        private System.Windows.Forms.DataGridView dgv_ExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn eurBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn eurSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubSale;
    }
}

