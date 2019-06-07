
using Domain.Entities;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Core.InjectionDependency
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {

        private IKernel ninjectKernnel;

        public NinjectControllerFactory()
        {
            ninjectKernnel = new StandardKernel();
            AdBinding();
        }

        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //    return controllerType == null ? null : (IController)ninjectKernnel.Get(controllerType);
        //}

        private void AdBinding()
        {
            // injeção da entidade Login
            //ninjectKernnel.Bind<Interfaces.IRepository<User>>().To<Repository.BaseRepository<Repository.UserRepository>>();
            ninjectKernnel.Bind<Domain.Core.Interfaces.IRepository<Domain.Entities.EntitiModel.User>>().To<Domain.Core.Repository.UserRepository>();
            ninjectKernnel.Bind<Domain.Core.Interfaces.IRepository<Domain.Entities.EntitiModel.Cadastro>>().To<Domain.Core.Repository.CadastroRepository>();
        }



    }
}
