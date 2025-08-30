using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleSitting
{
	public class GARCIdleSitting : MonoBehaviour 
	{
		private Animator Flareon_Animator;
		public void GARCIdleSittingController()
		{
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}