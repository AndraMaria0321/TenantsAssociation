using ProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADproj.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }

        public ICollection<Apartment> Apartment { get; set; }

    }
}
