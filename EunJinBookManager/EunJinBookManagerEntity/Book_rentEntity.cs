using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerEntity
{
    public class Book_rentEntity
    {
        public string rent_date { get; set; }
        public string rent_time { get; set; }
        public int customer { get; set; }
        public int book_id { get; set; }
        public string return_date { get; set; }
        public string return_time { get; set; }
    }
}