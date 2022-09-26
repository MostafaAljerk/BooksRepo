using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int Countr { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
