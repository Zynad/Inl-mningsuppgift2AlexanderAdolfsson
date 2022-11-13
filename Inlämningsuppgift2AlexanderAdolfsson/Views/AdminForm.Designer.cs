namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class AdminForm
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
            this.CustomerButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.HandleBookingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(12, 12);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(105, 64);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Kundhantering";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(12, 97);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(105, 64);
            this.BookingButton.TabIndex = 1;
            this.BookingButton.Text = "Ny Bokning";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(143, 12);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(105, 64);
            this.InvoiceButton.TabIndex = 2;
            this.InvoiceButton.Text = "Fakturahantering";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // HandleBookingButton
            // 
            this.HandleBookingButton.Location = new System.Drawing.Point(143, 97);
            this.HandleBookingButton.Name = "HandleBookingButton";
            this.HandleBookingButton.Size = new System.Drawing.Size(105, 64);
            this.HandleBookingButton.TabIndex = 1;
            this.HandleBookingButton.Text = "Bokningshantering";
            this.HandleBookingButton.UseVisualStyleBackColor = true;
            this.HandleBookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 191);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.HandleBookingButton);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.CustomerButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button HandleBookingButton;
    }
}