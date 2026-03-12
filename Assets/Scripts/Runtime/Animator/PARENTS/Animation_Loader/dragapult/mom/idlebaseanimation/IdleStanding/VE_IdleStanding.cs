using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding
{
	public class DRParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator DragapultParentMom_Animator;
		public void DRParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}