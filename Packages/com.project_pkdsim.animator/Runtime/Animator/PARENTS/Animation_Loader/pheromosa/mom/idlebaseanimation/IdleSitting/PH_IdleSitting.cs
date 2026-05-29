using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleSitting
{
	public class PHIdleSitting : MonoBehaviour 
	{
		private Animator PheromosaParentMom_Animator;
		public void PHIdleSittingController()
		{
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}