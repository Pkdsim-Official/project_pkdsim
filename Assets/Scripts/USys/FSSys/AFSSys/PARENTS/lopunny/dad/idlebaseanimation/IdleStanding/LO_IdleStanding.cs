using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleStanding
{
	public class LOParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator LopunnyParentDad_Animator;
		public void LOParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			LopunnyParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}