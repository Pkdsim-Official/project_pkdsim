using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo
{
	public class FLParentMom_IdleTo : MonoBehaviour 
	{
		private FLParentMom_IdleToRun FlareonParentMomIdleToRun;
		private FLParentMom_IdleToWalk FlareonParentMomIdleToWalk;

		public void FLParentMom_IdleToController()
		{
			Load_FLParentMom_idleToRun();
			Load_FLParentMom_idleToWalk();
		}
		private void Load_FLParentMom_idleToRun()
		{
			FlareonParentMomIdleToRun.FLParentMom_IdleToRunController();
		}
		private void Load_FLParentMom_idleToWalk()
		{
			FlareonParentMomIdleToWalk.FLParentMom_IdleToWalkController();
		}
	}
}