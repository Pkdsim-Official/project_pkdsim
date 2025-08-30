using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleStanding
{
	public class GARCIdleStanding : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public void GARCIdleStandingController()
		{
			// Assign the idle animation clip
			Garchomp_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Garchomp_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}