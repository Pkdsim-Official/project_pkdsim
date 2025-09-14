using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleStanding
{
	public class SYLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator SylveonParentMom_Animator;
		public void SYLParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}