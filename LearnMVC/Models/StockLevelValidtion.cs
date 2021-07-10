using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnMVC.Models
{
    public class StockLevelValidtion : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
            if (movie.GenreId == Genre.Unknown)
            {
                return ValidationResult.Success;
            }

            return (movie.NumberInStock <=0 || movie.NumberInStock >25 )
                ? ValidationResult.Success:
                new ValidationResult("Stock Level must be between 0 and 20");


        }
    }
}