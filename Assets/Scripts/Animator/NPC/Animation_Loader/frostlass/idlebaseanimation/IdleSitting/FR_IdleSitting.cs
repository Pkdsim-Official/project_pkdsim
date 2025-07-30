using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Frostlass.idlebaseanimation.IdleSitting
{
	public class FR_IdleSitting : MonoBehaviour 
	{
		private Animator Frostlass_Animator;
		public void FR_IdleSittingController()
		{
			Frostlass_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Frostlass_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}