using System;
using EmpresaTec.App.Dominio;
using EmpresaTec.App.Persistencia;

namespace EmpresaTec.App.Consola
{
    class Program
    {
        private static IRepositorioProject _repoProject = new RepositorioProject(new EmpresaTec.App.Persistencia.ApplicationContext()); 
        private static IRepositorioActualState _repoActualState = new RepositorioActualState(new EmpresaTec.App.Persistencia.ApplicationContext());
        private static IRepositorioLogin _repoLogin = new RepositorioLogin(new EmpresaTec.App.Persistencia.ApplicationContext());
        private static IRepositorioServices _repoServices = new RepositorioServices(new EmpresaTec.App.Persistencia.ApplicationContext());
        private static IRepositorioUser _repoUser = new RepositorioUser(new EmpresaTec.App.Persistencia.ApplicationContext());

        
        static void Main(string[] args)
        {
            Console.WriteLine("TECPRODES");
            //AgregarProject();    
            //ModificarProject();          
            //EliminarProject();
            //BuscarProject();
            //ObtenerProject(); 
            //AgregarActualState();
            //ModificarActualState();
            //EliminarActualState();
            //BuscarActualState();
            //ObtenerActualState();
            //AgregarLogin();
            //ModificarLogin();
            //EliminarLogin();
            //BuscarLogin();
            //ObtenerLogin();
            //AgregarServices();
            //ModificarServices();
            //EliminarServices();
            //BuscarServices();
            //ObtenerServices();
            //AgregarUser();
            //ModificarUser();
            //EliminarUser();
            //BuscarUser();
            //ObtenerUser();

        }

        //User

        //ObtenerUser
        private static void ObtenerUser()
        {
            var User = _repoUser.ObtenerTodos();
            foreach (var user in User)
            {
                Console.WriteLine(user.name + " " + user.IdNumber + " " + user.phoneNumber + " " + user.address);         }
        }


        //BuscarUser
        private static void BuscarUser()
        {
            Console.WriteLine("Ingrese el ID del usuario a buscar");
            int id = int.Parse(Console.ReadLine());
            User user = _repoUser.ObtenerPorId(id);
            Console.WriteLine("Los datos del usuario son: " + user.name + " " + user.IdNumber + " " + user.phoneNumber + " " + user.address);

        }

        //EliminarUser
        private static void EliminarUser()
        {
            Console.WriteLine("Ingrese el id del usuario a eliminar");
            int id = int.Parse(Console.ReadLine());
            _repoUser.Eliminar(id);
        }

        //ModificarUser
        public static void ModificarUser()
        {
            Console.WriteLine("Ingrese el id del usuario a modificar");
            int id = int.Parse(Console.ReadLine());
            User user = _repoUser.ObtenerPorId(id);
            Console.WriteLine("Ingrese el nombre del usuario a modificar");
            user.name = Console.ReadLine();
            Console.WriteLine("Ingrese el número de identificación del usuario a modificar");
            user.IdNumber = Console.ReadLine();
            Console.WriteLine("Ingrese el número de teléfono del usuario a modificar");
            user.phoneNumber = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del usuario a modificar");
            user.address = Console.ReadLine();

            _repoUser.Modificar(user);
        }

        //AgregarUser
        private static void AgregarUser ()
        {
            User user = new User();
            Console.WriteLine("Ingrese el nombre completo ");
            user.name = Console.ReadLine();
            Console.WriteLine("Ingrese el número de identificación ");
            user.IdNumber = Console.ReadLine();
            Console.WriteLine("Ingrese el número de teléfono o celular ");
            user.phoneNumber = Console.ReadLine();
            Console.WriteLine("Ingrese el correo ");
            user.address = Console.ReadLine();

            Console.WriteLine("Ingrese el id del proyecto");
            user.projectId = int.Parse(Console.ReadLine());
 
            _repoUser.Agregar(user);
        }

        //Services

        //ObtenerLogin
        private static void ObtenerServices()
        {
            var Services = _repoServices.ObtenerTodos();
            foreach (var services in Services)
            {
                Console.WriteLine(services.name + " " + services.description);
            }
        }

        //BuscarServices
        private static void BuscarServices()
        {
            Console.WriteLine("Ingrese el ID del servicio a buscar");
            int id = int.Parse(Console.ReadLine());
            Services services = _repoServices.ObtenerPorId(id);
            Console.WriteLine("Los datos del servicio son: " + services.name + " " + services.description);

        }
        

        //EliminarServices
        private static void EliminarServices()
        {
            Console.WriteLine("Ingrese el id del servicio a eliminar");
            int id = int.Parse(Console.ReadLine());
            _repoServices.Eliminar(id);
        }

        //ModificarServices
        public static void ModificarServices()
        {
            Console.WriteLine("Ingrese el id del servicio a modificar");
            int id = int.Parse(Console.ReadLine());
            Services services = _repoServices.ObtenerPorId(id);
            Console.WriteLine("Ingrese el nombre del servicio a modificar");
            services.name = Console.ReadLine();
            Console.WriteLine("Ingrese la descripción del servicio a modificar");
            services.description = Console.ReadLine();

            _repoServices.Modificar(services);
        }

        //AgregarServicio
        private static void AgregarServices ()
        {
            Services services = new Services();
            Console.WriteLine("Ingrese el nombre del servicio");
            services.name = Console.ReadLine();
            Console.WriteLine("Ingrese la descripción del servicio");
            services.description = Console.ReadLine();
 
            _repoServices.Agregar(services);
        }

        //Login

        //ObtenerLogin
        private static void ObtenerLogin()
        {
            var Login = _repoLogin.ObtenerTodos();
            foreach (var login in Login)
            {
                Console.WriteLine(login.email + " " + login.password + " " + login.lastConnection);

            }
        }

