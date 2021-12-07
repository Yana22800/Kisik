using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinesLogic.Core.Models
{
    public class UserIdentityBlo
    {
        public int Id { get; set; }
        public int NumberPrefix { get; set; }
        public int Number { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
