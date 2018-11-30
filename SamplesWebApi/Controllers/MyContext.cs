using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SamplesWebApi.Controllers
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {

        }

        public System.Data.Entity.DbSet<SamplesWebApi.Models.Users> Users { get; set; }
    }
}