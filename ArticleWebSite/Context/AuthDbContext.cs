using ArticleWebSite.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleWebSite.Context
{
    public class AuthDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthDbContext(): base()
        {

        }
    }
}