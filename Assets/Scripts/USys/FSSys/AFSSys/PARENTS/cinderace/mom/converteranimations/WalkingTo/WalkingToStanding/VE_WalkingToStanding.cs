using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class CParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator CinderaceParentMom_Animator;
		public void CParentMom_WalkingToStandingController()
		{
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}