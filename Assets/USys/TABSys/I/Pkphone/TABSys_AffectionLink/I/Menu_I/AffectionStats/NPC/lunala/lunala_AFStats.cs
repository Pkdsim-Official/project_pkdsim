using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Lunala;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Lunala
{
    public class Lunala_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lunala_LL Lunala_LL;
        public HeartBarUI heartBarUI;
        public void Lunala_AFStatsI()
        {
            Lunala_LL.Lunala_LLI();
            int activeLevels = Lunala_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}