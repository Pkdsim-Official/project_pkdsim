using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class DRParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator DragapultParentMom_Animator;
		public void DRParentMom_IdleToWalkController()
		{
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}