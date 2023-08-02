using EunJinBookManagerEntity;
using EunJinBookManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManager.Presenter
{
    internal class BookRentPresenter
    {
        BookRentService _bookRentService = null;

        public BookRentPresenter()
        {
            _bookRentService = new BookRentService();
        }

        //저장
        public bool SaveBookRent(BookRentEntity bookRent)
        {
            return _bookRentService.SaveBookRent(bookRent);
        }

        //삭제
        public bool DeleteBookRent(BookRentEntity bookRent)
        {
            return _bookRentService.DeleteBookRent(bookRent);
        }

        //조회
        public List<BookRentEntity> SearchBookRent()
        {
            return _bookRentService.SearchBookRent();
        }
    }
}