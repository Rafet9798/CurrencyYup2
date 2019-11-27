namespace CurrencyYup2
{
    partial class Form1
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
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.cmbInputCurrency = new System.Windows.Forms.ComboBox();
            this.lstOutputCurrencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtInputValue
            // 
            this.txtInputValue.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputValue.Location = new System.Drawing.Point(42, 49);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(306, 36);
            this.txtInputValue.TabIndex = 0;
            this.txtInputValue.Text = "0";
            // 
            // cmbInputCurrency
            // 
            this.cmbInputCurrency.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInputCurrency.FormattingEnabled = true;
            this.cmbInputCurrency.Location = new System.Drawing.Point(42, 92);
            this.cmbInputCurrency.Name = "cmbInputCurrency";
            this.cmbInputCurrency.Size = new System.Drawing.Size(306, 35);
            this.cmbInputCurrency.TabIndex = 1;
            this.cmbInputCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbInputCurrency_SelectedIndexChanged);
            // 
            // lstOutputCurrencies
            // 
            this.lstOutputCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstOutputCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutputCurrencies.FullRowSelect = true;
            this.lstOutputCurrencies.HideSelection = false;
            this.lstOutputCurrencies.Location = new System.Drawing.Point(42, 182);
            this.lstOutputCurrencies.Name = "lstOutputCurrencies";
            this.lstOutputCurrencies.Size = new System.Drawing.Size(306, 301);
            this.lstOutputCurrencies.TabIndex = 2;
            this.lstOutputCurrencies.UseCompatibleStateImageBehavior = false;
            this.lstOutputCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Currency";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 151;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 537);
            this.Controls.Add(this.lstOutputCurrencies);
            this.Controls.Add(this.cmbInputCurrency);
            this.Controls.Add(this.txtInputValue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.ComboBox cmbInputCurrency;
        private System.Windows.Forms.ListView lstOutputCurrencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

