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
    public class CreateModelU : PageModel
    {
        private IRepositorioUser _repoUser {get; set;}
        [BindProperty]
        public User user {get; set;}

        public CreateModelU()
        {
            _repoUser = new RepositorioUser(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost (User user)
        {
            _repoUser.Agregar(user);
            return RedirectToPage("/User/List"); 
            
        }
    }
}

