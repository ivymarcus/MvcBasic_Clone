﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    // 模型類別定義
    public class Employee
    {
        [Display(Name = "員工編號")]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "聯絡電話")]
        public string Phone { get; set; }
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}