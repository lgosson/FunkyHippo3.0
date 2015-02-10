using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunkyHippo.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AlbumID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
       

        public virtual Album Album { get; set; }
        public virtual User User { get; set; }
    }
}