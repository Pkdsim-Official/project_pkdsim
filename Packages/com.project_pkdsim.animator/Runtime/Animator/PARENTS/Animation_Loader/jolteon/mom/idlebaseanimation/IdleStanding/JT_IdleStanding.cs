using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding
{
	public class JTParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public void JTParentMom_IdleStandingController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}