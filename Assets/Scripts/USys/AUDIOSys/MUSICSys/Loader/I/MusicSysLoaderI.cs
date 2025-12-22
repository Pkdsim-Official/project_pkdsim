using project_pkdsim.USys.AudioSys.Modules.MusicSys.Modules.Presets;
using UnityEngine;

namespace project_pkdsim.USys.AudioSys.Modules.MusicSys.Modules.Loader.Modules
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