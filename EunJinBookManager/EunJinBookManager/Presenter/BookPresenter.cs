using DevExpress.XtraBars.Ribbon;
using EunJinBookManagerEntity;
using EunJinBookManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManager.Presenter
{
    internal class BookPresenter
    {
        BookService _bookService = null;
        public BookPresenter()
        {
            _bookService = new BookService();
        }

        public bool Save(BooksEntity book)
        {
            return _bookService.Save(book);
        }

        public bool Delete(BooksEntity book)
        {
            return _bookService.Delete(book);
        }

        public List<BooksEntity> Search()
        {           
            return _bookService.Search();
        }
    }
}