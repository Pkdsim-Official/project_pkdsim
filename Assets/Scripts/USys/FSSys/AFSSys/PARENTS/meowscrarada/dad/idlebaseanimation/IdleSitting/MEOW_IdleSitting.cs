using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleSitting
{
	public class MEOWIdleSitting : MonoBehaviour 
	{
		private Animator MeowscaradaParentDad_Animator;
		public void MEOWIdleSittingController()
		{
			MeowscaradaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}