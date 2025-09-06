using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation.IdleStanding
{
	public class ABIdleStanding : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public void ABIdleStandingController()
		{
			// Assign the idle animation clip
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}