using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleStanding
{
	public class UMParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator UmbreonParentMom_Animator;
		public void UMParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}