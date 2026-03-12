using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class SYLParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator SylveonParentMom_Animator;
		public void SYLParentMom_IdleToWalkController()
		{
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}