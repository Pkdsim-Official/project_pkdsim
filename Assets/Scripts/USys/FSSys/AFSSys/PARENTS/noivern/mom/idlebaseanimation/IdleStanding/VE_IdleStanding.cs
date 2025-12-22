using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleStanding
{
	public class NOIParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator NoivernParentMom_Animator;
		public void NOIParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}