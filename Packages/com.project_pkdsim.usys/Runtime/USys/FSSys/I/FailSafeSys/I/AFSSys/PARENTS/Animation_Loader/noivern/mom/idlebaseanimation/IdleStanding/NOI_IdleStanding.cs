using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleStanding
{
	public class NOIIdleStanding : MonoBehaviour 
	{
		public Animator NoivernParentMom_Animator;
		public void NOIIdleStandingController()
		{
			// Assign the idle animation clip
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}