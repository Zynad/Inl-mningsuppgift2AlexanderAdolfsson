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
            this.BookingGrid.Location = new System.Drawing.Point(49, 100);
            this.BookingGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookingGrid.MultiSelect = false;
            this.BookingGrid.Name = "BookingGrid";
            this.BookingGrid.ReadOnly = true;
            this.BookingGrid.RowHeadersWidth = 51;
            this.BookingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingGrid.Size = new System.Drawing.Size(720, 569);
            this.BookingGrid.TabIndex = 0;
            this.BookingGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BookingID
            // 
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.MinimumWidth = 6;
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            this.BookingID.Visible = false;
            this.BookingID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Kundnamn";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Rumsnummer";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            this.RoomNumber.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Bokad från";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Bokad till";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 125;
            // 
            // InvoicePayed
            // 
            this.InvoicePayed.HeaderText = "Fakturan betald";
            this.InvoicePayed.MinimumWidth = 6;
            this.InvoicePayed.Name = "InvoicePayed";
            this.InvoicePayed.ReadOnly = true;
            this.InvoicePayed.Width = 125;
            // 
            // HandleBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 711);
            this.Controls.Add(this.BookingGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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