using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Gardevoir;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Gardevoir
{
    public class Gardevoir_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Gardevoir_LL Gardevoir_LL;
        public HeartBarUI heartBarUI;
        public void Gardevoir_AFStatsI()
        {
            Gardevoir_LL.Gardevoir_LLI();
            int activeLevels = Gardevoir_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}