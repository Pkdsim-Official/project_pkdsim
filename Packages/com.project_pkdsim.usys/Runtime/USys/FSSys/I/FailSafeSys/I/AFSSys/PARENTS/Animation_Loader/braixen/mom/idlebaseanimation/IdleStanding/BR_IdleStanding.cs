using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleStanding
{
	public class BRIdleStanding : MonoBehaviour 
	{
		public Animator BraixenParentMom_Animator;
		public void BRIdleStandingController()
		{
			// Assign the idle animation clip
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}