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
        [BindProperty]
        public Project project {get; set;}

        public CreateModelP()
        {
            _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext());
        }
        
        public void OnGet()
        {
        }

        public IActionResult onPost (Project project)
        {
            if (ModelState.IsValid)
            {
                _repoProject.Agregar(project);
                return RedirectToPage("/Project/List");
            }
            else
            {
                return Page();
            }
            
            
        }
    }
}
