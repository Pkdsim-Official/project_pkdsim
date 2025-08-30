using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleSitting
{
	public class LOIdleSitting : MonoBehaviour 
	{
		private Animator Flareon_Animator;
		public void LOIdleSittingController()
		{
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}