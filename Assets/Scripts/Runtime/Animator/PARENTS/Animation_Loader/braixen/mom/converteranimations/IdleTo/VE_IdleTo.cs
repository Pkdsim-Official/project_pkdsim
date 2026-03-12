using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo
{
	public class BRParentMom_IdleTo : MonoBehaviour 
	{
		private BRParentMom_IdleToRun BraixenParentMomIdleToRun;
		private BRParentMom_IdleToWalk BraixenParentMomIdleToWalk;

		public void BRParentMom_IdleToController()
		{
			Load_BRParentMom_idleToRun();
			Load_BRParentMom_idleToWalk();
		}
		private void Load_BRParentMom_idleToRun()
		{
			BraixenParentMomIdleToRun.BRParentMom_IdleToRunController();
		}
		private void Load_BRParentMom_idleToWalk()
		{
			BraixenParentMomIdleToWalk.BRParentMom_IdleToWalkController();
		}
	}
}