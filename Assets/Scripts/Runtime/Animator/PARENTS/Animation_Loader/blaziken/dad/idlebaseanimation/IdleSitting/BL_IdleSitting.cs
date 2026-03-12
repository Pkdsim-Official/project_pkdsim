using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.idlebaseanimation.IdleSitting
{
	public class BL_IdleSitting : MonoBehaviour 
	{
		private Animator BlazikenParentDad_Animator;
		public void BL_IdleSittingController()
		{
			BlazikenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BlazikenParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}