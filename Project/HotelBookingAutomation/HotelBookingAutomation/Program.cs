using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Business.Concrete;
using HotelBookingAutomation.Core.Factories;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.DataAcess.Concrete.PostgreSql;
using HotelBookingAutomation.Forms;
using HotelBookingAutomation.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace HotelBookingAutomation
{
    enum Roles{
        MANAGER=0,
        FRONTDESK=1,
        SUPERVISOR=2
        };
    internal static class Program
    {
        public const string appName = "HotelBookingAutomation-a771da5dcc6218160905311d9d38503e";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var mutex = new Mutex(false,appName);
            if (!mutex.WaitOne(0, false))
            {
                MessageBox.Show("One Application Instance Already Working !!!");
                return;
            }
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            IDbFactory dbFactory = new PotgresDbFactory(ConfigurationManager.ConnectionStrings["HotelBookingDB"].ConnectionString);
            services = new ServiceCollection();

            services.AddSingleton<IDbFactory>(dbFactory);
            services.AddTransient<IUserDal, PostgresUserDal>();
            services.AddTransient<IRoleDal, PostgresRoleDal>();
            services.AddTransient<ICategoryDal, PostgresCategoryDal>();
            services.AddTransient<ICustomerDal, PostgresCustomerDal>();
            services.AddTransient<IRoomPriceDal, PostgresRoomPriceDal>();
            services.AddTransient<IBookingDal, PostgresBookingDal>();
            services.AddTransient<IRoomDal, PostgresRoomDal>();
            services.AddTransient<IUserService, UserManager>();
            services.AddTransient<IAuthService, AuthManager>();
            services.AddTransient<IRoleService, RoleManager>();
            services.AddTransient<ICategoryService, CategoryManager>();
            services.AddTransient<ICustomerService, CustomerManager>();
            services.AddTransient<IRoomPriceService, RoomPriceManager>();
            services.AddTransient<IRoomService, RoomManager>();
            services.AddTransient<IBookingService, BookingManager>();
            services.AddTransient<FrontDeskForm>();
            services.AddTransient<SupervisorForm>();
            services.AddTransient<RolesForm>();
            services.AddTransient<CategoriesForm>();
            services.AddTransient<UsersForm>();
            services.AddTransient<CustomersForm>();
            services.AddTransient<RoomPricesForm>();
            services.AddTransient<RoomsForm>();
            services.AddTransient<BookARoomForm>();
            services.AddTransient<ManagerForm>();
            services.AddTransient<LoginForm>();

            serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize(); 
            Application.SetCompatibleTextRenderingDefault(false);

            var login=serviceProvider.GetService<LoginForm>();
            login.Action += Handle_Login;
            DialogResult result=login.ShowDialog();
            if (result == DialogResult.OK)
            {
                switch (userRole)
                {
                    case Roles.MANAGER:
                        Application.Run(serviceProvider.GetService<ManagerForm>());
                        break;
                    case Roles.FRONTDESK:
                        Application.Run(serviceProvider.GetService<FrontDeskForm>());
                        break;
                    case Roles.SUPERVISOR:
                        Application.Run(serviceProvider.GetService<SupervisorForm>());
                        break;
                    default:
                        Application.Exit();
                        break;

                }
            }
            
        }
        static ServiceProvider serviceProvider;
        static ServiceCollection services;
        static Roles userRole;
        public static async void Handle_Login(object sender,object obj,Core.Events.Action action)
        {
            var form =(Form)sender;
            var roles=await serviceProvider.GetRequiredService<IRoleService>().GetAllRoles() as List<Role>;
            var user = (User)obj;
            var role = roles.FirstOrDefault(r=>r.ID==user.RoleID);
            if (role != null)
            {
                form.Close();
                form.DialogResult = DialogResult.OK;
                if (role.RoleName == "Manager")
                    userRole = Roles.MANAGER;
                else if (role.RoleName == "FrontDesk")
                    userRole= Roles.FRONTDESK;
                else if(role.RoleName =="Supervisor")
                    userRole= Roles.SUPERVISOR;
            }
        }
    }
}