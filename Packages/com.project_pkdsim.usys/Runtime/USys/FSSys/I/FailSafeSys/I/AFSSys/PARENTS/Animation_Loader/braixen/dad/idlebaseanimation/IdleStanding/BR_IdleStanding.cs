using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleStanding
{
	public class BRIdleStanding : MonoBehaviour 
	{
		public Animator BraixenParentDad_Animator;
		public void BRIdleStandingController()
		{
			// Assign the idle animation clip
			BraixenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}