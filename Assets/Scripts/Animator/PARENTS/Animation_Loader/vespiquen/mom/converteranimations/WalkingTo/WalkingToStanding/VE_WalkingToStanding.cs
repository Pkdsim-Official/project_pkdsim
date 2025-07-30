using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class VEParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator VespiquenParentMom_Animator;
		public void VEParentMom_WalkingToStandingController()
		{
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}