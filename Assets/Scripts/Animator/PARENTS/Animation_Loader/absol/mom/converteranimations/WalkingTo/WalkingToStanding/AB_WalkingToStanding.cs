using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class ABParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator AbsolParentMom_Animator;
		public void ABParentMom_WalkingToStandingController()
		{
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}