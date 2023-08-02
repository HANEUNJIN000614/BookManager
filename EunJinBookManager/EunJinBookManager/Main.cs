using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGauges.Win.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EunJinBookManager
{
    public partial class EunJinBookManager : DevExpress.XtraEditors.XtraForm
    {
        public EunJinBookManager()
        {
            InitializeComponent();

            BtnBook.Click += BtnBook_Click;
            BtnCustomers.Click += BtnCustomers_Click;
            BtnBookRent.Click += BtnBookRent_Click;
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            using (Book book = new Book())
            {
                book.ShowDialog();
            }
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            using (Customers customers = new Customers())
            {
                customers.ShowDialog();
            }
        }

        private void BtnBookRent_Click(object sender, EventArgs e)
        {
            using (BookRent bookRent = new BookRent())
            {
                bookRent.ShowDialog();
            }
        }
    }
}