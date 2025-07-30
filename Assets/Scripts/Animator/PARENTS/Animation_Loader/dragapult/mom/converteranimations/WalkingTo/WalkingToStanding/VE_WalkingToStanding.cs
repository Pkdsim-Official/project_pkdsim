using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class DRParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator DragapultParentMom_Animator;
		public void DRParentMom_WalkingToStandingController()
		{
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}