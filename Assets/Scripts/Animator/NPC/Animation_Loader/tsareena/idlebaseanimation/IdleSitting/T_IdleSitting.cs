using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleSitting
{
	public class TIdleSitting : MonoBehaviour 
	{
		private Animator Tsareena_Animator;
		public void TIdleSittingController()
		{
			Tsareena_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Tsareena_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}