using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LearnMVC.Models;

namespace LearnMVC.Dtos
{
    public class CustomerDto
    {
        // use primitive types normally inside a DTO
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}