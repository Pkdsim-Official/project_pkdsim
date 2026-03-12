using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Blaziken
{
    public class Bl_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Bl_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}