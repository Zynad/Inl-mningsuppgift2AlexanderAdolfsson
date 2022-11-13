namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class BookingForm
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
            this.CustomerSearchText = new System.Windows.Forms.TextBox();
            this.RoomList = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.NoOfPersonBox = new System.Windows.Forms.ComboBox();
            this.NoOfPersonLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.NewBookingButton = new System.Windows.Forms.Button();
            this.SearchRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerSearchText
            // 
            this.CustomerSearchText.Location = new System.Drawing.Point(12, 46);
            this.CustomerSearchText.Name = "CustomerSearchText";
            this.CustomerSearchText.Size = new System.Drawing.Size(154, 20);
            this.CustomerSearchText.TabIndex = 0;
            this.CustomerSearchText.TextChanged += new System.EventHandler(this.CustomerSearchText_TextChanged);
            // 
            // RoomList
            // 
            this.RoomList.FormattingEnabled = true;
            this.RoomList.Location = new System.Drawing.Point(12, 244);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(154, 121);
            this.RoomList.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 27);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(68, 13);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Sök på kund";
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(13, 225);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(80, 13);
            this.RoomLabel.TabIndex = 3;
            this.RoomLabel.Text = "Tillgängliga rum";
            // 
            // NoOfPersonBox
            // 
            this.NoOfPersonBox.FormattingEnabled = true;
            this.NoOfPersonBox.Location = new System.Drawing.Point(189, 92);
            this.NoOfPersonBox.Name = "NoOfPersonBox";
            this.NoOfPersonBox.Size = new System.Drawing.Size(121, 21);
            this.NoOfPersonBox.TabIndex = 4;
            this.NoOfPersonBox.TextChanged += new System.EventHandler(this.NoOfPersonBox_TextChanged);
            // 
            // NoOfPersonLabel
            // 
            this.NoOfPersonLabel.AutoSize = true;
            this.NoOfPersonLabel.Location = new System.Drawing.Point(189, 72);
            this.NoOfPersonLabel.Name = "NoOfPersonLabel";
            this.NoOfPersonLabel.Size = new System.Drawing.Size(75, 13);
            this.NoOfPersonLabel.TabIndex = 5;
            this.NoOfPersonLabel.Text = "Antal personer";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(189, 140);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 6;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(192, 120);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(28, 13);
            this.StartDateLabel.TabIndex = 7;
            this.StartDateLabel.Text = "Från";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(189, 193);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 6;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(192, 173);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(20, 13);
            this.EndDateLabel.TabIndex = 7;
            this.EndDateLabel.Text = "Till";
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(12, 92);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(154, 121);
            this.CustomerList.TabIndex = 1;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(13, 73);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(41, 13);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Kunder";
            // 
            // NewBookingButton
            // 
            this.NewBookingButton.Location = new System.Drawing.Point(288, 342);
            this.NewBookingButton.Name = "NewBookingButton";
            this.NewBookingButton.Size = new System.Drawing.Size(75, 23);
            this.NewBookingButton.TabIndex = 8;
            this.NewBookingButton.Text = "Ny bokning";
            this.NewBookingButton.UseVisualStyleBackColor = true;
            this.NewBookingButton.Click += new System.EventHandler(this.NewBookingButton_Click);
            // 
            // SearchRoomButton
            // 
            this.SearchRoomButton.Location = new System.Drawing.Point(189, 342);
            this.SearchRoomButton.Name = "SearchRoomButton";
            this.SearchRoomButton.Size = new System.Drawing.Size(93, 23);
            this.SearchRoomButton.TabIndex = 8;
            this.SearchRoomButton.Text = "Sök lediga rum";
            this.SearchRoomButton.UseVisualStyleBackColor = true;
            this.SearchRoomButton.Click += new System.EventHandler(this.SearchRoomButton_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 404);
            this.Controls.Add(this.SearchRoomButton);
            this.Controls.Add(this.NewBookingButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.NoOfPersonLabel);
            this.Controls.Add(this.NoOfPersonBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.RoomLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.CustomerSearchText);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerSearchText;
        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ComboBox NoOfPersonBox;
        private System.Windows.Forms.Label NoOfPersonLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Button NewBookingButton;
        private System.Windows.Forms.Button SearchRoomButton;
    }
}