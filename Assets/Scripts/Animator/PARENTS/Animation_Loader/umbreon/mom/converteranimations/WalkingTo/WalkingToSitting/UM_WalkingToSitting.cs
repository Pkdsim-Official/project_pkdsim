using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class UMParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator UmbreonParentMom_Animator;
		public void UMParentMom_WalkingToSittingController()
		{
			UmbreonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}