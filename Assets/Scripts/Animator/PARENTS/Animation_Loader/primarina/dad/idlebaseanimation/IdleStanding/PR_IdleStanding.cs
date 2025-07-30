using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.idlebaseanimation.IdleStanding
{
	public class PRIdleStanding : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public void PRIdleStandingController()
		{
			// Assign the idle animation clip
			Primarina_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Primarina_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}