using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Absol;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Absol
{
    public class Absol_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Absol_LL Absol_LL;
        public HeartBarUI heartBarUI;
        public void Absol_AFStatsI()
        {
            Absol_LL.Absol_LLI();
            int activeLevels = Absol_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}