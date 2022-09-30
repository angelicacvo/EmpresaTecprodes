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
    public class CreateModelP : PageModel
    {
        private IRepositorioProject _repoProject {get; set;}
        private IRepositorioActualState _repoActualState {get; set;}
        private IRepositorioServices _repoServices {get; set;}
        [BindProperty]
        public Project project {get; set;}
        public IEnumerable<ActualState> actualStates {get; set;}
        public IEnumerable<Services> services {get; set;}


        public CreateModelP()
        {
            _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGetA()
        {
            actualStates = _repoActualState.ObtenerTodos();
        }

        public void OnGetS()
        {
            services = _repoServices.ObtenerTodos();
        }

        public IActionResult OnPost (Project project)
        {
            _repoProject.Agregar(project);
            return RedirectToPage("/Project/List");
           
        }
    }
}
