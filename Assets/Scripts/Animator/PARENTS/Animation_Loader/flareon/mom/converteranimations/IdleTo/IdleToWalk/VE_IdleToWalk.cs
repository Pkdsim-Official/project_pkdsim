using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class FLParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void FLParentMom_IdleToWalkController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}