using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.idlebaseanimation.IdleSitting
{
	public class SA_IdleSitting : MonoBehaviour 
	{
		private Animator SalazzleParentDad_Animator;
		public void SA_IdleSittingController()
		{
			SalazzleParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}