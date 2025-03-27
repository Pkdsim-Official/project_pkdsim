using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Beedrill;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Beedrill
{
    public class Beedrill_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Beedrill_LL Beedrill_LL;
        public HeartBarUI heartBarUI;
        public void Beedrill_AFStatsI()
        {
            Beedrill_LL.Beedrill_LLI();
            int activeLevels = Beedrill_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}