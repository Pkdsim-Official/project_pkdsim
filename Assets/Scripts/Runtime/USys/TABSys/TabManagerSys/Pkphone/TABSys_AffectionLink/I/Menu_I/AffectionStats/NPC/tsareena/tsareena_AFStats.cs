using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Tsareena;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Tsareena
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