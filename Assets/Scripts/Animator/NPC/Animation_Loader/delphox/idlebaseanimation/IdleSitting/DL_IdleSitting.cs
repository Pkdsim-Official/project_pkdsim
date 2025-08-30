using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleSitting
{
	public class DLIdleSitting : MonoBehaviour 
	{
		private Animator Delphox_Animator;
		public void DLIdleSittingController()
		{
			Delphox_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Delphox_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}