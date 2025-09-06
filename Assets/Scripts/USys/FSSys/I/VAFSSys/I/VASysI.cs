using project_pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC;
using project_pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.Player;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules
{
	public class VAFSSysI : MonoBehaviour 
	{
		private VAFSSys_NPC VAFSSys_NPC;
		private VAFSSys_Player VAFSSys_Player;
		private void VAFSSysI_NPC() 
		{
			VAFSSys_NPC.VAFSSys_NPCI();
		}
		private void VAFSSysI_Player() 
		{
			VAFSSys_Player.VAFSSys_PlayerI();
		}
		public void VAFSSys_I() 
		{
			VAFSSysI_NPC();
			VAFSSysI_Player();
		}
	}
}