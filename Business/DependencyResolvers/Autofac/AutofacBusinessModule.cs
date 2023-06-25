using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductsToSalesManager>().As<IProductsToSalesService>().SingleInstance();
            builder.RegisterType<ProductsToSalesDal>().As<IProductsToSalesDal>().SingleInstance();
        }
    }
}
