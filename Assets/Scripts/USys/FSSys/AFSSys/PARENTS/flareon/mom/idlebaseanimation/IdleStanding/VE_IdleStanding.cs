using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation.IdleStanding
{
	public class FLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public void FLParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}