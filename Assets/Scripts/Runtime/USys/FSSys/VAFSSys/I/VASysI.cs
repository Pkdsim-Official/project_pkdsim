using Project_Pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC;
using Project_Pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.Player;
using Project_Pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.Parents;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules
{
	public class VAFSSysI : MonoBehaviour
	{
		private VAFSSys_Npc VAFSSys_NPC;
		private VAFSSys_Player VAFSSys_Player;
		private VAFSSys_Parents VAFSSys_Parents;

		private void VAFSSysI_NPC()
		{
			VAFSSys_NPC.VAFSSys_NPCI();
		}
		private void VAFSSysI_Player()
		{
			VAFSSys_Player.VAFSSys_PlayerI();
		}
		private void VAFSSysI_Parents()
		{
			VAFSSys_Parents.VAFSSys_ParentsI();
		}

		public void VAFSSys_I()
		{
			VAFSSysI_NPC();
			VAFSSysI_Player();
		}
	}
}