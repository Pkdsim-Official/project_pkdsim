using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class JTParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator JolteonParentMom_Animator;
		public void JTParentMom_IdleToWalkController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}