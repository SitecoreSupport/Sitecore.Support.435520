namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
    using Sitecore.Analytics;

    public class UnsubscribeFromAll : Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.UnsubscribeFromAll
    {
        protected override bool IsTrackerEnabled => Tracker.Current != null;
    }
}