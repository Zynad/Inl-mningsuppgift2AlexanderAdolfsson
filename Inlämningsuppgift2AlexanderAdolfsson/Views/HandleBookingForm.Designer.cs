namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    partial class HandleBookingForm
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
            this.BookingGrid = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoicePayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingGrid
            // 
            this.BookingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.CustomerName,
            this.RoomNumber,
            this.StartDate,
            this.EndDate,
            this.InvoicePayed});
            this.BookingGrid.Location = new System.Drawing.Point(37, 81);
            this.BookingGrid.MultiSelect = false;
            this.BookingGrid.Name = "BookingGrid";
            this.BookingGrid.ReadOnly = true;
            this.BookingGrid.Size = new System.Drawing.Size(540, 462);
            this.BookingGrid.TabIndex = 0;
            this.BookingGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            this.BookingID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Kundnamn";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Rumsnummer";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Bokad från";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Bokad till";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // InvoicePayed
            // 
            this.InvoicePayed.HeaderText = "Fakturan betald";
            this.InvoicePayed.Name = "InvoicePayed";
            this.InvoicePayed.ReadOnly = true;
            // 
            // HandleBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 578);
            this.Controls.Add(this.BookingGrid);
            this.Name = "HandleBookingForm";
            this.Text = "HandleBookingForm";
            this.Load += new System.EventHandler(this.HandleBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookingGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoicePayed;
    }
}