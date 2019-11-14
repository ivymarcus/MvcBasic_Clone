using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class FriendContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FriendContext() : base("name=FriendContext")
        {
        }


       
        public System.Data.Entity.DbSet<MvcBasic_Clone.Models.Friend> Friends { get; set; }

        // 跟 資料庫的資料表對應，所以名稱要一樣(Employees) ； 與 Models 對應 (MvcBasic_Clone.Models.Employee)
        public System.Data.Entity.DbSet<MvcBasic_Clone.Models.Employee> Employees { get; set; }
    }
}
