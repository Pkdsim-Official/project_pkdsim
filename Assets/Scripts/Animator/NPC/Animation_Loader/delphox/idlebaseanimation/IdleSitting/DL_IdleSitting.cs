using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation.IdleSitting
{
	public class DL_IdleSitting : MonoBehaviour 
	{
		private Animator Delphox_Animator;
		public void DL_IdleSittingController()
		{
			Delphox_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Delphox_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}