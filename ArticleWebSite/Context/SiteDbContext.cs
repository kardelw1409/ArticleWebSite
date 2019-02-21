using ArticlesSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArticlesSite.Context
{
    public class SiteDbContext: DbContext
    {
        public SiteDbContext(): base()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}