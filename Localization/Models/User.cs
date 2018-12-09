using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localization.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
        public string Email { get; set; }
    }
}
