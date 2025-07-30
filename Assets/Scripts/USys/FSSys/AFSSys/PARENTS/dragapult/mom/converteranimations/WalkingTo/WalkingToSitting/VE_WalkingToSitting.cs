using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class DRParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator DragapultParentMom_Animator;
		public void DRParentMom_WalkingToSittingController()
		{
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}