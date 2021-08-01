using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApplication.Data
{
    public class CategoryType
    {
        [Key]
        [StringLength(80, MinimumLength = 1)]
        [Display(Name = "Category Type")]
        /*[RegularExpression("[A-Za-z]")]*/
        public string Type { get; set; }


        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Category Type Name", Description = "Category Type  Name")]
        [Required(ErrorMessage = "Category Type Name is Required", AllowEmptyStrings = false)]
      /*  [RegularExpression("[A-Za-z]")]*/
        public string Name { get; set; }
    }
}
