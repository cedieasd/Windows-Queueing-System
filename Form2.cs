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
    public partial class CashierWindowQueue : Form
    {
        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {

        }
        public CashierWindowQueue()
        {
            InitializeComponent();
            DisplayCashierQueue(CashierClass.CashierQueue);
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Refresh_Click);
            timer.Start();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList) {

            listCashierQueue.Items.Clear();
            foreach (object tae in CashierList) {
                listCashierQueue.Items.Add(tae.ToString());
            }
        
        }

        private void Next_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
            listCashierQueue.Items.Clear();
            DisplayCashierQueue(CashierClass.CashierQueue);

            Form3 tae1 = new Form3();
            tae1.Show();
        }



    }
}
