using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo
{
	public class LEParentDad_IdleTo : MonoBehaviour 
	{
		private LEParentDad_IdleToRun LEParentDad_IdleToRun;
		private LEParentDad_IdleToWalk LEParentDad_IdleToWalk;
		public void LEParentDad_IdleToController()
		{
			Load_LEParentDad_idleToRun();
			Load_LEParentDad_idleToWalk();
		}
		private void Load_LEParentDad_idleToRun()
		{
			LEParentDad_IdleToRun.LEParentDad_IdleToRunController();
		}
		private void Load_LEParentDad_idleToWalk()
		{
			LEParentDad_IdleToWalk.LEParentDad_IdleToWalkController();
		}

	}
}