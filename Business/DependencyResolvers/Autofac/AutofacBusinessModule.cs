using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB.Utilities.ConnectionResolvers;
using DataAccess.Concrete.MongoDB;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<ReceiptManager>().As<IReceiptService>().SingleInstance();
            //builder.RegisterType<MongoDB_ReceiptDal>().As<IReceiptDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<MongoDB_EmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<ReceiptManager>().As<IReceiptService>().SingleInstance();
            builder.RegisterType<MongoDB_ReceiptDal>().As<IReceiptDal>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<MongoDB_EmployeeDal>().As<IEmployeeDal>().SingleInstance();

            builder.RegisterType<PaymentManager>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<MongoDB_PaymentDal>().As<IPaymentDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<MongoDB_UserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<MongoDB_ConnectionHelper>().As<IDatabase_ConnectionHelper>().SingleInstance();

            builder.RegisterType<ExpenceManager>().As<IExpenceService>().SingleInstance();
            builder.RegisterType<MongoDB_ExpenceDal>().As<IExpenceDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
