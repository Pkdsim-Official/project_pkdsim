using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Umbreon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Umbreon
{
    public class Umbreon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Umbreon_LL Umbreon_LL;
        public HeartBarUI heartBarUI; 
        public void Umbreon_AFStatsI()
        {
            Umbreon_LL.Umbreon_LLI();
            int activeLevels = Umbreon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}