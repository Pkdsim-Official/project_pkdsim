using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleStanding
{
	public class LUCAParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator lucarioParentMom_Animator;
		public void LUCAParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			lucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			lucarioParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}