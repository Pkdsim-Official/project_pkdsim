using Project_Pkdsim.USys.SceneManagerSys.HOUSES.NPC;
using Project_Pkdsim.USys.SceneManagerSys.HOUSES.PLAYER;

namespace Project_Pkdsim.USys.SceneManagerSys.Modules
{
    public class UnitySceneManagerSysI
    {
        protected SCMSys_NPC_Houses SCMSys_NPC_Houses;
        protected SCMSys_Player_House_I SCMSys_Player_House;
        public void SCMSys_Houses()
        {
            NPC_Houses();
            Player_House();
        }
        protected void NPC_Houses()
        {
            SCMSys_NPC_Houses.SCMSys_NPC_HousesI("family");
        }
        protected void Player_House()
        {
            SCMSys_Player_House.SCMSys_Player_FamilySceneI();
        }
    }
}