using EunJinBookManagerEntity;
using EunJinBookManagerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerService
{
    public class BookService
    {
        BooksRepository BooksRepo = null;

        public BookService()
        {
            BooksRepo = new BooksRepository();        
        }

        public bool Save(BooksEntity book)
        {
            return BooksRepo.Save(book);
        }

        public bool Delete(BooksEntity book)
        {
            return BooksRepo.Delete(book);
        }
    }
}