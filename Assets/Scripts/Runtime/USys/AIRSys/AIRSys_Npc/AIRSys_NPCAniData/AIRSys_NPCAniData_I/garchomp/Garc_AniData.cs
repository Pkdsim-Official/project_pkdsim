using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Idle;
using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Transitions;
using UnityEngine;

namespace Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData.Garc_AniData {
        public class Garc_AniData
        {
                private Garc_AniData_Transition Garc_AniData_Transitions;
                private Garc_AniData_Idle Garc_AniData_Idle;
                public void Load_Garc_AnimationData()
                {
                        Load_GarcAniData_Idle();
                        Load_GarcAniData_Transition();
                }
                public void Load_GarcAniData_Idle() {
                        Garc_AniData_Idle.Garc_AniData_IdleST_I();
                        Garc_AniData_Idle.Garc_AniData_IdleSI_I();
                }
                public void Load_GarcAniData_Transition() {
                        Garc_AniData_Transitions.Garc_AniData_SI2ST_I();
                        Garc_AniData_Transitions.Garc_AniData_ST2SI_I();
                }
        }
}