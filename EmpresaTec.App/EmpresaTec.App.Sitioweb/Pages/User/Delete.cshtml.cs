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
    public class DeleteModelU : PageModel
    {
        public IRepositorioUser _repoUser {get; set;}
        [BindProperty]
        public User user {get; set;}

        public DeleteModelU()
        {
            _repoUser = new RepositorioUser(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet(int id)
        {
            user = _repoUser.ObtenerPorId(id);
        }

        public IActionResult OnPost()
        {
            Console.WriteLine(user.userId);
            _repoUser.Eliminar(user.userId);
            return RedirectToPage("/User/List");
        }
    }
}
