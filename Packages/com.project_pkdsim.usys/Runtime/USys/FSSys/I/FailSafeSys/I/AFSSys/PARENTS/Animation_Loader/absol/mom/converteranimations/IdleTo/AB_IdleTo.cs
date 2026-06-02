using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo
{
	public class ABParentMom_IdleTo : MonoBehaviour 
	{

		private ABParentMom_IdleToRun AbsolIdleToRun;
		private ABParentMom_IdleToWalk AbsolIdleToWalk;
		public void ABParentMom_IdleToController()
		{
			Load_ABParentMom_idleToRun();
			Load_ABParentMom_idleToWalk();
		}
		private void Load_ABParentMom_idleToRun()
		{
			AbsolIdleToRun.ABParentMom_IdleToRunController();
		}
		private void Load_ABParentMom_idleToWalk()
		{
			AbsolIdleToWalk.ABParentMom_IdleToWalkController();
		}
	}
}