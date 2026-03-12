using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleSitting
{
	public class BLParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator BLazikenParentMom_Animator;
		public void BLParentMom_IdleSittingController()
		{
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}