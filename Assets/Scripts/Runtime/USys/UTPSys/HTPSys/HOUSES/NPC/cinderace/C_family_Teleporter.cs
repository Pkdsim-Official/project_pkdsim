using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Cinderace
{
    public class C_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void C_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}