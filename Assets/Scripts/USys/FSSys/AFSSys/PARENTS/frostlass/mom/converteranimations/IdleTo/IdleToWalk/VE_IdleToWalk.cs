using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class FRParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator FrostlassParentMom_Animator;
		public void FRParentMom_IdleToWalkController()
		{
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}