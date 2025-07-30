using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.IdleTo
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