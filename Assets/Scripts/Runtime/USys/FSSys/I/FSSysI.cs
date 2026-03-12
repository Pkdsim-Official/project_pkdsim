using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys;
using Project_Pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.Modules
{
	public class FSSysI : MonoBehaviour
	{
		private VoiceActorsFailSafetySys VAFSSys;
		private AnimatorFailSafetySys AFSSys;

		public void FSSys_I()
		{
			Get_VAFSys();
		}
		private void Get_VAFSys()
		{
			VAFSSys.VAFSSysI();
		}

		private void Get_AFSSys()
		{
			AFSSys.AFSSysI();
		}
	}
}