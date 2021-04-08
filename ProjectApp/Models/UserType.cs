using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADproj.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }

        public bool Type { get; set; }

        public ICollection<User> User { get; set; }
    }
}
