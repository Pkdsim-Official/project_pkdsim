using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class PRParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator PrimarinaParentMom_Animator;
		public void PRParentMom_IdleToWalkController()
		{
			PrimarinaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}