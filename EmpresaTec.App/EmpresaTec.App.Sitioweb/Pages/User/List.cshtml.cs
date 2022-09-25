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
    public class ListModelU : PageModel
    {
        public IEnumerable<User> users {get; set;}
        private IRepositorioUser _repoUser;

        public ListModelU()
        {
            _repoUser = new RepositorioUser(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        public void OnGet() 
        {
            users = _repoUser.ObtenerTodos();
        }
    }
}
