using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnMVCModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name Is Required")]
        [RegularExpression("[a-zA-Z]{4,20}",ErrorMessage ="Name Length Should be Between 4 To 20 Characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="Email is Inavalid")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings=false,ErrorMessage ="Please Select Country")]
        //[Required(ErrorMessage = "Country have to be selected")]
        public string Country { get; set; }
        [Required(ErrorMessage ="User name have to be Entered")]
        [RegularExpression("[0-9a-z]{3,5}",ErrorMessage ="User Name Lenth should be Between 1 to 6 characters and of small letters and digits")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Must Enter Password")]
        [RegularExpression("[0-9a-zA-Z]{6,9}",ErrorMessage ="Password Length Should be Between 6 to 9 Characters")]
        public string Password { get; set; }
       [Required(ErrorMessage ="Please provide DOB")]
        public DateTime DOB { get; set; }
    }
}
