using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class VPParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator VaporeonParentMom_Animator;
		public void VPParentMom_IdleToWalkController()
		{
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}