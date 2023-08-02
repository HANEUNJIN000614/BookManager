using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerEntity
{
    public class BookRentEntity
    {
        public string rentDate { get; set; }
        public string rentTime { get; set; }
        public int customer { get; set; }
        public int bookId { get; set; }
        public string returnDate { get; set; }
        public string returnTime { get; set; }
    }
}