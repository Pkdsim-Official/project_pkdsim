using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Garchomp
{
    public class Garc_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Garc_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}