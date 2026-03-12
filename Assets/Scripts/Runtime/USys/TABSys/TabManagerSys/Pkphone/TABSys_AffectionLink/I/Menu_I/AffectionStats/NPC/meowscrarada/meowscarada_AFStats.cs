using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Meowscarada;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Meowscarada
{
    public class Meowscarada_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Meowscarada_LL Meowscarada_LL;
        public HeartBarUI heartBarUI;
        public void Meowscarada_AFStatsI()
        {
            Meowscarada_LL.Meowscarada_LLI();
            int activeLevels = Meowscarada_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}