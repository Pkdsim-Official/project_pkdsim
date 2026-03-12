using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class SYLParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator SylveonParentMom_Animator;
		public void SYLParentMom_WalkingToStandingController()
		{
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}