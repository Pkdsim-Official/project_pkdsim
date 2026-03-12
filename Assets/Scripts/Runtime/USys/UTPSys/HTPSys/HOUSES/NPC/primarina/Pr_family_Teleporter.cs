using System.Collections;
using UnityEngine;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Primarina
{
    public class Pr_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Pr_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}