using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Primarina;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Primarina
{
    public class Primarina_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Primarina_LL Primarina_LL;
        public HeartBarUI heartBarUI;
        public void Primarina_AFStatsI()
        {
            Primarina_LL.Primarina_LLI();
            int activeLevels = Primarina_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}