using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.converteranimations.IdleTo
{
	public class GARCParentDad_IdleTo : MonoBehaviour 
	{
		private GARCParentDad_IdleToRun GarchompIdleToRun;
		private GARCParentDad_IdleToWalk GarchompIdleToWalk;
		public void GARCParentDad_IdleToController()
		{
			Load_GARCParentDad_IdleToRun();
			Load_GARCParentDad_IdleToWalk();
		}
		private void Load_GARCParentDad_IdleToRun()
		{
			GarchompIdleToRun.GARCParentDad_IdleToRunController();
		}
		private void Load_GARCParentDad_IdleToWalk()
		{
			GarchompIdleToWalk.GARCParentDad_IdleToWalkController();
		}
	}
}