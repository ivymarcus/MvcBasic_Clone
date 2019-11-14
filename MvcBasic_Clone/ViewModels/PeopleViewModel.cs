using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBasic_Clone.Models;


// 傳多個 Model
namespace MvcBasic_Clone.ViewModels
{
    public class PeopleViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<Friend> Friends { get; set; }
    }
    // Controllers: PassDataController 在 Action: PassViewModel
}