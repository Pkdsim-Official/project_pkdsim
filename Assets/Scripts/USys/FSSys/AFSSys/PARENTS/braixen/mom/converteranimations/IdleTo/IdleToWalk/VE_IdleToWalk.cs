using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class BRParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator BraixenParentMom_Animator;
		public void BRParentMom_IdleToWalkController()
		{
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}