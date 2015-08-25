// O Ninject é uma ferramenta de DI (Injeção de Dependencia), é ele que inicializa os objetos (variaveis) do contrutores
// ele é um parasita (ele sobe para a memoria) junto com o projeto. Quem monitora a subida e descida do projeto da memoria
// É a DLL WebActivator

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LGroup.UI.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LGroup.UI.Web.App_Start.NinjectWebCommon), "Stop")]

namespace LGroup.UI.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using LGroup.DataAccess.Contracts;
    using LGroup.DataAccess;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                
                // É nesse métodos do BOOTSTRAPPER (Inicialização) que temos que fazer as injeções as inicializações de classes
                // Aonde encontrar uma interface vai trocar, vai dar NEW em uma classe, DE/PARA

                kernel.Bind<IAmigoDataAccessObject>().To<AmigoDataAccessObject>();
                // Flexível a ponto de fazer MOC, com classes FAKES e não tem que modificar muitas coisas...
                //kernel.Bind<IAmigoDataAccessObject>().To<AmigoDataAccessFake>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
        }        
    }
}
