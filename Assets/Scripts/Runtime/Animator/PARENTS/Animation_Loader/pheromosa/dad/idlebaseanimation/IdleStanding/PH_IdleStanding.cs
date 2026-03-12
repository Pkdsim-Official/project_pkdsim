using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleStanding
{
	public class PHParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator PheromosaParentDad_Animator;
		public void PHParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			PheromosaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}