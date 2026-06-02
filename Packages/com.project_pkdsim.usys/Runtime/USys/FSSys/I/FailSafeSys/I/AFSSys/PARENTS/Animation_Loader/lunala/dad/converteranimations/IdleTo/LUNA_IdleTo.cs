using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.IdleTo
{
	public class LUNAParentDad_IdleTo : MonoBehaviour 
	{
		private LUNAParentDad_IdleToRun LunalaIdleToRun;
		private LUNAParentDad_IdleToWalk LunalaIdleToWalk;

		public void LUNAParentDad_IdleToController()
		{
			Load_LUNAParentDad_idleToRun();
			Load_LUNAParentDad_idleToWalk();
		}
		private void Load_LUNAParentDad_idleToRun()
		{
			LunalaIdleToRun.LUNAParentDad_IdleToRunController();
		}
		private void Load_LUNAParentDad_idleToWalk()
		{
			LunalaIdleToWalk.LUNAParentDad_IdleToWalkController();
		}
	}
}