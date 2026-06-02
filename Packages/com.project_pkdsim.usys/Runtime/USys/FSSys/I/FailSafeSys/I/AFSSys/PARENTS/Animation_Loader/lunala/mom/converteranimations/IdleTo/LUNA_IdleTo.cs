using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo
{
	public class LUNAParentMom_IdleTo : MonoBehaviour 
	{
		private LUNAParentMom_IdleToRun LunalaIdleToRun;
		private LUNAParentMom_IdleToWalk LunalaIdleToWalk;

		public void LUNAParentMom_IdleToController()
		{
			Load_LUNAParentMom_idleToRun();
			Load_LUNAParentMom_idleToWalk();
		}
		private void Load_LUNAParentMom_idleToRun()
		{
			LunalaIdleToRun.LUNAParentMom_IdleToRunController();
		}
		private void Load_LUNAParentMom_idleToWalk()
		{
			LunalaIdleToWalk.LUNAParentMom_IdleToWalkController();
		}
	}
}