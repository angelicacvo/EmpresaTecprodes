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
    public class DeleteModel : PageModel
    {
        public IRepositorioProject _repoProject {get; set;}
        [BindProperty]
        public Project project {get; set;}

        public DeleteModel()
        {
            _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet(int id)
        {
            project = _repoProject.ObtenerPorId(id);
        }

        public IActionResult OnPost()
        {
            Console.WriteLine(project.projectId);
            _repoProject.Eliminar(project.projectId);
            return RedirectToPage("/Project/List");
        }
    }
}
