using Project_Pkdsim.USys.AIRoutesSys.AIRSys_NPCAniData;
using UnityEngine;

namespace Project_Pkdsim.USys.AIRoutesSys.AIRSys_I
{
    public class AIRSysI: MonoBehaviour
    {
        private AIRSys_NPCAnimation_Data Npc_AniData;
        public void NPC_AniData(string AniData)
        {
            Npc_AniData.AIRSys_NPCAniData("AniData");
        }
    }
}