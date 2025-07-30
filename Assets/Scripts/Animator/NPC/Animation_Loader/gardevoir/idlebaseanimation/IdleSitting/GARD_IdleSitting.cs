using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Gardevoir.idlebaseanimation.IdleSitting
{
	public class GARD_IdleSitting : MonoBehaviour 
	{
		private Animator Gardevoir_Animator;
		public void GARD_IdleSittingController()
		{
			Gardevoir_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Gardevoir_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}