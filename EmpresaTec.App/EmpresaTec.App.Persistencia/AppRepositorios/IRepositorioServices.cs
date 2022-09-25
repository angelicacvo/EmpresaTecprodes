using System.Collections.Generic;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public interface IRepositorioServices
    {
        Services Agregar(Services servicesnuevo); //métodos
        Services Modificar(Services servicesactualizar);
        void Eliminar(int id);
        Services ObtenerPorId(int id);
        IEnumerable<Services>ObtenerTodos();
    }
}