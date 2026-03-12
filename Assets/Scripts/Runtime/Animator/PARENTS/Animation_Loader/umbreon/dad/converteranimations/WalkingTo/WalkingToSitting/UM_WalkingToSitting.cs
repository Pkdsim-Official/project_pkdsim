using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.WalkingTo.WalkingToSitting
{
	public class UMParentDad_WalkingToSitting : MonoBehaviour
	{
		private Animator UmbreonParentDad_Animator;
		private void UMParentDad_WalkingToSittingController()
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentDad_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingToSittingCon state
		}
	}
}