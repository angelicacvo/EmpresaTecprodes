using System.Collections.Generic;
using EmpresaTec.App.Dominio;
using System.Linq;

namespace EmpresaTec.App.Persistencia
{
    public class RepositorioProject : IRepositorioProject
    {
        private readonly ApplicationContext _appContext; //Se pone así en todos los otros repositorios, se crea una instancia del applicationContext(DB)
        public RepositorioProject(ApplicationContext contexto) //constructor
        {
            _appContext = contexto;
        }


        //metodos
        Project IRepositorioProject.Agregar(Project projectnuevo) //IRepositorioProject para implementar lo del otro repositorio aquí
        //Código para agregar una entidad
        {
            var ProjectA = _appContext.Projects.Add(projectnuevo);
            _appContext.SaveChanges();
            return ProjectA.Entity;
        }

        Project IRepositorioProject.Modificar(Project projectactualizar)
        {
            var ProjectU = _appContext.Projects.FirstOrDefault(c => c.projectId == projectactualizar.projectId);
            if (ProjectU != null)
            {
                ProjectU.name = projectactualizar.name;
                ProjectU.code = projectactualizar.code;
                ProjectU.stimatedDate = projectactualizar.stimatedDate;
                ProjectU.cost = projectactualizar.cost;
                ProjectU.startDate = projectactualizar.startDate;
                ProjectU.description = projectactualizar.description;
                ProjectU.services = projectactualizar.services;
                _appContext.SaveChanges();
            }
            return ProjectU;
        }

        void IRepositorioProject.Eliminar(int id)
        {
            var ProjectB = _appContext.Projects.FirstOrDefault(c => c.projectId == id);
            if (ProjectB != null)
            {
                _appContext.Projects.Remove(ProjectB);
                _appContext.SaveChanges();
            }
        }

        Project IRepositorioProject.ObtenerPorId(int id)
        {
            return _appContext.Projects.FirstOrDefault(c => c.projectId == id); //Que me devuelva el primero o null
        }

        IEnumerable<Project> IRepositorioProject.ObtenerTodos()
        {
            return _appContext.Projects;
        }
    }
}