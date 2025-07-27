using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Braixen;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Braixen
{
    public class Braixen_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Braixen_LL Braixen_LL;
        public HeartBarUI heartBarUI;
        public void Braixen_AFStatsI()
        {
            Braixen_LL.Braixen_LLI();
            int activeLevels = Braixen_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}