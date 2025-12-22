using project_pkdsim.USys.AnimatedTexturesSys.NPC.Modules;
using UnityEngine;

namespace project_pkdsim.USys.AnimatedTexturesSys.Modules
{
	public class AnimatedTexturesSysI : MonoBehaviour 
	{
		private NPC_AnimatedTextureSysI NPC_ATSysI;
		public void AnimatedTextureSysI() 
		{
			GetNPC_AnimatedTextureSys_I();
		}
		private void GetNPC_AnimatedTextureSys_I()
		{
			NPC_ATSysI.NPC_ATSys_I();
		}
	}
}