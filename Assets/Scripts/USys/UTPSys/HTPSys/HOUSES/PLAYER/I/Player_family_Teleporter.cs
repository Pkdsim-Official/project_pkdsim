using UnityEngine;

namespace project_pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.PLAYER.Modules
{
    public class UHTPSys_Player_FamilyTeleporterI
    {
        private GameObject PlayerFamily;
        public void Player_FamilySceneTeleporterI()
        {
            PlayerFamily = GameObject.Find("PlayerFamily");
        }
    }
}
