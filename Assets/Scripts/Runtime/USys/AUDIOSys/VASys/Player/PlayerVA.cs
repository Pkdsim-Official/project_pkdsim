using UnityEngine;

namespace Project_Pkdsim.USys.AudioSys.Modules.VoiceActorsSys.Modules.Player
{
	public class VASys_Player : MonoBehaviour 
	{
		// TODO: get a player voice actor
		private void LoadVA()
		{
			// TODO: load player voice actor
		}
		private void UnloadVA()
		{
			// TODO: unload player voice actor
		}
		
		private void OnEnable()
		{
			LoadVA();
		}
		private void OnDisable()
		{
			UnloadVA();
		}
		public void PlayerVA() 
		{
			if (enabled) 
			{
				// TODO: play player voice actor
			}
		}
}

}