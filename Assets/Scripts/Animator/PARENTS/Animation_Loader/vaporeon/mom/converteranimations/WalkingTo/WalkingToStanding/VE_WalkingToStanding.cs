using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo.WalkingToStanding
{
	public class VEParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentMom_WalkingToStandingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}