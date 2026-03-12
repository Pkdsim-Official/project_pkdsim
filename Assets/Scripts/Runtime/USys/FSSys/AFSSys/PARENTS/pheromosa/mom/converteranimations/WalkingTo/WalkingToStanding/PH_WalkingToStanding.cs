using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class PHParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator PheromosaParentMom_Animator;
		public void PHParentMom_WalkingToStandingController()
		{
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}