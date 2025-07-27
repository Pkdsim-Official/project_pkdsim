using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Tsareena;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Tsareena
{
    public class Tsareena_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Tsareena_LL Tsareena_LL;
        public HeartBarUI heartBarUI;
        public void Tsareena_AFStatsI()
        {
            Tsareena_LL.Tsareena_LLI();
            int activeLevels = Tsareena_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}