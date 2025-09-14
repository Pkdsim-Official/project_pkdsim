using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToStanding
{
	public class VEParentDad_WalkingToStanding : MonoBehaviour 
	{
		private Animator VespiquenParentDad_Animator;
		public void VEParentDad_WalkingToStandingController()
		{
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}