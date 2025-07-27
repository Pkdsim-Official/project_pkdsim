using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Blaziken;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Blaziken
{
    public class Blaziken_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Blaziken_LL Blaziken_LL;
        public HeartBarUI heartBarUI;
        public void Blaziken_AFStatsI()
        {
            Blaziken_LL.Blaziken_LLI();
            int activeLevels = Blaziken_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}