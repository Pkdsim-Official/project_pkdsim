using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleStanding
{
	public class C_IdleStanding : MonoBehaviour 
	{
		public Animator CinderaceParentMom_Animator;
		public void C_IdleStandingController()
		{
			// Assign the idle animation clip
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}