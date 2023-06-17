using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profile { get; set; }
        public string Avatar { get; set; }
        public string MilitaryStatus { get; set; }
        public string MaritalStatus { get; set; }
        public Address Address { get; set; }
    }
}
