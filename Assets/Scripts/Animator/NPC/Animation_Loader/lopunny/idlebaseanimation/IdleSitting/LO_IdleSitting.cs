using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation.IdleSitting
{
	public class LO_IdleSitting : MonoBehaviour 
	{
		private Animator Flareon_Animator;
		public void LO_IdleSittingController()
		{
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}