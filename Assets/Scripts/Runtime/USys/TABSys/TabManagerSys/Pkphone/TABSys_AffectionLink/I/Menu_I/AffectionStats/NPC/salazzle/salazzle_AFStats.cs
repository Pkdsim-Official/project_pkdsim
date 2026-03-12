using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Salazzle;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Salazzle
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