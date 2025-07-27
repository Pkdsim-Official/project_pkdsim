using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Pheromosa;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Pheromosa
{
    public class Pheromosa_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Pheromosa_LL Pheromosa_LL;
        public HeartBarUI heartBarUI;
        public void Pheromosa_AFStatsI()
        {
            Pheromosa_LL.Pheromosa_LLI();
            int activeLevels = Pheromosa_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}