using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Lopunny;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Lopunny
{
    public class Lopunny_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lopunny_LL Lopunny_LL;
        public HeartBarUI heartBarUI;
        public void Lopunny_AFStatsI()
        {
            Lopunny_LL.Lopunny_LLI();
            int activeLevels = Lopunny_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}