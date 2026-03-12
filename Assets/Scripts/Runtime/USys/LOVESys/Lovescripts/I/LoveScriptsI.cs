using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC;
using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.PLAYER;
using UnityEngine;

namespace Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules
{
	public class LoveScriptsI : MonoBehaviour
	{
		private NPC_LOVESys NPC_LoveSys;
		private Player_LOVESys Player_LoveSys;
		public void Run()
		{
			Get_NPC_LOVESys();
			Get_Player_LOVESys();
		}
		private void Get_NPC_LOVESys()
		{
			NPC_LoveSys.NPC_LoveSys();
		}

		private void Get_Player_LOVESys()
		{
			Player_LoveSys.Player_LoveSys();
		}
		private void Get_AItems_LoveSys() 
		{
			
		}
	}
}