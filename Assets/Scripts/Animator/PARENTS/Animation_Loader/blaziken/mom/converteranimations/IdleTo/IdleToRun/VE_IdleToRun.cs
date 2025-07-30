using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo.IdleToRun
{
	public class BLParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator BLazikenParentMom_Animator;
		public void BLParentMom_IdleToRunController()
		{
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}