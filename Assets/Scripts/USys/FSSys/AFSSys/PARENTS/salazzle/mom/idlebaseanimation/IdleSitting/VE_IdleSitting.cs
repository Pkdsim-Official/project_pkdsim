using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleSitting
{
	public class SParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator SalazzleParentMom_Animator;
		public void SParentMom_IdleSittingController()
		{
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}