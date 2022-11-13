namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class InvoiceForm
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
            this.InvoiceListbox = new System.Windows.Forms.ListBox();
            this.ShowInvoiceBox = new System.Windows.Forms.ComboBox();
            this.InvoiceIDLabel = new System.Windows.Forms.Label();
            this.InvoiceIssueLabel = new System.Windows.Forms.Label();
            this.InvoiceExpireLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerMailLabel = new System.Windows.Forms.Label();
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.InvoiceIsPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.UppdateInvoiceButton = new System.Windows.Forms.Button();
            this.ShowInvoicesLabel = new System.Windows.Forms.Label();
            this.ListboxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InvoiceListbox
            // 
            this.InvoiceListbox.FormattingEnabled = true;
            this.InvoiceListbox.Location = new System.Drawing.Point(12, 44);
            this.InvoiceListbox.Name = "InvoiceListbox";
            this.InvoiceListbox.Size = new System.Drawing.Size(124, 394);
            this.InvoiceListbox.TabIndex = 0;
            this.InvoiceListbox.DoubleClick += new System.EventHandler(this.InvoiceListbox_DoubleClick);
            // 
            // ShowInvoiceBox
            // 
            this.ShowInvoiceBox.FormattingEnabled = true;
            this.ShowInvoiceBox.Location = new System.Drawing.Point(161, 37);
            this.ShowInvoiceBox.Name = "ShowInvoiceBox";
            this.ShowInvoiceBox.Size = new System.Drawing.Size(121, 21);
            this.ShowInvoiceBox.TabIndex = 1;
            this.ShowInvoiceBox.TextChanged += new System.EventHandler(this.ShowInvoiceBox_TextChanged);
            // 
            // InvoiceIDLabel
            // 
            this.InvoiceIDLabel.AutoSize = true;
            this.InvoiceIDLabel.Location = new System.Drawing.Point(158, 93);
            this.InvoiceIDLabel.Name = "InvoiceIDLabel";
            this.InvoiceIDLabel.Size = new System.Drawing.Size(86, 13);
            this.InvoiceIDLabel.TabIndex = 2;
            this.InvoiceIDLabel.Text = "Fakturanummer :";
            // 
            // InvoiceIssueLabel
            // 
            this.InvoiceIssueLabel.AutoSize = true;
            this.InvoiceIssueLabel.Location = new System.Drawing.Point(158, 117);
            this.InvoiceIssueLabel.Name = "InvoiceIssueLabel";
            this.InvoiceIssueLabel.Size = new System.Drawing.Size(78, 13);
            this.InvoiceIssueLabel.TabIndex = 3;
            this.InvoiceIssueLabel.Text = "Fakturadatum :";
            // 
            // InvoiceExpireLabel
            // 
            this.InvoiceExpireLabel.AutoSize = true;
            this.InvoiceExpireLabel.Location = new System.Drawing.Point(158, 144);
            this.InvoiceExpireLabel.Name = "InvoiceExpireLabel";
            this.InvoiceExpireLabel.Size = new System.Drawing.Size(82, 13);
            this.InvoiceExpireLabel.TabIndex = 4;
            this.InvoiceExpireLabel.Text = "Betalas senast :";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(158, 169);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(75, 13);
            this.CustomerIDLabel.TabIndex = 5;
            this.CustomerIDLabel.Text = "Kundnummer :";
            // 
            // CustomerMailLabel
            // 
            this.CustomerMailLabel.AutoSize = true;
            this.CustomerMailLabel.Location = new System.Drawing.Point(158, 193);
            this.CustomerMailLabel.Name = "CustomerMailLabel";
            this.CustomerMailLabel.Size = new System.Drawing.Size(76, 13);
            this.CustomerMailLabel.TabIndex = 6;
            this.CustomerMailLabel.Text = "Kundens mail :";
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Location = new System.Drawing.Point(158, 223);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(96, 13);
            this.BookingIDLabel.TabIndex = 7;
            this.BookingIDLabel.Text = "BokningsNummer :";
            // 
            // InvoiceIsPayedCheckBox
            // 
            this.InvoiceIsPayedCheckBox.AutoSize = true;
            this.InvoiceIsPayedCheckBox.Location = new System.Drawing.Point(161, 250);
            this.InvoiceIsPayedCheckBox.Name = "InvoiceIsPayedCheckBox";
            this.InvoiceIsPayedCheckBox.Size = new System.Drawing.Size(56, 17);
            this.InvoiceIsPayedCheckBox.TabIndex = 8;
            this.InvoiceIsPayedCheckBox.Text = "Betald";
            this.InvoiceIsPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // UppdateInvoiceButton
            // 
            this.UppdateInvoiceButton.Location = new System.Drawing.Point(161, 414);
            this.UppdateInvoiceButton.Name = "UppdateInvoiceButton";
            this.UppdateInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.UppdateInvoiceButton.TabIndex = 9;
            this.UppdateInvoiceButton.Text = "Uppdatera";
            this.UppdateInvoiceButton.UseVisualStyleBackColor = true;
            this.UppdateInvoiceButton.Click += new System.EventHandler(this.UppdateInvoiceButton_Click);
            // 
            // ShowInvoicesLabel
            // 
            this.ShowInvoicesLabel.AutoSize = true;
            this.ShowInvoicesLabel.Location = new System.Drawing.Point(161, 18);
            this.ShowInvoicesLabel.Name = "ShowInvoicesLabel";
            this.ShowInvoicesLabel.Size = new System.Drawing.Size(83, 13);
            this.ShowInvoicesLabel.TabIndex = 10;
            this.ShowInvoicesLabel.Text = "Sortera Fakturor";
            // 
            // ListboxLabel
            // 
            this.ListboxLabel.AutoSize = true;
            this.ListboxLabel.Location = new System.Drawing.Point(12, 18);
            this.ListboxLabel.Name = "ListboxLabel";
            this.ListboxLabel.Size = new System.Drawing.Size(46, 13);
            this.ListboxLabel.TabIndex = 11;
            this.ListboxLabel.Text = "Fakturor";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListboxLabel);
            this.Controls.Add(this.ShowInvoicesLabel);
            this.Controls.Add(this.UppdateInvoiceButton);
            this.Controls.Add(this.InvoiceIsPayedCheckBox);
            this.Controls.Add(this.BookingIDLabel);
            this.Controls.Add(this.CustomerMailLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.InvoiceExpireLabel);
            this.Controls.Add(this.InvoiceIssueLabel);
            this.Controls.Add(this.InvoiceIDLabel);
            this.Controls.Add(this.ShowInvoiceBox);
            this.Controls.Add(this.InvoiceListbox);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InvoiceListbox;
        private System.Windows.Forms.ComboBox ShowInvoiceBox;
        private System.Windows.Forms.Label InvoiceIDLabel;
        private System.Windows.Forms.Label InvoiceIssueLabel;
        private System.Windows.Forms.Label InvoiceExpireLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CustomerMailLabel;
        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.CheckBox InvoiceIsPayedCheckBox;
        private System.Windows.Forms.Button UppdateInvoiceButton;
        private System.Windows.Forms.Label ShowInvoicesLabel;
        private System.Windows.Forms.Label ListboxLabel;
    }
}