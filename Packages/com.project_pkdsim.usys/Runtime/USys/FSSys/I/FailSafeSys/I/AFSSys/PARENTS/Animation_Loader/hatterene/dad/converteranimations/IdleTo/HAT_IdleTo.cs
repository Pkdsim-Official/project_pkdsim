using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo
{
	public class HATParentDad_IdleTo : MonoBehaviour 
	{
		
		private HATParentDad_IdleToRun HattereneIdleToRun;
		private HATParentDad_IdleToWalk HattereneIdleToWalk;
		public void HATParentDad_IdleToController()
		{
			Load_HATParentDad_idleToRun();
			Load_HATParentDad_idleToWalk();
		}
		private void Load_HATParentDad_idleToRun()
		{
			HattereneIdleToRun.HATParentDad_IdleToRunController();
		}
		private void Load_HATParentDad_idleToWalk()
		{
			HattereneIdleToWalk.HATParentDad_IdleToWalkController();
		}
	}
}