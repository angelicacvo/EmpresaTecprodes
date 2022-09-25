using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//Agregar dominio y persistencia
using EmpresaTec.App.Dominio;
using EmpresaTec.App.Persistencia;


namespace EmpresaTec.App.Sitioweb.App.Pages
{
    public class ListModel : PageModel
    {
        public IEnumerable<Project> projects {get; set;}
        private IRepositorioProject _repoProject;

        public ListModel() //Constructor para que se ingrese a la página se cargue la info del repositorio
        {
            _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        public void OnGet() 
        {
            projects = _repoProject.ObtenerTodos();
        }
    }
}
