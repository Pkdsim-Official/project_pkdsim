using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Glaceon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Glaceon
{
    public class Glaceon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Glaceon_LL Glaceon_LL;
        public HeartBarUI heartBarUI;
        public void Glaceon_AFStatsI()
        {
            Glaceon_LL.Glaceon_LLI();
            int activeLevels = Glaceon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}