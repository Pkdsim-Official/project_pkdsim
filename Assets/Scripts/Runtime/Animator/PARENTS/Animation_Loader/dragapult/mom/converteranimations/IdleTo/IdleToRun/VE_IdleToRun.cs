using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.IdleTo.IdleToRun
{
	public class DRParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator DragapultParentMom_Animator;
		public void DRParentMom_IdleToRunController()
		{
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}