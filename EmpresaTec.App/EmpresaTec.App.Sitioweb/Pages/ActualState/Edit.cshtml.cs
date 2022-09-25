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
    public class EditModelA : PageModel
    {
        private IRepositorioActualState _repoActualState {get; set;}
        [BindProperty]
        public ActualState actualState {get; set;}

        public EditModelA()
        {
            _repoActualState = new RepositorioActualState(new EmpresaTec.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id) 
        {
            actualState = _repoActualState.ObtenerPorId(id);
            if (actualState == null)
            {
                return RedirectToPage("/Project/ActualState");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost(ActualState actualState)
        {
            _repoActualState.Modificar(actualState);
            return RedirectToPage("/actualState/List");
        }
    }
}

