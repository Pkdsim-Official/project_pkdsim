using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Vaporeon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Vaporeon
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