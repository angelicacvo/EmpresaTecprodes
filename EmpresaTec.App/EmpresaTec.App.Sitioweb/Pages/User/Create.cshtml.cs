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
    public class CreateModel : PageModel
    {
        private IRepositorioUser _repoUser {get; set;}
        [BindProperty]
        public User user {get; set;}

        public CreateModel()
        {
            _repoUser = new RepositorioUser(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet()
        {
        }

        public IActionResult onPost (User user)
        {
            if (ModelState.IsValid)
            {
                _repoUser.Agregar(user);
                return RedirectToPage("/User/List");
            }
            else
            {
                return Page();
            }
            
            
        }
    }
}

