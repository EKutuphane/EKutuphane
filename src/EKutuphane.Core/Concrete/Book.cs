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
        public bool Status { get; set; }  // kitab�n kiral�k durumu hakk�nda bilgi olusturacak 
        public Member? Member { get; set; }
        public int? MemberId { get; set; }
        public BookCategories Categories { get; set; }
       
    }

}

