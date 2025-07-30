using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleSitting
{
	public class FLParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void FLParentMom_IdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}