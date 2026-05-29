using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation.IdleStanding
{
	public class GARC_IdleStanding : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public void GARC_IdleStandingController()
		{
			// Assign the idle animation clip
			Garchomp_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Garchomp_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}