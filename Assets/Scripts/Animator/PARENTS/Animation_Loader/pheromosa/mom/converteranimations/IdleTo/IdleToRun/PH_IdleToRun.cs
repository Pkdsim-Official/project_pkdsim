using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo.IdleToRun
{
	public class PHParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator PheromosaParentMom_Animator;
		public void PHParentMom_IdleToRunController()
		{
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}