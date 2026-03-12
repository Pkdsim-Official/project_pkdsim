using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Jolteon;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Jolteon
{
    public class Sylveon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Sylveon_LL Sylveon_LL;
        public HeartBarUI heartBarUI;
        public void Sylveon_AFStatsI()
        {
            Sylveon_LL.Sylveon_LLI();
            int activeLevels = Sylveon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}