        //Buscar Login
        private static void BuscarLogin()
        {
            Console.WriteLine("Ingrese el ID del login a buscar");
            int id = int.Parse(Console.ReadLine());
            Login login = _repoLogin.ObtenerPorId(id);
            Console.WriteLine("Los datos del Login son: " + login.email + " " + login.password + " " + login.lastConnection);

        }
        
        //EliminarLogin
        private static void EliminarLogin()
        {
            Console.WriteLine("Ingrese el id del login a eliminar");
            int id = int.Parse(Console.ReadLine());
            _repoLogin.Eliminar(id);
        }


        //ModificarLogin
        public static void ModificarLogin()
        {
            Console.WriteLine("Ingrese el id del login a modificar");
            int id = int.Parse(Console.ReadLine());
            Login login= _repoLogin.ObtenerPorId(id);
            Console.WriteLine("Ingrese el email a modificar");
            login.email = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña a modificar");
            login.password = Console.ReadLine();

            _repoLogin.Modificar(login);
        }

        //AgregarLogin
        private static void AgregarLogin ()
        {
            //Instanciar la entidad
            Login login = new Login();
            //Pedir datos al usuario
            Console.WriteLine("Ingrese el email");
            login.email = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            login.password = Console.ReadLine();
            Console.WriteLine("La última conexión fue: ");
            login.lastConnection = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el id del usuario");
            login.UserId = int.Parse(Console.ReadLine());

            _repoLogin.Agregar(login);
        }

        //ActualState

        //ObtenerActualState
        private static void ObtenerActualState()
        {
            var ActualStates = _repoActualState.ObtenerTodos();
            foreach (var actualState in ActualStates)
            {
                Console.WriteLine(actualState.name);
            }
        }
        //BuscarActualState
         private static void BuscarActualState()
        {
            Console.WriteLine("Ingrese el ID del estado actual a buscar");
            int id = int.Parse(Console.ReadLine());
            ActualState actualState = _repoActualState.ObtenerPorId(id);
            Console.WriteLine("El estado actual es: " + actualState.name);
        }

        //EliminarActualState
        private static void EliminarActualState()
        {
            //Pedir Id del proyecto a eliminar
            Console.WriteLine("Ingrese el id del estado actual a eliminar");
            int id = int.Parse(Console.ReadLine());
            _repoActualState.Eliminar(id);
        }

        //ModificarActualState
        public static void ModificarActualState()
        {
            Console.WriteLine("Ingrese el id del estado actual a modificar");
            //Pedir los datos a modificar
            int id = int.Parse(Console.ReadLine());
            ActualState actualState = _repoActualState.ObtenerPorId(id);
            //Pedir los nuevos datos
            Console.WriteLine("Ingrese el nuevo estado actual del proyecto");
            actualState.name = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva descripción del estado");
            actualState.description = Console.ReadLine();

            _repoActualState.Modificar(actualState);
        }

        //AgregarActualState
        private static void AgregarActualState ()
        {
            ActualState actualState = new ActualState();
            Console.WriteLine("¿Cual es el estado actual del proyecto?");
            actualState.name = Console.ReadLine();
             Console.WriteLine("Descripción del estado");
            actualState.description = Console.ReadLine();

            _repoActualState.Agregar(actualState);
        }

        //Proyecto

        //ObtenerProject
        private static void ObtenerProject()
        {
            var Projects = _repoProject.ObtenerTodos();
            foreach (var project in Projects)
            {
                Console.WriteLine(project.name + " " + project.code);
            }
        }

        //BuscarProject
        private static void BuscarProject()
        {
            Console.WriteLine("Ingrese el ID del proyecto a buscar");
            int id = int.Parse(Console.ReadLine());
            Project project = _repoProject.ObtenerPorId(id);
            Console.WriteLine("El proyecto es: " + project.name + " con código: " + project.code);
        }

        //EliminarProject
        private static void EliminarProject()
        {
            //Pedir Id del proyecto a eliminar
            Console.WriteLine("Ingrese el id del Projecto a eliminar");
            int id = int.Parse(Console.ReadLine());
            _repoProject.Eliminar(id);
        }

        //ModificarProject
        public static void ModificarProject()
        {
            Console.WriteLine("Ingrese el id del Projecto a modificar");
            //Pedir los datos a modificar
            int id = int.Parse(Console.ReadLine());
            Project project = _repoProject.ObtenerPorId(id);
            //Pedir los nuevos datos
            Console.WriteLine("Ingrese el nuevo nombre");
            project.name = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo código");
            project.code = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha estimada");
            project.stimatedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo costo");
            project.cost = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de inicio");
            project.startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva descripción");
            project.description = Console.ReadLine();

            _repoProject.Modificar(project);
        }

        //AgregarProject
        public static void AgregarProject()
        {
            Console.WriteLine("Agregar un proyecto");
            //Instancias la entidad
            Project project = new Project();
            //Obtener los datos del proyecto
            Console.WriteLine("Escriba el nombre del proyecto");
            project.name = Console.ReadLine();
            Console.WriteLine("Escriba el código del proyecto");
            project.code = Console.ReadLine();
            Console.WriteLine("Escriba la fecha estimada del proyecto");
            project.stimatedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el costo del proyecto");
            project.cost = Console.ReadLine();
            Console.WriteLine("Escriba la fecha de inicio del proyecto");
            project.startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la descripción del proyecto");
            project.description = Console.ReadLine();

            Console.WriteLine("Ingrese el id del estado actual");
            project.actualStateId = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el id del servicio");
            project.servicesId = int.Parse(Console.ReadLine());

            //Invocamos el repositorio
            _repoProject.Agregar(project);

        }
    }
}

