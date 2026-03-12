using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Vaporeon;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Vaporeon
{
    public class Vaporeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Vaporeon_LL Vaporeon_LL;
        public HeartBarUI heartBarUI;
        public void Vaporeon_AFStatsI()
        {
            Vaporeon_LL.Vaporeon_LLI();
            int activeLevels = Vaporeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}