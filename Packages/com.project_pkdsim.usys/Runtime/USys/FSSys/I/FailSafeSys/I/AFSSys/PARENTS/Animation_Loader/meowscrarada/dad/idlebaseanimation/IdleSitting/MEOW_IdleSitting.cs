using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.idlebaseanimation.IdleSitting
{
	public class MEOWParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator MeowscaradaParentDad_Animator;
		public void MEOWParentDad_IdleSittingController()
		{
			MeowscaradaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}