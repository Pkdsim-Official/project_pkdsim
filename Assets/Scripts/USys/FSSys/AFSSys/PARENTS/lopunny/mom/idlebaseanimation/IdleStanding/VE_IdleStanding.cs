using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleStanding
{
	public class LOParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator LopunnyParentMom_Animator;
		public void LOParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}