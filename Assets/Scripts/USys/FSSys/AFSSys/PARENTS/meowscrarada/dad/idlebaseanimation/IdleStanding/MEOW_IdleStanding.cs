using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleStanding
{
	public class MEOWIdleStanding : MonoBehaviour 
	{
		public Animator MeowscaradaParentDad_Animator;
		public void MEOWIdleStandingController()
		{
			// Assign the idle animation clip
			MeowscaradaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}