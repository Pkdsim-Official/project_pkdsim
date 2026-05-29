using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation.IdleStanding
{
	public class FRIdleStanding : MonoBehaviour 
	{
		public Animator FrostlassParentMom_Animator;
		public void FRIdleStandingController()
		{
			// Assign the idle animation clip
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}