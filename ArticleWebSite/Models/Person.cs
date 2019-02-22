using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticlesSite.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        public virtual ICollection<Article> Articles { get; set; } 
    }
}