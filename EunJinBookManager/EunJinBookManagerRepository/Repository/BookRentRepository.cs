using eGhis.Core;
using EunJinBookManagerEntity;
using EunJinBookManagerRepository.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerRepository
{
    public class BookRentRepository : RepositoryBase
    {
        public BookRentRepository() { }

        public bool SaveBookRent(BookRentEntity bookRent)
        {
            string sql = new BookRentQuery().SaveBookRentQuery();

            return Execute(sql, bookRent) == 1;
        }

        public bool DeleteBookRent(BookRentEntity bookRent)
        {
            string sql = new BookRentQuery().DeleteBookRentQuery();
           
            return Execute(sql, bookRent) == 1;
        }

        public List<BookRentEntity> SearchBookRent()
        {
            string sql = new BookRentQuery().SearchBookRentQuery();

            return Query<BookRentEntity>(sql);
        }
    }
}