using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleStanding
{
	public class ABParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator AbsolParentMom_Animator;
		public void ABParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}