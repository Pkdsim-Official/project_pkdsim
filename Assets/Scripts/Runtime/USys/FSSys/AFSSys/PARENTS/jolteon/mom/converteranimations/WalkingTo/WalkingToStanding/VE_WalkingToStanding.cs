using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class JTParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator JolteonParentMom_Animator;
		public void JTParentMom_WalkingToStandingController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}