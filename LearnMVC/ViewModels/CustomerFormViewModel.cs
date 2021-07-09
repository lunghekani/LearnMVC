using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnMVC.Models;

namespace LearnMVC.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}