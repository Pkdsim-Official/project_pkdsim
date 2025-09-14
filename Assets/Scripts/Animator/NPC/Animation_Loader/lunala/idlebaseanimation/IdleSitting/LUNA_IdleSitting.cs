using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation.IdleSitting
{
	public class LUNA_IdleSitting : MonoBehaviour 
	{
		private Animator Flareon_Animator;
		public void LUNA_IdleSittingController()
		{
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}