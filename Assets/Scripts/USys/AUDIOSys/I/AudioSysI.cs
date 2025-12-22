using project_pkdsim.USys.AudioSys.Modules.MusicSys;
using UnityEngine;

namespace project_pkdsim.USys.AudioSys.Modules
{
	public class AudioSysI : MonoBehaviour 
	{
		private MUSICSys MusicSys;
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