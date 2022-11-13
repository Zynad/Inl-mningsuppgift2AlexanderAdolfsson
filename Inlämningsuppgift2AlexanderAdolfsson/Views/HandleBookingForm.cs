using Inlämningsuppgift2AlexanderAdolfsson.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2AlexanderAdolfsson.Views
{
    public partial class HandleBookingForm : Form
    {
        public HandleBookingForm()
        {
            InitializeComponent();
        }

        private void HandleBookingForm_Load(object sender, EventArgs e)
        {
            AppManager.InvoiceExpires();
        }
    }
}
