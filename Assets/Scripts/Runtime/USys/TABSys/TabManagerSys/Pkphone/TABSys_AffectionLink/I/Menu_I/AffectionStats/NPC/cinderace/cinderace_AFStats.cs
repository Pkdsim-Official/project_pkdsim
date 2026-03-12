using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Cinderace;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Cinderace
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