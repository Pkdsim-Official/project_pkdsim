using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo
{
	public class FRParentMom_IdleTo : MonoBehaviour 
	{
		private FRParentMom_IdleToRun FrostlassParentMomIdleToRun;
		private FRParentMom_IdleToWalk FrostlassParentMomIdleToWalk;

		public void FRParentMom_IdleToController()
		{
			Load_FRParentMom_idleToRun();
			Load_FRParentMom_idleToWalk();
		}
		private void Load_FRParentMom_idleToRun()
		{
			FrostlassParentMomIdleToRun.FRParentMom_IdleToRunController();
		}
		private void Load_FRParentMom_idleToWalk()
		{
			FrostlassParentMomIdleToWalk.FRParentMom_IdleToWalkController();
		}
	}
}