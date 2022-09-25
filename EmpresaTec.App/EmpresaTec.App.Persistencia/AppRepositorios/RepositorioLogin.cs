using System.Collections.Generic;
using EmpresaTec.App.Dominio;
using System.Linq;

namespace EmpresaTec.App.Persistencia
{
    public class RepositorioLogin : IRepositorioLogin
    {
        private readonly ApplicationContext _appContext;
        public RepositorioLogin(ApplicationContext contexto)
        {
            _appContext = contexto;
        }


        //metodos
        Login IRepositorioLogin.Agregar(Login loginnuevo) 
        {
            var LoginA = _appContext.Logins.Add(loginnuevo);
            _appContext.SaveChanges();
            return LoginA.Entity;
        }

        Login IRepositorioLogin.Modificar(Login loginactualizar)
        {
            var LoginU = _appContext.Logins.FirstOrDefault(c => c.loginId == loginactualizar.loginId);
            if (LoginU != null)
            {
                LoginU.email =loginactualizar.email;
                LoginU.password = loginactualizar.password;
                LoginU.user = loginactualizar.user;
                LoginU.lastConnection = loginactualizar.lastConnection;
                _appContext.SaveChanges();
            }
            return LoginU;
        }

        void IRepositorioLogin.Eliminar(int id)
        {
            var LoginB = _appContext.Logins.FirstOrDefault(c => c.loginId == id);
            if (LoginB != null)
            {
                _appContext.Logins.Remove(LoginB);
                _appContext.SaveChanges();
            }
        }

        Login IRepositorioLogin.ObtenerPorId(int id)
        {
            return _appContext.Logins.FirstOrDefault(c => c.loginId == id);
        }

        IEnumerable<Login> IRepositorioLogin.ObtenerTodos()
        {
            return _appContext.Logins;
        }
    }
}