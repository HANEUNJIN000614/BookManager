using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerEntity
{
    public class BooksEntity
    {
        public int bId { get; set; }
        public string bNm { get; set; }
        public string bAnthor { get; set; }
        public decimal bCost { get; set; }
    }
}