using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class GLParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		public void GLParentMom_WalkingToStandingController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}