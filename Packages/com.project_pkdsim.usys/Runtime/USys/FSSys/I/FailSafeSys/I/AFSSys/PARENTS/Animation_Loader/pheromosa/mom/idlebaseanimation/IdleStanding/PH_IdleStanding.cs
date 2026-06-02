using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleStanding
{
	public class PHIdleStanding : MonoBehaviour 
	{
		public Animator PheromosaParentMom_Animator;
		public void PHIdleStandingController()
		{
			// Assign the idle animation clip
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}