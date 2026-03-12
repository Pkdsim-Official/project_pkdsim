using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleStanding
{
	public class BRParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator BraixenParentMom_Animator;
		public void BRParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}