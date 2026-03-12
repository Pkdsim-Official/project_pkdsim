using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToRun
{
	public class SParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator SalazzleParentMom_Animator;
		public void SParentMom_IdleToRunController()
		{
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}