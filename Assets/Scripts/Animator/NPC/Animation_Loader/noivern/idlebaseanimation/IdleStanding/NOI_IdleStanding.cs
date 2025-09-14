using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.idlebaseanimation.IdleStanding
{
	public class NOIIdleStanding : MonoBehaviour 
	{
		public Animator Noivern_Animator;
		public void NOIIdleStandingController()
		{
			// Assign the idle animation clip
			Noivern_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Noivern_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}