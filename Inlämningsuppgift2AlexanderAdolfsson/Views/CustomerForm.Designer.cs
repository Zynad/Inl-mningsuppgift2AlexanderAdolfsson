namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class CustomerForm
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
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.CustomerPhoneLabel = new System.Windows.Forms.Label();
            this.CustomerPhoneText = new System.Windows.Forms.TextBox();
            this.CustomerEmailLabel = new System.Windows.Forms.Label();
            this.CustomerEmailText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(24, 21);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(124, 394);
            this.CustomerList.TabIndex = 0;
            this.CustomerList.DoubleClick += new System.EventHandler(this.CustomerList_DoubleClick);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(190, 21);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(75, 13);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Kundnummer :";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(190, 49);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "Namn";
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Location = new System.Drawing.Point(193, 66);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(169, 20);
            this.CustomerNameText.TabIndex = 1;
            // 
            // CustomerPhoneLabel
            // 
            this.CustomerPhoneLabel.AutoSize = true;
            this.CustomerPhoneLabel.Location = new System.Drawing.Point(190, 151);
            this.CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            this.CustomerPhoneLabel.Size = new System.Drawing.Size(80, 13);
            this.CustomerPhoneLabel.TabIndex = 2;
            this.CustomerPhoneLabel.Text = "Telefonnummer";
            // 
            // CustomerPhoneText
            // 
            this.CustomerPhoneText.Location = new System.Drawing.Point(193, 168);
            this.CustomerPhoneText.Name = "CustomerPhoneText";
            this.CustomerPhoneText.Size = new System.Drawing.Size(169, 20);
            this.CustomerPhoneText.TabIndex = 3;
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.AutoSize = true;
            this.CustomerEmailLabel.Location = new System.Drawing.Point(190, 102);
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.CustomerEmailLabel.TabIndex = 2;
            this.CustomerEmailLabel.Text = "Email";
            // 
            // CustomerEmailText
            // 
            this.CustomerEmailText.Location = new System.Drawing.Point(193, 119);
            this.CustomerEmailText.Name = "CustomerEmailText";
            this.CustomerEmailText.Size = new System.Drawing.Size(169, 20);
            this.CustomerEmailText.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(156, 392);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(237, 392);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Uppdatera";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(318, 392);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Ta bort";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 428);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomerEmailText);
            this.Controls.Add(this.CustomerEmailLabel);
            this.Controls.Add(this.CustomerPhoneText);
            this.Controls.Add(this.CustomerPhoneLabel);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.CustomerList);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerNameText;
        private System.Windows.Forms.Label CustomerPhoneLabel;
        private System.Windows.Forms.TextBox CustomerPhoneText;
        private System.Windows.Forms.Label CustomerEmailLabel;
        private System.Windows.Forms.TextBox CustomerEmailText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}