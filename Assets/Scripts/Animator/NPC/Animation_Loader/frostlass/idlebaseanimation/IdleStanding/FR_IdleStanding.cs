using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleStanding
{
	public class FRIdleStanding : MonoBehaviour 
	{
		public Animator Frostlass_Animator;
		public void FRIdleStandingController()
		{
			// Assign the idle animation clip
			Frostlass_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Frostlass_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}