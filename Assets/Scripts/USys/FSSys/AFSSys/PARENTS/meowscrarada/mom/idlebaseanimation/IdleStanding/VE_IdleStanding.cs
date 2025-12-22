using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleStanding
{
	public class MEOWParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator MeowscaradaParentMom_Animator;
		public void MEOWParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			MeowscaradaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}