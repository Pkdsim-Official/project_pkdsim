using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding
{
	public class DRIdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public void DRIdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}