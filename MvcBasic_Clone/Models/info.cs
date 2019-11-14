using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class info
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]
        // 沒有輸入時，會出現
        [Required(ErrorMessage ="Name必須輸入")]    
        // 長度20, 最少輸入3個字
        [StringLength(20, MinimumLength =3, ErrorMessage ="最少需要三個字元")]
        public string Name { get; set; }

        [Display(Name = "電話")]
        // 正則表達式
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage ="需為 09xx-xxx-xxx")]
        [Required(ErrorMessage = "Phone必須輸入")]      // 沒有輸入時，會出現
        public string Phone { get; set; }

        [Display(Name = "電子郵件")]
        [Required(ErrorMessage = "Email必須輸入")]      // 沒有輸入時，會出現
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "性別")]
        [Required(ErrorMessage = "Gender必須輸入")]     // 沒有輸入時，會出現
        public string Gender { get; set; }







        //public int Id { get; set; }

        //[Display(Name = "姓名")]
        //public string Name { get; set; }

        //[Display(Name = "電話")]
        //public string Phone { get; set; }

        //[Display(Name = "電子郵件")]
        //public string Email { get; set; }

        //[Display(Name = "性別")]
        //public string Gender { get; set; }


    }
}