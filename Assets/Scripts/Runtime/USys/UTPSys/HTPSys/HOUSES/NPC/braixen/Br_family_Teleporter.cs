using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Braixen
{
    public class Br_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Br_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}