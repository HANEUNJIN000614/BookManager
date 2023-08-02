using EunJinBookManagerEntity;
using EunJinBookManagerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerService
{
    public class BookRentService
    {
        BookRentRepository _bookRentRepo = null;

        public BookRentService()
        {
            _bookRentRepo = new BookRentRepository();
        }

        //저장
        public bool SaveBookRent(BookRentEntity bookRent)
        {
            return _bookRentRepo.SaveBookRent(bookRent);
        }

        //삭제
        public bool DeleteBookRent(BookRentEntity bookRent)
        {
            return _bookRentRepo.DeleteBookRent(bookRent);
        }

        //조회
        public List<BookRentEntity> SearchBookRent()
        {
            return _bookRentRepo.SearchBookRent();
        }
    }
}