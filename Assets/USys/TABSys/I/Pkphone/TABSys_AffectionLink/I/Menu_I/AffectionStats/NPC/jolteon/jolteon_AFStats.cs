using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Jolteon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Jolteon
{
    public class Jolteon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Jolteon_LL Jolteon_LL;
        public HeartBarUI heartBarUI;
        public void Jolteon_AFStatsI()
        {
            Jolteon_LL.Jolteon_LLI();
            int activeLevels = Jolteon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);

        }
    }
}