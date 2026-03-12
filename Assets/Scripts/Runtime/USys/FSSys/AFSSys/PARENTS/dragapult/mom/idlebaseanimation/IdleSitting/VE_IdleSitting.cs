using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleSitting
{
	public class DRParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator DragapultParentMom_Animator;
		public void DRParentMom_IdleSittingController()
		{
			DragapultParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}