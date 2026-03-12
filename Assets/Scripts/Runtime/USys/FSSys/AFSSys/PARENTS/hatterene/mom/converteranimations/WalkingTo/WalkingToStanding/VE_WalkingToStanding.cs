using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class HATParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator HattereneParentMom_Animator;
		public void HATParentMom_WalkingToStandingController()
		{
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}