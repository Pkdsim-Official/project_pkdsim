using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.idlebaseanimation.IdleStanding
{
	public class VEIdleStanding : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public void VEIdleStandingController()
		{
			// Assign the idle animation clip
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}