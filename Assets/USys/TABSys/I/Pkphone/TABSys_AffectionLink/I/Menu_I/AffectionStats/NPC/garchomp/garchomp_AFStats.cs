
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Garchomp;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Garchomp
{
    public class Garchomp_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Garchomp_LL Garchomp_LL;
        public HeartBarUI heartBarUI;
        public void Garchomp_AFStatsI()
        {
            Garchomp_LL.Garchomp_LLI();
            int activeLevels = Garchomp_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);

        }
    }
}