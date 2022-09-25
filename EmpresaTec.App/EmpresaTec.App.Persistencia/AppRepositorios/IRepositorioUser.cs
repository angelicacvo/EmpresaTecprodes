using System.Collections.Generic;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public interface IRepositorioUser
    {
        User Agregar(User usernuevo); //métodos
        User Modificar(User useractualizar);
        void Eliminar(int id);
        User ObtenerPorId(int id);
        IEnumerable<User>ObtenerTodos();
    }
}