using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProductRazorPages.Contracts;

namespace WebProductRazorPages.Pages.Product
{
    public class IndexModel : PageModel
    {
        protected readonly IRepository _Repository;
        public List<Models.Product> Products; 

        public IndexModel(IRepository repository)
        {
            _Repository = repository;
        }

        /// <summary>
        /// Inicializa estado de la pagina y atiente Peticiones HTTPGET (tambien hay onpost)
        /// </summary>
        public void OnGet()
        {
            Products = _Repository.GetList();
        }
    }
}