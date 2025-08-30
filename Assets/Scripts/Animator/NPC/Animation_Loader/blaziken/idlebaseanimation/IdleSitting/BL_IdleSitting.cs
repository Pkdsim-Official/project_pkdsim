using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleSitting
{
	public class BLIdleSitting : MonoBehaviour 
	{
		private Animator Blaziken_Animator;
		public void BLIdleSittingController()
		{
			Blaziken_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Blaziken_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}