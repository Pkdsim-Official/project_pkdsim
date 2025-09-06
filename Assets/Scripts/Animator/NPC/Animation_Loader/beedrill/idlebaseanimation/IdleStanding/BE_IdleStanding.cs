using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding
{
	public class BE_IdleStanding : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public void BE_IdleStandingController()
		{
			// Assign the idle animation clip
			Beedrill_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Beedrill_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}