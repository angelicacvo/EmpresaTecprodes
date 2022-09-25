using System.Collections.Generic;
using EmpresaTec.App.Dominio;
using System.Linq;

namespace EmpresaTec.App.Persistencia
{
    public class RepositorioActualState : IRepositorioActualState
    {
        private readonly ApplicationContext _appContext;
        public RepositorioActualState(ApplicationContext contexto)
        {
            _appContext = contexto;
        }


        //metodos
        ActualState IRepositorioActualState.Agregar(ActualState actualstatenuevo) 
        //Código para agregar una entidad
        {
            var ActualStateA = _appContext.ActualStates.Add(actualstatenuevo);
            _appContext.SaveChanges();
            return ActualStateA.Entity;
        }

        ActualState IRepositorioActualState.Modificar(ActualState actualstateactualizar)
        {
            var ActualStateU = _appContext.ActualStates.FirstOrDefault(c => c.actualStateId == actualstateactualizar.actualStateId);
            if (ActualStateU != null)
            {
                ActualStateU.name =actualstateactualizar.name;
                ActualStateU.description =actualstateactualizar.description;
                _appContext.SaveChanges();
            }
            return ActualStateU;
        }

        void IRepositorioActualState.Eliminar(int id)
        {
            var ActualStateB = _appContext.ActualStates.FirstOrDefault(c => c.actualStateId == id);
            if (ActualStateB != null)
            {
                _appContext.ActualStates.Remove(ActualStateB);
                _appContext.SaveChanges();
            }
        }

        ActualState IRepositorioActualState.ObtenerPorId(int id)
        {
            return _appContext.ActualStates.FirstOrDefault(c => c.actualStateId == id); //Que me devuelva el primero o null
        }

        IEnumerable<ActualState> IRepositorioActualState.ObtenerTodos()
        {
            return _appContext.ActualStates;
        }
    }
}