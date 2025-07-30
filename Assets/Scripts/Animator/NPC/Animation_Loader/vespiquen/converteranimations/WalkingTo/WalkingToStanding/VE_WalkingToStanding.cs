using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo.WalkingToStanding
{
	public class VE_WalkingToStanding : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_WalkingToStandingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("_WalkingTo_Standing");         // Start in the _WalkingToStandingCon state
		}
	}
}