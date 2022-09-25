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
    public class DeleteModelA : PageModel
    {
        public IRepositorioActualState _repoActualState {get; set;}
        [BindProperty]
        public ActualState actualState {get; set;}

        public DeleteModelA()
        {
            _repoActualState = new RepositorioActualState(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet(int id)
        {
            actualState = _repoActualState.ObtenerPorId(id);
        }

        public IActionResult OnPost()
        {
            Console.WriteLine(actualState.actualStateId);
            _repoActualState.Eliminar(actualState.actualStateId);
            return RedirectToPage("/ActualState/List");
        }
    }
}

