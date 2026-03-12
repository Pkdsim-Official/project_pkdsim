using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Lucario;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Lucario
{
    public class Lucario_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lucario_LL Lucario_LL;
        public HeartBarUI heartBarUI;
        public void Lucario_AFStatsI()
        {
            Lucario_LL.Lucario_LLI();
            int activeLevels = Lucario_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}