using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToStanding
{
	public class VEWalkingToStanding : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEWalkingToStandingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}