using Microsoft.AspNetCore.Http;
using System;

namespace WebApp.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Period { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; }
    }
}
