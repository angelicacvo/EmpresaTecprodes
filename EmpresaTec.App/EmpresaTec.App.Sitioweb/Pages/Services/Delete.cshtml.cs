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
    public class DeleteModelS : PageModel
    {
        public IRepositorioServices _repoServices {get; set;}
        [BindProperty]
        public Services services {get; set;}

        public DeleteModelS()
        {
            _repoServices = new RepositorioServices(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet(int id)
        {
            services = _repoServices.ObtenerPorId(id);
        }

        public IActionResult OnPost()
        {
            Console.WriteLine(services.servicesId);
            _repoServices.Eliminar(services.servicesId);
            return RedirectToPage("/Services/List");
        }
    }
}
