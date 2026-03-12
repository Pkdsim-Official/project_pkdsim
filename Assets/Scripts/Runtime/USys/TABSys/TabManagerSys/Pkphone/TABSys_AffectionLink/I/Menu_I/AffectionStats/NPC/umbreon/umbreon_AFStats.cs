using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Umbreon;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Umbreon
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