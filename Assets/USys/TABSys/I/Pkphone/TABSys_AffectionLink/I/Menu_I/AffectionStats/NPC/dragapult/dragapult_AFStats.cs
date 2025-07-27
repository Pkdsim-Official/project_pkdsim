using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Dragapult;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Dragapult
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