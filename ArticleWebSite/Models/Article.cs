using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArticlesSite.Models
{
    public class Article
    {
        public string ArticleId { get; set; }   
        public string Name { get; set; } 
        public string Body { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }

    }
}