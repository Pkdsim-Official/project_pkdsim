using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class BLParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator BLazikenParentMom_Animator;
		public void BLParentMom_IdleToWalkController()
		{
			BLazikenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BLazikenParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}