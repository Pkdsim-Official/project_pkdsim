using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleSitting
{
	public class DRIdleSitting : MonoBehaviour 
	{
		private Animator DragapultParentDad_Animator;
		public void DRIdleSittingController()
		{
			DragapultParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DragapultParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}