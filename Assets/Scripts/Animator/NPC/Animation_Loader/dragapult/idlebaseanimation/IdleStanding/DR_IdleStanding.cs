using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding
{
	public class DRIdleStanding : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public void DRIdleStandingController()
		{
			// Assign the idle animation clip
			Dragapult_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Dragapult_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}