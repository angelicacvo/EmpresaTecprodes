using System.Collections.Generic;
using EmpresaTec.App.Dominio;

namespace EmpresaTec.App.Persistencia
{
    public interface IRepositorioActualState
    {
        ActualState Agregar(ActualState actualstatenuevo); //métodos
        ActualState Modificar(ActualState actualstateactualizar);
        void Eliminar(int id);
        ActualState ObtenerPorId(int id);
        IEnumerable<ActualState>ObtenerTodos();
    }
}
