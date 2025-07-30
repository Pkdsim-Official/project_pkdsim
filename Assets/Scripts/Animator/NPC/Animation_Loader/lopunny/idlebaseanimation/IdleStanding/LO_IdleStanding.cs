using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation.IdleStanding
{
	public class LOIdleStanding : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public void LOIdleStandingController()
		{
			// Assign the idle animation clip
			Lopunny_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lopunny_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}