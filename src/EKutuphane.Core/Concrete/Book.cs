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
        public ushort SayfaSayisi { get; set; }
        public AuthorInfo AuthorInfo { get; set; }
        public DateTime DateTime { get; set; }
        public string MyProperty { get; set; }



    }

}

