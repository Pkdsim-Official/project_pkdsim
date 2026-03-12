using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Tsareena
{
    public class T_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void T_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}