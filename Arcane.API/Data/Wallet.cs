using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Arcane.API.Data
{
    public class Wallet
    {
        [Key]
        public Guid UID { get; set; }

        [ForeignKey("UserID")]
        public UserProfile UserProfile { get; set; }
    }
}
