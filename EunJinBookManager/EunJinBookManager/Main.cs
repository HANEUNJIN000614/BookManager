using DevExpress.ClipboardSource.SpreadsheetML;
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
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            using (Book book = new Book())
            {
                book.ShowDialog();
            }
        }
    }
}