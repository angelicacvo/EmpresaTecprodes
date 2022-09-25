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
        private IRepositorioProject _repoProject{get; set;}
        [BindProperty]
        public Project project {get; set;}

        public EditModel()
        {
            _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext());
        }

        public IActionResult OnGet(int id) //Se pone el IActionResult porque hay un return
        {
            project = _repoProject.ObtenerPorId(id);
            if (project == null)
            {
                return RedirectToPage("/Project/List");
            }
            else
            {
                return Page();
            }

        }

        public IActionResult OnPost(Project project)
        {
            _repoProject.Modificar(project);
            return RedirectToPage("/Project/List");
        }
    }
}
