using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Meowscarada
{
    
    public class Me_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Me_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}