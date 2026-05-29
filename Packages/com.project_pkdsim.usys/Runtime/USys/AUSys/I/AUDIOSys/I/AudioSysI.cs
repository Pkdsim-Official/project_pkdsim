using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys;
using UnityEngine;

namespace project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules
{
	public class AudioSysI : MonoBehaviour 
	{
		private MusicSys MusicSys;
		public void AudiosSys_I()
		{
			LoadMusicSys();
		}
		private void LoadMusicSys() 
		{
			MusicSys.MusicSysI();
		}
	}
}