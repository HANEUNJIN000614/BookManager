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
        BookService bookService = null;
        public BookPresenter()
        {
            bookService = new BookService();
        }

        public bool Save(BooksEntity book)
        {
            return bookService.Save(book);
        }

        public bool Delete(BooksEntity book)
        {
            return bookService.Delete(book);
        }

        public List<BooksEntity> Search()
        {
            return bookService.Search();
        }
    }
}