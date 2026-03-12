using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class UMParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator UmbreonParentMom_Animator;
		public void UMParentMom_IdleToWalkController()
		{
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}