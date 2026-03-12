using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Absol
{
    public class Ab_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector

        public void Ab_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}