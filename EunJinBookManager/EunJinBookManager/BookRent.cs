using EunJinBookManager.Presenter;
using EunJinBookManagerEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EunJinBookManager
{
    public partial class BookRent : DevExpress.XtraEditors.XtraForm
    {
        BookRentPresenter _presenter = null;
        public BookRent()
        {
            InitializeComponent();

            _presenter = new BookRentPresenter();

            this.Load += BookRent_Load;

            //button click event
        }

        private void BookRent_Load(object sender, EventArgs e)
        {
            SetGridHeader();
            Search();
        }

        private void SetGridHeader()
        {
            GridSearch.AddColumn("bookId", "도서ID", 100);
            GridSearch.AddColumn("rentDate", "대출일", 100);
            GridSearch.AddColumn("rentTime", "대출시간", 100);            
            GridSearch.AddColumn("returnDate", "반납일", 100);
            GridSearch.AddColumn("returnTime", "반납시간", 100);
        }

        private void Search()
        {
            List<BookRentEntity> list = _presenter.SearchBookRent();
            GridSearch.DataSource = list;
        }
    }
}