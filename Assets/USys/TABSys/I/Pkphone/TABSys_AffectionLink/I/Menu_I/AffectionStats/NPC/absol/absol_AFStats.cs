using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Absol;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Absol
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