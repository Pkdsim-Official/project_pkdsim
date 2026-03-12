using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class BEParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BEParentMom_WalkingToStandingController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}