using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleStanding
{
	public class BLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator BLazikenParentMom_Animator;
		public void BLParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}