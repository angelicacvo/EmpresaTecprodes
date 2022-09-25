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
    public class ListModelA : PageModel
    {
        public IEnumerable<ActualState> actualStates {get; set;}
        private IRepositorioActualState _repoActualState;

        public ListModelA()
        {
            _repoActualState = new RepositorioActualState (new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        public void OnGet() 
        {
            actualStates = _repoActualState.ObtenerTodos();
        }
    }
}
