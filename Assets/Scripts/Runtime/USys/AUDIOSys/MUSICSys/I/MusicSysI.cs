using Project_Pkdsim.USys.AudioSys.Modules.MusicSys.Modules.Loader;
using UnityEngine;

namespace Project_Pkdsim.USys.AudioSys.Modules.MusicSys.Modules
{
	public class MusicSysI : MonoBehaviour
	{
		private MusicSysLoader MusicLoader;
		private void MusicSys_I() 
		{
			LoadMusicSys();
		}
		private void LoadMusicSys()
		{
			LoadMusicLoader();
		}
		private void LoadMusicLoader()
		{
			MusicLoader.MusicLoaderI();
		}
	}
}