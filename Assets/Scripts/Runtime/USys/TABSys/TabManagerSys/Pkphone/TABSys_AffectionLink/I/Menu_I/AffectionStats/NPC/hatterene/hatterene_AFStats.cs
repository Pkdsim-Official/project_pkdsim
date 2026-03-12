using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Hatterene;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Hatterene
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