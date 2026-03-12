using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class GARCParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator GarchompParentMom_Animator;
		public void GARCParentMom_WalkingToStandingController()
		{
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}