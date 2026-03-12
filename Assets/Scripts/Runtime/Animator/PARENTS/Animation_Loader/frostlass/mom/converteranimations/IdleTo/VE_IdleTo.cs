using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo
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