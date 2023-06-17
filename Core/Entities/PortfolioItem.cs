using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
     public class PortfolioItem : EntityBase
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Period { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
