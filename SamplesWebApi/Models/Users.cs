﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SamplesWebApi.Models
{
    public class Users
    {
        [Key]
        public Int32 Id { get; set; }

        public String FullName { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
    }
}