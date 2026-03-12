using Project_Pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo
{
	public class DRParentMom_IdleTo : MonoBehaviour 
	{
		private DRParentMom_IdleToRun DragapultParentMomIdleToRun;
		private DRParentMom_IdleToWalk DragapultParentMomIdleToWalk;

		public void DRParentMom_IdleToController()
		{
			Load_DRParentMom_idleToRun();
			Load_DRParentMom_idleToWalk();
		}
		private void Load_DRParentMom_idleToRun()
		{
			DragapultParentMomIdleToRun.DRParentMom_IdleToRunController();
		}
		private void Load_DRParentMom_idleToWalk()
		{
			DragapultParentMomIdleToWalk.DRParentMom_IdleToWalkController();
		}
	}
}