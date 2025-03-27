using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Leafeon;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Leafeon
{
    public class Leafeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Leafeon_LL Leafeon_LL;
        public HeartBarUI heartBarUI;
        public void Leafeon_AFStatsI()
        {
            Leafeon_LL.Leafeon_LLI();
            int activeLevels = Leafeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}