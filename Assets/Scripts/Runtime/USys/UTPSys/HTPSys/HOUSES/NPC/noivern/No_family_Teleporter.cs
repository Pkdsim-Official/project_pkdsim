using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Noivern
{
    public class No_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void No_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}