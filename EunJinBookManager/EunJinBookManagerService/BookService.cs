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
        BooksRepository _BooksRepo = null;

        public BookService()
        {
            _BooksRepo = new BooksRepository();        
        }

        public bool Save(BooksEntity book)
        {
            return _BooksRepo.Save(book);
        }

        public bool Delete(BooksEntity book)
        {
            return _BooksRepo.Delete(book);
        }

        public List<BooksEntity> Search()
        {
            return _BooksRepo.Search();
        }
    }
}