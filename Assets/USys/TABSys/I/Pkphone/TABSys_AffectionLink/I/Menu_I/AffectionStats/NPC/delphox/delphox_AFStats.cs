using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Delphox;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Delphox
{
    public class Delphox_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Delphox_LL Delphox_LL;
        public HeartBarUI heartBarUI;
        public void Delphox_AFStatsI()
        {
            Delphox_LL.Delphox_LLI();
            int activeLevels = Delphox_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}