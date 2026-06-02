using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo
{
	public class FLParentMom_IdleTo : MonoBehaviour 
	{
		private FLParentMom_IdleToRun FLParentMom_IdleToRun;
		private FLParentMom_IdleToWalk FLParentMom_IdleToWalk;
		public void FLParentMom_IdleToController()
		{
			Load_FLParentMom_IdleToRun();
			Load_FLParentMom_IdleToWalk();
		}
		private void Load_FLParentMom_IdleToRun()
		{
			FLParentMom_IdleToRun.FLParentMom_IdleToRunController();	
		}
		private void Load_FLParentMom_IdleToWalk()
		{
			FLParentMom_IdleToWalk.FLParentMom_IdleToWalkController();
		}
	}
}