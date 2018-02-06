using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        public string Rolename { get; set; }

        public List<User> UsersInRole { get; set; }
    }
}