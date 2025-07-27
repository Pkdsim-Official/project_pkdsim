using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Hatterene;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Hatterene
{
    public class Hatterene_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Hatterene_LL Hatterene_LL;
        public HeartBarUI heartBarUI;
        public void Hatterene_AFStatsI()
        {
            Hatterene_LL.Hatterene_LLI();
            int activeLevels = Hatterene_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}