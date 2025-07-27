using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Cinderace;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Cinderace
{
    public class Cinderace_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Cinderace_LL Cinderace_LL;
        public HeartBarUI heartBarUI;
        public void Cinderace_AFStatsI()
        {
            Cinderace_LL.Cinderace_LLI();
            int activeLevels = Cinderace_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}