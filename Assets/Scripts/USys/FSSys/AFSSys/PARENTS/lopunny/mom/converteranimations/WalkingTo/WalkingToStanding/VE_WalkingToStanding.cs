using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class LOParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator LopunnyParentMom_Animator;
		public void LOParentMom_WalkingToStandingController()
		{
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}