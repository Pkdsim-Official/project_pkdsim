using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys;
using project_pkdsim.USys.FailSafeSys.Modules.VoiceActorsFailSafeSys;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.Modules
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