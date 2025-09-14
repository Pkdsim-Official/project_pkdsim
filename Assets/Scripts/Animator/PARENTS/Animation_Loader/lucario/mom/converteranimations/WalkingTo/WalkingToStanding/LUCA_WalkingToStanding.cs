using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class LUCAParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator lucarioParentMom_Animator;
		public void LUCAParentMom_WalkingToStandingController()
		{
			lucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			lucarioParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}