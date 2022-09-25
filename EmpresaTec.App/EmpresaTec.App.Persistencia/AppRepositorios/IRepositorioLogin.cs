using System.Collections.Generic;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public interface IRepositorioLogin
    {
        Login Agregar(Login loginnuevo); //métodos
        Login Modificar(Login loginactualizar);
        void Eliminar(int id);
        Login ObtenerPorId(int id);
        IEnumerable<Login>ObtenerTodos();
    }
}