using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace ConversationStarter
{
    [DependsOn(typeof(ConversationStarterCoreModule), typeof(AbpAutoMapperModule))]
    public class ConversationStarterApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
