using EKutuphane.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphane.Core.Abstract
{
    public class Book
    {
        public string BookName { get; set; }   
        public ushort PageNumber { get; set; }
        public AuthorInfo AuthorInfo { get; set; }
        public DateTime DateTime { get; set; }
        public string MyProperty { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
        public BookCategories Categories { get; set; }

    }

}

