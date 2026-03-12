using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleStanding
{
	public class CParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator CinderaceParentMom_Animator;
		public void CParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}