using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmpresaTec.App.Dominio;
using EmpresaTec.App.Persistencia;

namespace EmpresaTec.App.Sitioweb.App.Pages
{
    public class CreateModelS : PageModel
    {
        private IRepositorioServices _repoServices {get; set;}
        [BindProperty]
        public Services services {get; set;}

        public CreateModelS()
        {
            _repoServices = new RepositorioServices(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost (Services services)
        {
            if (ModelState.IsValid)
            {
                _repoServices.Agregar(services);
                return RedirectToPage("/Services/List");
            }
            else
            {
                return Page();
            }
            
            
        }
    }
}
