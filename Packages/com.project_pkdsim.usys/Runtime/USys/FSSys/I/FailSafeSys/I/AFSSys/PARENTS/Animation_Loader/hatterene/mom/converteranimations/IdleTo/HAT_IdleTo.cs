using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.IdleTo
{
	public class HATParentMom_IdleTo : MonoBehaviour 
	{
		
		private HATParentMom_IdleToRun HattereneIdleToRun;
		private HATParentMom_IdleToWalk HattereneIdleToWalk;
		public void HATParentMom_IdleToController()
		{
			Load_HATParentMom_idleToRun();
			Load_HATParentMom_idleToWalk();
		}
		private void Load_HATParentMom_idleToRun()
		{
			HattereneIdleToRun.HATParentMom_IdleToRunController();
		}
		private void Load_HATParentMom_idleToWalk()
		{
			HattereneIdleToWalk.HATParentMom_IdleToWalkController();
		}
	}
}