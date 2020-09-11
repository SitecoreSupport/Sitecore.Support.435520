namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
    using Sitecore.Analytics;

    public class Unsubscribe : Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.Unsubscribe
    {
        protected override bool IsTrackerEnabled => Tracker.Current != null;
    }
}