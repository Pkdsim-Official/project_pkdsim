using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleStanding
{
	public class GARDParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator GardevoirParentMom_Animator;
		public void GARDParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}