using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProductRazorPages.Contracts;

namespace WebProductRazorPages.Pages.Product
{
    public class DetailsModel : PageModel
    {
        protected readonly IRepository _Repository;
        public Models.Product Product { get; set; }

        public DetailsModel(IRepository repository)
        {
            _Repository = repository;
        }

        public void OnGet(int id)
        {
            Product = _Repository.GetProductByID(id);
        }
    }
}