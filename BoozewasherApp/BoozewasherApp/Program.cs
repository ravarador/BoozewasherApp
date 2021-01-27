
using BoozewasherApp.Forms;
using BoozewasherDomain.IRepositories;
using BoozewasherInfrastructure.Repositories;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            container = new Container();
            container.Register<IServiceRepository, ServiceRepository>(Lifestyle.Singleton);
            container.Register<IVehicleRepository, VehicleRepository>(Lifestyle.Singleton);
            container.Register<ITransactionRepository, TransactionRepository>(Lifestyle.Singleton);
            container.Register<IItemRepository, ItemRepository>(Lifestyle.Singleton);
            container.Register<ILoginRepository, LoginRepository>(Lifestyle.Singleton);
            container.Register<IBranchRepository, BranchRepository>(Lifestyle.Singleton);
            container.Register<IEmployeeRepository, EmployeeRepository>(Lifestyle.Singleton);
            //container.Register<ParentForm>(Lifestyle.Singleton);
            //container.Register<MainForm>(Lifestyle.Singleton);
            container.Register<LoginForm>(Lifestyle.Singleton);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(container.GetInstance<ParentForm>());
            //Application.Run(container.GetInstance<MainForm>());
            Application.Run(container.GetInstance<LoginForm>());
        }
    }
}
