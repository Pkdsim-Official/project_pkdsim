using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleSitting
{
	public class PHIdleSitting : MonoBehaviour 
	{
		private Animator Pheromosa_Animator;
		public void PHIdleSittingController()
		{
			Pheromosa_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Pheromosa_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}