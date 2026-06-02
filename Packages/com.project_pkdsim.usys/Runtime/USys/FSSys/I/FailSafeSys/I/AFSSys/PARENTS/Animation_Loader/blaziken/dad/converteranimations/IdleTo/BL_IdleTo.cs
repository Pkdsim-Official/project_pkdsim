using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.IdleTo
{
	public class BL_IdleTo : MonoBehaviour 
	{
		private BL_IdleToRun BlazikenIdleToRun;
		private BL_IdleToWalk BlazikenIdleToWalk;
		public void BL_IdleToController()
		{
			Load_BL_IdleToRun();
			Load_BL_IdleToWalk();
		}
		private void Load_BL_IdleToRun()
		{
			BlazikenIdleToRun.BL_IdleToRunController();
		}
		private void Load_BL_IdleToWalk()
		{
			BlazikenIdleToWalk.BL_IdleToWalkController();
		}
	}
}