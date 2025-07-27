using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Espeon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Espeon
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