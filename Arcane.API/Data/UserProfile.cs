using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arcane.API.Data
{
    public class UserProfile
    {    
        [Key]
        public Guid UID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
