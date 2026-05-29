using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleSitting
{
	public class LOIdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void LOIdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}