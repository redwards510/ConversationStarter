using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Zero.Configuration;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using ConversationStarter.Api;
using Hangfire;

namespace ConversationStarter.Web
{
    [DependsOn(
        typeof(ConversationStarterDataModule),
        typeof(ConversationStarterApplicationModule),
        typeof(ConversationStarterWebApiModule),
        typeof(AbpWebSignalRModule),
        typeof(AbpHangfireModule),
        typeof(AbpWebMvcModule))]
    public class ConversationStarterWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<ConversationStarterNavigationProvider>();

            //Configure Hangfire
            Configuration.BackgroundJobs.UseHangfire(configuration =>
            {
                configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
