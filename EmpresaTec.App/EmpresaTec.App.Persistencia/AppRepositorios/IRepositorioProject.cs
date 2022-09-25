using System.Collections.Generic;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public interface IRepositorioProject
    {
        Project Agregar(Project projectnuevo); //métodos
        Project Modificar(Project projectactualizar);
        void Eliminar(int id);
        Project ObtenerPorId(int id);
        IEnumerable<Project>ObtenerTodos();
    }
}