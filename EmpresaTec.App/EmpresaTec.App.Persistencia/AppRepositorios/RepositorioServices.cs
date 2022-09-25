using System.Collections.Generic;
using EmpresaTec.App.Dominio;
using System.Linq;

namespace EmpresaTec.App.Persistencia
{
    public class RepositorioServices : IRepositorioServices
    {
        private readonly ApplicationContext _appContext;
        public RepositorioServices(ApplicationContext contexto)
        {
            _appContext = contexto;
        }


        //metodos
        Services IRepositorioServices.Agregar(Services servicesnuevo) 
        {
            var ServicesA = _appContext.services.Add(servicesnuevo);
            _appContext.SaveChanges();
            return ServicesA.Entity;
        }

        Services IRepositorioServices.Modificar(Services servicesactualizar)
        {
            var ServicesU = _appContext.services.FirstOrDefault(c => c.servicesId == servicesactualizar.servicesId);
            if (ServicesU != null)
            {
                ServicesU.name =servicesactualizar.name;
                ServicesU.description =servicesactualizar.description;
                _appContext.SaveChanges();
            }
            return ServicesU;
        }

        void IRepositorioServices.Eliminar(int id)
        {
            var ServicesB = _appContext.services.FirstOrDefault(c => c.servicesId == id);
            if (ServicesB != null)
            {
                _appContext.services.Remove(ServicesB);
                _appContext.SaveChanges();
            }
        }

        Services IRepositorioServices.ObtenerPorId(int id)
        {
            return _appContext.services.FirstOrDefault(c => c.servicesId == id);
        }

        IEnumerable<Services> IRepositorioServices.ObtenerTodos()
        {
            return _appContext.services;
        }
    }
}