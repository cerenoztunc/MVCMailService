using MVCMailService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMailService.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConneciton")
        {

        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}