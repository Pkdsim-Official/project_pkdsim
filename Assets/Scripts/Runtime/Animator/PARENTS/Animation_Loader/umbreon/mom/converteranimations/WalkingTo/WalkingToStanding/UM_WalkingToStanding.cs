using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class UMParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator UmbreonParentMom_Animator;
		public void UMParentMom_WalkingToStandingController()
		{
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}