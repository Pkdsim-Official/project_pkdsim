using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.WalkingTo.WalkingToStanding
{
	public class UMParentDad_WalkingToStanding : MonoBehaviour
	{
		private Animator UmbreonParentDad_Animator;
		public void UMParentDad_WalkingToStandingController() 
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			UmbreonParentDad_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}