using System.Collections.Generic;
using EmpresaTec.App.Dominio;
using System.Linq;

namespace EmpresaTec.App.Persistencia
{
    public class RepositorioUser : IRepositorioUser
    {
        private readonly ApplicationContext _appContext;
        public RepositorioUser(ApplicationContext contexto)
        {
            _appContext = contexto;
        }


        //metodos
        User IRepositorioUser.Agregar(User usernuevo) 
        {
            var UserA = _appContext.users.Add(usernuevo);
            _appContext.SaveChanges();
            return UserA.Entity;
        }

        User IRepositorioUser.Modificar(User useractualizar)
        {
            var UserU = _appContext.users.FirstOrDefault(c => c.userId == useractualizar.userId);
            if (UserU != null)
            {
                UserU.name =useractualizar.name;
                UserU.IdNumber =useractualizar.IdNumber;
                UserU.phoneNumber =useractualizar.phoneNumber;
                UserU.address =useractualizar.address;
                _appContext.SaveChanges();
            }
            return UserU;
        }

        void IRepositorioUser.Eliminar(int id)
        {
            var UserB = _appContext.users.FirstOrDefault(c => c.userId == id);
            if (UserB != null)
            {
                _appContext.users.Remove(UserB);
                _appContext.SaveChanges();
            }
        }

        User IRepositorioUser.ObtenerPorId(int id)
        {
            return _appContext.users.Where(c => c.userId == id).Select(c => new User
            {
                userId = c.userId,
                name = c.name,
                IdNumber = c.IdNumber,
                phoneNumber = c.phoneNumber,
                address = c.address,
                projectId = c.projectId,
                project = c.project
            }).FirstOrDefault(); 
        }

        IEnumerable<User> IRepositorioUser.ObtenerTodos()
        {
            return _appContext.users.Select(c => new User
            {
                userId = c.userId,
                name = c.name,
                IdNumber = c.IdNumber,
                phoneNumber = c.phoneNumber,
                address = c.address,
                projectId = c.projectId,
                project = c.project
    
            }).ToList();;
        }
    }
}