using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Espeon;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Espeon
{
    public class Espeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Espeon_LL Espeon_LL;
        public HeartBarUI heartBarUI;
        public void Espeon_AFStatsI()
        {
            Espeon_LL.Espeon_LLI();
            int activeLevels = Espeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}