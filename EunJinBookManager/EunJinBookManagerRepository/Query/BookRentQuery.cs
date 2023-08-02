using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerRepository.Query
{
    internal class BookRentQuery
    {
        public string SaveBookRentQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");

            return sql.ToString();
        }

        public string DeleteBookRentQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("");

            return sql.ToString();
        }

        public string SearchBookRentQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM book_rent;");

            return sql.ToString();
        }
    }
}