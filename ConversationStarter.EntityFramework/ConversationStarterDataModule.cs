using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ConversationStarter.EntityFramework;

namespace ConversationStarter
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ConversationStarterCoreModule))]
    public class ConversationStarterDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
