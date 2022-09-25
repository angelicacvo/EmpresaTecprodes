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
    public class ListModelS : PageModel
    {
        public IEnumerable<Services> services {get; set;}
        private IRepositorioServices _repoServices;

        public ListModelS()
        {
            _repoServices = new RepositorioServices(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        public void OnGet() 
        {
            services = _repoServices.ObtenerTodos();
        }
    }
}
