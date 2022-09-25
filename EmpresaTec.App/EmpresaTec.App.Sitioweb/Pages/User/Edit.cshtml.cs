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
        private IRepositorioUser _repoUser {get; set;}
        [BindProperty]
        public User user {get; set;}

        public EditModel()
        {
            _repoUser = new RepositorioUser (new EmpresaTec.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id)
        {
            user = _repoUser.ObtenerPorId(id);
            if (user == null)
            {
                return RedirectToPage("/User/List");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost(User user)
        {
            _repoUser.Modificar(user);
            return RedirectToPage("/User/List");
        }
    }
}
