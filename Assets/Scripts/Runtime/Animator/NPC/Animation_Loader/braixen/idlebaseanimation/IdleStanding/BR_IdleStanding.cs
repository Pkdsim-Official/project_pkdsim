using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Braixen.idlebaseanimation.IdleStanding
{
	public class BRIdleStanding : MonoBehaviour 
	{
		public Animator Braixen_Animator;
		public void BRIdleStandingController()
		{
			// Assign the idle animation clip
			Braixen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Braixen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}