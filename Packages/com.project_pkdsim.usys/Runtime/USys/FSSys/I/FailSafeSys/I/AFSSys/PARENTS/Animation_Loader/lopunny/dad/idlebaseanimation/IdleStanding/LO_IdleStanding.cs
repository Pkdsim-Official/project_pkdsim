using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleStanding
{
	public class LOParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public void LOParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			Lopunny_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lopunny_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}