using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.idlebaseanimation.IdleStanding
{
	public class MEOWParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator MeowscaradaParentDad_Animator;
		public void MEOWParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			MeowscaradaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}