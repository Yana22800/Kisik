using System;
using System.Collections.Generic;
using System.Text;

namespace Bor.Core.Models
{
    public class UserInformationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
    }
}
