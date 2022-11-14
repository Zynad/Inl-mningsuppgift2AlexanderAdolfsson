namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class UpdateBookingForm
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
            this.BookingIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerMailLabel = new System.Windows.Forms.Label();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.RoomTypeNameLabel = new System.Windows.Forms.Label();
            this.InvoiceIsPayedLabel = new System.Windows.Forms.Label();
            this.RoomNumberBox = new System.Windows.Forms.ComboBox();
            this.BookingEndDateLabel = new System.Windows.Forms.Label();
            this.BookingStartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NoOfPersonsLabel = new System.Windows.Forms.Label();
            this.NoOfPersonsBox = new System.Windows.Forms.ComboBox();
            this.UpdateRoomButton = new System.Windows.Forms.Button();
            this.UpdateBookingButton = new System.Windows.Forms.Button();
            this.RemoveBookingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookingIDLabel
            // 
            this.BookingIDLabel.AutoSize = true;
            this.BookingIDLabel.Location = new System.Drawing.Point(35, 23);
            this.BookingIDLabel.Name = "BookingIDLabel";
            this.BookingIDLabel.Size = new System.Drawing.Size(94, 13);
            this.BookingIDLabel.TabIndex = 0;
            this.BookingIDLabel.Text = "Bokningsnummer :";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(35, 46);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(75, 13);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "Kundnummer :";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(35, 70);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(64, 13);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Kundnamn :";
            // 
            // CustomerMailLabel
            // 
            this.CustomerMailLabel.AutoSize = true;
            this.CustomerMailLabel.Location = new System.Drawing.Point(35, 94);
            this.CustomerMailLabel.Name = "CustomerMailLabel";
            this.CustomerMailLabel.Size = new System.Drawing.Size(76, 13);
            this.CustomerMailLabel.TabIndex = 0;
            this.CustomerMailLabel.Text = "Kundens mail :";
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Location = new System.Drawing.Point(35, 313);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(77, 13);
            this.RoomNumberLabel.TabIndex = 0;
            this.RoomNumberLabel.Text = "Rumsnummer :";
            // 
            // RoomTypeNameLabel
            // 
            this.RoomTypeNameLabel.AutoSize = true;
            this.RoomTypeNameLabel.Location = new System.Drawing.Point(35, 139);
            this.RoomTypeNameLabel.Name = "RoomTypeNameLabel";
            this.RoomTypeNameLabel.Size = new System.Drawing.Size(54, 13);
            this.RoomTypeNameLabel.TabIndex = 0;
            this.RoomTypeNameLabel.Text = "Rumstyp :";
            // 
            // InvoiceIsPayedLabel
            // 
            this.InvoiceIsPayedLabel.AutoSize = true;
            this.InvoiceIsPayedLabel.Location = new System.Drawing.Point(35, 164);
            this.InvoiceIsPayedLabel.Name = "InvoiceIsPayedLabel";
            this.InvoiceIsPayedLabel.Size = new System.Drawing.Size(97, 13);
            this.InvoiceIsPayedLabel.TabIndex = 0;
            this.InvoiceIsPayedLabel.Text = "Är fakturan betald :";
            // 
            // RoomNumberBox
            // 
            this.RoomNumberBox.FormattingEnabled = true;
            this.RoomNumberBox.Location = new System.Drawing.Point(118, 310);
            this.RoomNumberBox.Name = "RoomNumberBox";
            this.RoomNumberBox.Size = new System.Drawing.Size(121, 21);
            this.RoomNumberBox.TabIndex = 1;
            // 
            // BookingEndDateLabel
            // 
            this.BookingEndDateLabel.AutoSize = true;
            this.BookingEndDateLabel.Location = new System.Drawing.Point(35, 214);
            this.BookingEndDateLabel.Name = "BookingEndDateLabel";
            this.BookingEndDateLabel.Size = new System.Drawing.Size(56, 13);
            this.BookingEndDateLabel.TabIndex = 0;
            this.BookingEndDateLabel.Text = "Bokad till :";
            // 
            // BookingStartDateLabel
            // 
            this.BookingStartDateLabel.AutoSize = true;
            this.BookingStartDateLabel.Location = new System.Drawing.Point(35, 189);
            this.BookingStartDateLabel.Name = "BookingStartDateLabel";
            this.BookingStartDateLabel.Size = new System.Drawing.Size(65, 13);
            this.BookingStartDateLabel.TabIndex = 0;
            this.BookingStartDateLabel.Text = "Bokad från :";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(106, 186);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 2;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(106, 212);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 3;
            // 
            // NoOfPersonsLabel
            // 
            this.NoOfPersonsLabel.AutoSize = true;
            this.NoOfPersonsLabel.Location = new System.Drawing.Point(35, 116);
            this.NoOfPersonsLabel.Name = "NoOfPersonsLabel";
            this.NoOfPersonsLabel.Size = new System.Drawing.Size(76, 13);
            this.NoOfPersonsLabel.TabIndex = 0;
            this.NoOfPersonsLabel.Text = "Antal Personer";
            // 
            // NoOfPersonsBox
            // 
            this.NoOfPersonsBox.FormattingEnabled = true;
            this.NoOfPersonsBox.Location = new System.Drawing.Point(118, 113);
            this.NoOfPersonsBox.Name = "NoOfPersonsBox";
            this.NoOfPersonsBox.Size = new System.Drawing.Size(121, 21);
            this.NoOfPersonsBox.TabIndex = 4;
            // 
            // UpdateRoomButton
            // 
            this.UpdateRoomButton.Location = new System.Drawing.Point(38, 257);
            this.UpdateRoomButton.Name = "UpdateRoomButton";
            this.UpdateRoomButton.Size = new System.Drawing.Size(91, 36);
            this.UpdateRoomButton.TabIndex = 5;
            this.UpdateRoomButton.Text = "Uppdatera tillgängliga rum";
            this.UpdateRoomButton.UseVisualStyleBackColor = true;
            this.UpdateRoomButton.Click += new System.EventHandler(this.UpdateRoomButton_Click);
            // 
            // UpdateBookingButton
            // 
            this.UpdateBookingButton.Location = new System.Drawing.Point(38, 369);
            this.UpdateBookingButton.Name = "UpdateBookingButton";
            this.UpdateBookingButton.Size = new System.Drawing.Size(91, 36);
            this.UpdateBookingButton.TabIndex = 5;
            this.UpdateBookingButton.Text = "Uppdatera Bokning";
            this.UpdateBookingButton.UseVisualStyleBackColor = true;
            this.UpdateBookingButton.Click += new System.EventHandler(this.UpdateBookingButton_Click);
            // 
            // RemoveBookingButton
            // 
            this.RemoveBookingButton.Location = new System.Drawing.Point(135, 369);
            this.RemoveBookingButton.Name = "RemoveBookingButton";
            this.RemoveBookingButton.Size = new System.Drawing.Size(91, 36);
            this.RemoveBookingButton.TabIndex = 5;
            this.RemoveBookingButton.Text = "Ta bort Bokning";
            this.RemoveBookingButton.UseVisualStyleBackColor = true;
            this.RemoveBookingButton.Click += new System.EventHandler(this.RemoveBookingButton_Click);
            // 
            // UpdateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveBookingButton);
            this.Controls.Add(this.UpdateBookingButton);
            this.Controls.Add(this.UpdateRoomButton);
            this.Controls.Add(this.NoOfPersonsBox);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.RoomNumberBox);
            this.Controls.Add(this.BookingStartDateLabel);
            this.Controls.Add(this.BookingEndDateLabel);
            this.Controls.Add(this.InvoiceIsPayedLabel);
            this.Controls.Add(this.RoomTypeNameLabel);
            this.Controls.Add(this.NoOfPersonsLabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.CustomerMailLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.BookingIDLabel);
            this.Name = "UpdateBookingForm";
            this.Text = "UpdateBookingForm";
            this.Load += new System.EventHandler(this.UpdateBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookingIDLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerMailLabel;
        private System.Windows.Forms.Label RoomNumberLabel;
        private System.Windows.Forms.Label RoomTypeNameLabel;
        private System.Windows.Forms.Label InvoiceIsPayedLabel;
        private System.Windows.Forms.ComboBox RoomNumberBox;
        private System.Windows.Forms.Label BookingEndDateLabel;
        private System.Windows.Forms.Label BookingStartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label NoOfPersonsLabel;
        private System.Windows.Forms.ComboBox NoOfPersonsBox;
        private System.Windows.Forms.Button UpdateRoomButton;
        private System.Windows.Forms.Button UpdateBookingButton;
        private System.Windows.Forms.Button RemoveBookingButton;
    }
}