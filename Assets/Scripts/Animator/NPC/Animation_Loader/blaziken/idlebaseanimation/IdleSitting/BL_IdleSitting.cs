using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Blaziken.idlebaseanimation.IdleSitting
{
	public class BL_IdleSitting : MonoBehaviour 
	{
		private Animator Blaziken_Animator;
		public void BL_IdleSittingController()
		{
			Blaziken_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Blaziken_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}