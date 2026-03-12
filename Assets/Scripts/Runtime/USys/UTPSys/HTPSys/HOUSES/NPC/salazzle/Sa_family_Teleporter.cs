using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Salazzle
{
    public class Sa_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Sa_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}