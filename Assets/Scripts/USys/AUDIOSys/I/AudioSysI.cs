using project_pkdsim.USys.AUDIOSys.Modules.MUSICSys;
using UnityEngine;

namespace project_pkdsim.USys.AUDIOSys.Modules
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