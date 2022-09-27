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
    public class CreateModelA : PageModel
    {
        private IRepositorioActualState _repoActualState {get; set;}
        [BindProperty]
        public ActualState actualState {get; set;}

        public CreateModelA()
        {
            _repoActualState = new RepositorioActualState(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost (ActualState actualState)
        {
            _repoActualState.Agregar(actualState);
            return RedirectToPage("/ActualState/List");

        }
    }
}