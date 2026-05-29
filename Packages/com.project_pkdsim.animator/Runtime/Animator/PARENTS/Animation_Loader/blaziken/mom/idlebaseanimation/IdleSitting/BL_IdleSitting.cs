using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleSitting
{
	public class BL_IdleSitting : MonoBehaviour 
	{
		private Animator BlazikenParentMom_Animator;
		public void BL_IdleSittingController()
		{
			BlazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BlazikenParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}