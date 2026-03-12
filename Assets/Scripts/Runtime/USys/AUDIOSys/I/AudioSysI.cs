using Project_Pkdsim.USys.AudioSys.Modules.MusicSys;
using UnityEngine;

namespace Project_Pkdsim.USys.AudioSys.Modules
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