using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo
{
	public class FLParentMom_IdleTo : MonoBehaviour 
	{
		private FLParentMom_IdleToWalk FlareonParentMom_IdleToWalk;
		private FLParentMom_IdleToRun FlareonParentMom_IdleToRun;
		public void FLParentMom_IdleToController()
		{
			Load_FLParentMom_IdleToRun();
			Load_FLParentMom_IdleToWalk();
		}
		private void Load_FLParentMom_IdleToRun()
		{
			FlareonParentMom_IdleToRun.FLParentMom_IdleToRunController();	
		}
		private void Load_FLParentMom_IdleToWalk()
		{
			FlareonParentMom_IdleToWalk.FLParentMom_IdleToWalkController();
		}
	}
}