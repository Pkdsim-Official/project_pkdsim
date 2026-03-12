
using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Transitions.AniData_SI2ST;
using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Transitions.AniData_ST2SI;

namespace Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Transitions
{
    public class Fl_AniData_Transition
    {
        private Fl_AniData_Sitting2Standing Fl_AniData_SI2ST;
        private Fl_AniData_Standing2Sitting Fl_AniData_ST2SI;

        public void Fl_AniData_SI2ST_I()
        {
            Fl_AniData_SI2ST.Fl_AniData_Sitting2StandingI();
        }

        public void Fl_AniData_ST2SI_I()
        {
            Fl_AniData_ST2SI.Fl_AniData_Standing2SittingI();
        }
    }
}