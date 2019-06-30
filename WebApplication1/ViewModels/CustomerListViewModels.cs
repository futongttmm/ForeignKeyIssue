using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CustomerMembershipViewModels
    {
        public List<Customer> Customers { get; set; }
        public Movie Movie { get; set; }
    }
}