using Project_Pkdsim.USys.AudioSys.Modules.MusicSys.Modules.Presets;
using UnityEngine;

namespace Project_Pkdsim.USys.AudioSys.Modules.MusicSys.Modules.Loader.Modules
{
	public class MusicSysLoaderI : MonoBehaviour 
	{
		private MusicPresets MusicPresets;
		public void MusicLoader_I() 
		{
			MusicLoaderPresets();
		}
		private void MusicLoaderPresets()
		{
			MusicPresets.Presets();
		}
	}
}