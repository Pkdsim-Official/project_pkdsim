using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleStanding
{
	public class FL_IdleStanding : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public void FL_IdleStandingController()
		{
			// Assign the idle animation clip
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}