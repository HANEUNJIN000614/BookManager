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
    public class BooksRepository : RepositoryBase
    {
        public bool Save(BooksEntity book)
        {
            string sql = new BooksQuery().Save();

            return Execute(sql, book) == 1;
        }

        public bool Delete(BooksEntity book)
        {
            string sql = new BooksQuery().Delete();

            return Execute(sql, book) == 1;
        }

    }
}
