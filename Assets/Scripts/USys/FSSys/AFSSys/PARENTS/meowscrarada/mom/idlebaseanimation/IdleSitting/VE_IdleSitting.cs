using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleSitting
{
	public class MEOWParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator MeowscaradaParentMom_Animator;
		public void MEOWParentMom_IdleSittingController()
		{
			MeowscaradaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}