using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealFinalTP
{
    public partial class QueuingForm : Form
    {
        private CashierClass Cashier;

        public QueuingForm()
        {
            InitializeComponent();
            Cashier = new CashierClass();
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = Cashier.CashierGeneratedNumber(" P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            lblQueue.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierWindowQueue cwq = new CashierWindowQueue();
            cwq.Show();
        }


    }
}
