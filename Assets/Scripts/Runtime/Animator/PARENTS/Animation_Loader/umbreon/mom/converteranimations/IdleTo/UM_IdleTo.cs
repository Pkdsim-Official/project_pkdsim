using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo
{
	public class UMParentMom_IdleTo : MonoBehaviour 
	{
		private UMParentMom_IdleToRun UmbreonParentMomIdleToRun;
		private UMParentMom_IdleToWalk UmbreonParentMomIdleToWalk;

		public void UMParentMom_IdleToController()
		{
			Load_UMParentMom_idleToRun();
			Load_UMParentMom_idleToWalk();
		}
		private void Load_UMParentMom_idleToRun()
		{
			UmbreonParentMomIdleToRun.UMParentMom_IdleToRunController();
		}
		private void Load_UMParentMom_idleToWalk()
		{
			UmbreonParentMomIdleToWalk.UMParentMom_IdleToWalkController();
		}
	}
}