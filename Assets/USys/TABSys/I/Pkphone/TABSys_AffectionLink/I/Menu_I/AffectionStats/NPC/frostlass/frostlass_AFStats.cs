using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Frostlass;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Frostlass
{
    public class Frostlass_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Frostlass_LL Frostlass_LL;
        public HeartBarUI heartBarUI;
        public void Frostlass_AFStatsI()
        {
            Frostlass_LL.Frostlass_LLI();
            int activeLevels = Frostlass_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}