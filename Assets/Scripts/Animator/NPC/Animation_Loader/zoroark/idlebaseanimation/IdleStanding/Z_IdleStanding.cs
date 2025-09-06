using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleStanding
{
	public class ZIdleStanding : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public void ZIdleStandingController()
		{
			// Assign the idle animation clip
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}