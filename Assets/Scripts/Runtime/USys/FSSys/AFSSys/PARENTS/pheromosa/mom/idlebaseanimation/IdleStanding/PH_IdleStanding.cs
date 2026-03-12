using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleStanding
{
	public class PHParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator PheromosaParentMom_Animator;
		public void PHParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}