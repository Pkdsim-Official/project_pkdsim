using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding
{
	public class JT_IdleStanding : MonoBehaviour 
	{
		public Animator JolteonParent_Animator;
		public void JT_IdleStandingController()
		{
			JolteonParent_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParent_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}