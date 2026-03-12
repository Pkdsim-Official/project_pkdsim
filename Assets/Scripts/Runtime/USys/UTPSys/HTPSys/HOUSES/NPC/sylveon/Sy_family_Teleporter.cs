using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Sylveon
{
    public class SYL_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void SYL_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}