using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo
{
	public class GARCParentMom_IdleTo : MonoBehaviour 
	{
		private GARCParentMom_IdleToRun GarchompIdleToRun;
		private GARCParentMom_IdleToWalk GarchompIdleToWalk;
		public void GARCParentMom_IdleToController()
		{
			Load_GARCParentMom_IdleToRun();
			Load_GARCParentMom_IdleToWalk();
		}
		private void Load_GARCParentMom_IdleToRun()
		{
			GarchompIdleToRun.GARCParentMom_IdleToRunController();
		}
		private void Load_GARCParentMom_IdleToWalk()
		{
			GarchompIdleToWalk.GARCParentMom_IdleToWalkController();
		}
	}
}