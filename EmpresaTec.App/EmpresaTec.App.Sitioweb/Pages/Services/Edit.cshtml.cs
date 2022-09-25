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
    public class EditModel : PageModel
    {
        private IRepositorioServices _repoServices {get; set;}
        [BindProperty]
        public Services services {get; set;}

        public EditModel()
        {
            _repoServices = new RepositorioServices(new EmpresaTec.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id) 
        {
            services = _repoServices.ObtenerPorId(id);
            if (services == null)
            {
                return RedirectToPage("/Services/List");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost(Services services)
        {
            _repoServices.Modificar(services);
            return RedirectToPage("/Services/List");
        }
    }
}
