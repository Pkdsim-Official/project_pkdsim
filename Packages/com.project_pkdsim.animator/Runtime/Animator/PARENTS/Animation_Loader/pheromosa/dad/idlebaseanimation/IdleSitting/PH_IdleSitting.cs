using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation.IdleSitting
{
	public class PHIdleSitting : MonoBehaviour 
	{
		private Animator PheromosaParentDad_Animator;
		public void PHIdleSittingController()
		{
			PheromosaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}