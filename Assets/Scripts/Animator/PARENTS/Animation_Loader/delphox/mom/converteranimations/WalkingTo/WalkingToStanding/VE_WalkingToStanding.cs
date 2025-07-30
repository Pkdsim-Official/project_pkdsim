using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class DLParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLParentMom_WalkingToStandingController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}