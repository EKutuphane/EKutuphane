using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKutuphane.Core.Abstract

public class Customer
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public int AccountId { get; set; }
    public int Address { get; set; }
    public DateTime Birtdate { get; set; }
}