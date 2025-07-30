using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class BRParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator BraixenParentMom_Animator;
		public void BRParentMom_WalkingToStandingController()
		{
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}