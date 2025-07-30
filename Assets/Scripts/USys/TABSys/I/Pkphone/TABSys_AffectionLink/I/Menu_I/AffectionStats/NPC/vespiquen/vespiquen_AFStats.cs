using project_pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Vespiquen;
using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Vespiquen
{
    public class Vespiquen_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Vespiquen_LL Vespiquen_LL;
        public HeartBarUI heartBarUI;
        public void Vespiquen_AFStatsI()
        {
            Vespiquen_LL.Vespiquen_LLI();
            int activeLevels = Vespiquen_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}