using Abp.Web.Mvc.Views;

namespace ConversationStarter.Web.Views
{
    public abstract class ConversationStarterWebViewPageBase : ConversationStarterWebViewPageBase<dynamic>
    {

    }

    public abstract class ConversationStarterWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ConversationStarterWebViewPageBase()
        {
            LocalizationSourceName = ConversationStarterConsts.LocalizationSourceName;
        }
    }
}