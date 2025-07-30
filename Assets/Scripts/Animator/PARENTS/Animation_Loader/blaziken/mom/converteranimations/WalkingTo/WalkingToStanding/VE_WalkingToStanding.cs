using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class BLParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator BLazikenParentMom_Animator;
		public void BLParentMom_WalkingToStandingController()
		{
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}