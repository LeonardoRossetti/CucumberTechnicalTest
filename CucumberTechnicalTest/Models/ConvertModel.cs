using System;
using System.ComponentModel.DataAnnotations;

namespace CucumberTechnicalTest.Models
{
    public class ConvertModel
    {
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        public String Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 100000000000000, ErrorMessage = "Only Numbers between 1 and 100000000000000 are allowed.")]
        public Decimal Number { get; set; }

        public ResultModel Result { get; set; }
    }
}