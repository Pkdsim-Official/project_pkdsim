
using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Transitions.AniData_SI2ST;
using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Transitions.AniData_ST2SI;

namespace Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Transitions
{
    public class Garc_AniData_Transition
    {
        private Garc_AniData_Sitting2Standing Garc_AniData_SI2ST;
        private Garc_AniData_Standing2Sitting Garc_AniData_ST2SI;

        public void Garc_AniData_SI2ST_I()
        {
            Garc_AniData_SI2ST.Garc_AniData_Sitting2StandingI();
        }

        public void Garc_AniData_ST2SI_I()
        {
            Garc_AniData_ST2SI.Garc_AniData_Standing2SittingI();
        }
    }
}