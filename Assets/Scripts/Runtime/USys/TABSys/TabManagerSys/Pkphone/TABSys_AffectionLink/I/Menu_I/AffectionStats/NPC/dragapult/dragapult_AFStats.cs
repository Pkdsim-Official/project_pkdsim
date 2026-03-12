using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Dragapult;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Dragapult
{
    public class Dragapult_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Dragapult_LL Dragapult_LL;
        public HeartBarUI heartBarUI;
        public void Dragapult_AFStatsI()
        {
            Dragapult_LL.Dragapult_LLI();
            int activeLevels = Dragapult_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}