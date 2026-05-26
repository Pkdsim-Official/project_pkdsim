using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Salazzle.idlebaseanimation.IdleStanding
{
	public class SA_IdleStanding : MonoBehaviour 
	{
		public Animator Salazzle_Animator;
		public void SA_IdleStandingController()
		{
			// Assign the idle animation clip
			Salazzle_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Salazzle_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}