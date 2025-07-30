using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class VPParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator VaporeonParentMom_Animator;
		public void VPParentMom_WalkingToStandingController()
		{
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}