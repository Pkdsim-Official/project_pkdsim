using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class SParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator SalazzleParentMom_Animator;
		public void SParentMom_IdleToWalkController()
		{
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}