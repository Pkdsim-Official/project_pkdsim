using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Salazzle;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Salazzle
{
    public class Salazzle_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Salazzle_LL Salazzle_LL;
        public HeartBarUI heartBarUI;
        public void Salazzle_AFStatsI()
        {
            Salazzle_LL.Salazzle_LLI();
            int activeLevels = Salazzle_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}