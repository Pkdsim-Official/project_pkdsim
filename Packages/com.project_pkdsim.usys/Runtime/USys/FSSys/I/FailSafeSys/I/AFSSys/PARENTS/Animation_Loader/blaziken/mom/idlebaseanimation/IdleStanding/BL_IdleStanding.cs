using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleStanding
{
	public class BL_IdleStanding : MonoBehaviour 
	{
		public Animator BlazikenParentMom_Animator;
		public void BL_IdleStandingController()
		{
			// Assign the idle animation clip
			BlazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BlazikenParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}