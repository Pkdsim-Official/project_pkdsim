using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.idlebaseanimation.IdleStanding
{
	public class GARDIdleStanding : MonoBehaviour 
	{
		public Animator Gardevoir_Animator;
		public void GARDIdleStandingController()
		{
			// Assign the idle animation clip
			Gardevoir_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Gardevoir_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}