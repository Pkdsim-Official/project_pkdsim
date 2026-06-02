using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding
{
	public class DRParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public void DRParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}