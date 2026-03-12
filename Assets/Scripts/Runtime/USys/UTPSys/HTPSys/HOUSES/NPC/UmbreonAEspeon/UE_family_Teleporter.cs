using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.UmbreonAEspeon
{
    public class UE_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void UE_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}