using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        

        public virtual ICollection<Review> Reviews { get; set; }
    }
}