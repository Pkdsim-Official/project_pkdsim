using UnityEngine;

namespace project_pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Pheromosa
{
    public class Ph_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Ph_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}