using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation.IdleStanding
{
	public class PHIdleStanding : MonoBehaviour 
	{
		public Animator PheromosaParentDad_Animator;
		public void PHIdleStandingController()
		{
			// Assign the idle animation clip
			PheromosaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}