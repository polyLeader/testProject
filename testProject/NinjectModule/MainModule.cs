using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testProject.NinjectModule
{
    using Ninject.Modules;
    using Ninject.Web.Common;

    using testProject.BusinessLogic.Core;

    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DatabaseContext>().ToMethod(it => new DatabaseContext()).InRequestScope();
            this.Bind<IStudentRepository>().To<StudentRepository>().InRequestScope();
        }
    }
}