using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Zoroark;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Zoroark
{
    public class Zoroark_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Zoroark_LL Zoroark_LL;
        public HeartBarUI heartBarUI;
        public void Zoroark_AFStatsI()
        {
            Zoroark_LL.Zoroark_LLI();
            int activeLevels = Zoroark_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}