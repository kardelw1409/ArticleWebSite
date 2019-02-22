﻿using ArticleWebSite.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ArticleWebSite.Models
{
    public class AuthRepository : IDisposable
	    {
	        private AuthDbContext _ctx;
	
	        private UserManager<IdentityUser> _userManager;
	
	        public AuthRepository()
 	        {
	            _ctx = new AuthDbContext();
	            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
	        }
	       //Method will help to Register User
	        public async Task<IdentityResult> RegisterUser(UserModel userModel)
	        {
	            IdentityUser user = new IdentityUser
	            {
	                UserName = userModel.UserName
	            };
	
	            var result = await _userManager.CreateAsync(user, userModel.Password);
	
	            return result;
	        }
	          //Method used to Get User details will be used by
	          //Authentication Provider class in Steps below
	        public async Task<IdentityUser> FindUser(string userName, string password)
	        {
	            var user = await _userManager.FindAsync(userName, password);
	
	            return user;
	        }
	
	        public void Dispose()
	        {
	            _ctx.Dispose();
	            _userManager.Dispose();
	
	        }
	    }
}