using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleStanding
{
	public class HATIdleStanding : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public void HATIdleStandingController()
		{
			// Assign the idle animation clip
			Hatterene_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Hatterene_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}