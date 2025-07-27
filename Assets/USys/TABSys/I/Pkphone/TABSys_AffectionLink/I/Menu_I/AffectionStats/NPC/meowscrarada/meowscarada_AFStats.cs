using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Meowscarada;
using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Base;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats.Meowscarada
{
    public class Meowscarada_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Meowscarada_LL Meowscarada_LL;
        public HeartBarUI heartBarUI;
        public void Meowscarada_AFStatsI()
        {
            Meowscarada_LL.Meowscarada_LLI();
            int activeLevels = Meowscarada_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}