using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding
{
	public class BEIdleStanding : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public void BEIdleStandingController()
		{
			// Assign the idle animation clip
			Beedrill_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Beedrill_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}