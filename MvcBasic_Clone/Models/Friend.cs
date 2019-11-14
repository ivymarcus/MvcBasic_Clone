using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Friend
    {
        // 如果不要用 Id 要用 Number 
        //[Key]
        //public string No { get; set; }

        //public string FriendId { get; set; }
        
        
        //[Display(Name = "身分證字號")]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "電話")]
        public string Phone { get; set; }
        [Display(Name = "郵件")]
        public string Email { get; set; }
        [Display(Name = "城市")]
        public string City { get; set; }
    }
}