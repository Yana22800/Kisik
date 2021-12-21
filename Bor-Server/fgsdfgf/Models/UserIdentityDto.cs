using System;
using System.Collections.Generic;
using System.Text;

namespace Bor.Core.Models
{
    public class UserIdentityDto
    {
        public int Id { get; set; }
        public int NumberPrefix { get; set; }
        public int Number { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
