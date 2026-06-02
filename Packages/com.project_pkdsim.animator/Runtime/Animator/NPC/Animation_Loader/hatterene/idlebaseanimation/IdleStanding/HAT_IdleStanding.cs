using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleStanding
{
	public class HAT_IdleStanding : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public void HAT_IdleStandingController()
		{
			// Assign the idle animation clip
			Hatterene_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Hatterene_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}