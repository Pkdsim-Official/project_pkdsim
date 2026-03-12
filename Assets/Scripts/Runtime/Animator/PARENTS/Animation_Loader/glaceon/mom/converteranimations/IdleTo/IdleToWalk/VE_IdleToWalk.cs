using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class GLParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		public void GLParentMom_IdleToWalkController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}