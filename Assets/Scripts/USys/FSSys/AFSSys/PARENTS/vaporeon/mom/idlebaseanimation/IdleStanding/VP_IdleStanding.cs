using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation.IdleStanding
{
	public class VPParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator VaporeonParentMom_Animator;
		public void VPParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}