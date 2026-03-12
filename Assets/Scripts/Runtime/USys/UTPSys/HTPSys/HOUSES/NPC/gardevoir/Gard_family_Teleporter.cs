using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Gardevoir
{
    public class Gard_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Gard_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}